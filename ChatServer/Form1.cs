using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Windows.Forms;
using Messages;
using System.Threading;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private string address = null;
        private string key = null;
        private int port = -1;
        private TcpListener listener;
        private Dictionary<int, TcpClient> clients = new Dictionary<int, TcpClient>();
        private Dictionary<int, string> names = new Dictionary<int, string>();
        private int lastID = 0;
        private bool started = false;
        private static Mutex logBoxMX = new Mutex();
        bool firstMessage = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowKeyBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowKeyBox.Checked == true)
            {
                KeyBox.UseSystemPasswordChar = false;
            }
            else
                KeyBox.UseSystemPasswordChar = true;
        }
        public void AppendLogTextBox(string text)
        {
            string line = Environment.NewLine;
            if (firstMessage)
            {
                firstMessage = false;
                line = "";
            }
            logBoxMX.WaitOne();
            logTextBox.AppendText(line + $"{DateTime.Now:HH:mm} | " + text);
            logBoxMX.ReleaseMutex();
        }
        private async Task Start()
        {

            if (address == "localhost")
                address = "127.0.0.1";
            listener = new TcpListener(IPAddress.Parse(address), port);
            listener.Start();
            AppendLogTextBox("Listening for incoming connections...");
            AppendLogTextBox("IP: " + (IPAddress.Parse(address)).ToString() + ", Port: " + port.ToString());
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                if (client == null)
                    break;
                AppendLogTextBox("New client... Authorizing");
                Task.Run(() => HandleClient(client));
            }


        }
        private async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            string recieved = await reader.ReadLineAsync();
            Messages.Authorization authorization = JsonSerializer.Deserialize<Messages.Authorization>(recieved);
            if (authorization.Key == key)
            {
                AppendLogTextBox(authorization.Sender.ToString() + "has connected");
                clients.Add(lastID, client);
                names.Add(lastID, authorization.Sender.ToString());
                int id = lastID;
                lastID++;

                Messages.Message message = new Messages.Message(UsernameBox.Text, Messages.Message.Authorized, DateTime.Now);
                string json = JsonSerializer.Serialize(message);
                await writer.WriteLineAsync(json);
                await writer.FlushAsync();
                Messages.Message connectMessage = new Messages.Message(UsernameBox.Text, authorization.Sender + " has connected", DateTime.Now);
                string otherjson = JsonSerializer.Serialize(connectMessage);
                foreach (var p in clients)
                {
                    if (p.Value != client)
                    {
                        NetworkStream otherStream = p.Value.GetStream();
                        StreamWriter otherStreamWriter = new StreamWriter(otherStream);
                        await otherStreamWriter.WriteLineAsync(otherjson);
                        await otherStreamWriter.FlushAsync();
                    }
                }
                Task.Run(() => AwaitMessages(client, id));
            }
            else
            {
                Messages.Message message = new Messages.Message(UsernameBox.Text, Messages.Message.Unauthorized, DateTime.Now);
                string json = JsonSerializer.Serialize(message);
                await writer.WriteLineAsync(json);
                await writer.FlushAsync();
                return;
            }
        }
        private async Task AwaitMessages(TcpClient client, int id)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            while (true)
            {
                string recieved = await reader.ReadLineAsync();
                if (recieved == null)
                {
                    Messages.Message m = new Messages.Message(UsernameBox.Text, names[id] + " has disconnected", DateTime.Now);
                    string to_send = JsonSerializer.Serialize(m);
                    foreach (var p in clients)
                    {
                        if (p.Value != client)
                        {
                            NetworkStream otherStream = p.Value.GetStream();
                            StreamWriter otherStreamWriter = new StreamWriter(otherStream);
                            await otherStreamWriter.WriteLineAsync(to_send);
                            await otherStreamWriter.FlushAsync();
                        }
                    }
                    Kick_User(id);
                    return;
                }
                Messages.Message message = JsonSerializer.Deserialize<Messages.Message>(recieved);
                AppendLogTextBox(message.Sender + message.Text);
                foreach (var p in clients)
                {
                    if (p.Value != client)
                    {
                        NetworkStream otherStream = p.Value.GetStream();
                        StreamWriter otherStreamWriter = new StreamWriter(otherStream);
                        await otherStreamWriter.WriteLineAsync(recieved);
                        await otherStreamWriter.FlushAsync();
                    }
                }
            }
        }
        private void Kick_User(int id)
        {
            clients[id].Close();
            AppendLogTextBox(names[id] + " has disconnected");
            clients.Remove(id);
            names.Remove(id);
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (started == false)
            {
                started = true;
                address = AddressBox.Text;
                port = int.Parse(PortBox.Text);
                key = KeyBox.Text;
                AddressBox.Enabled = false;
                PortBox.Enabled = false;
                Task.Run(Start);
                StartStopButton.Text = "Stop";
            }
            else
            {
                AppendLogTextBox("Shutting down current connections");
                foreach (var p in clients)
                    p.Value.Close();
                listener.Stop();
                started = false;
                AddressBox.Enabled = true;
                PortBox.Enabled = true;
                StartStopButton.Text = "Start";
            }
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            key = KeyBox.Text;
        }

        private void DisconnectAllButton_Click(object sender, EventArgs e)
        {
            List<int> ids = clients.Keys.ToList();
            foreach (var id in ids)
                Kick_User(id);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            logBoxMX.WaitOne();
            logTextBox.Text = "";
            firstMessage = true;
            logBoxMX.ReleaseMutex();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            Messages.Message message = new Messages.Message(UsernameBox.Text,ServerMessageBox.Text,DateTime.Now);
            AppendLogTextBox(UsernameBox.Text + ": " + ServerMessageBox.Text);
            string to_send = JsonSerializer.Serialize(message);
            foreach (var p in clients)
            {
                 NetworkStream otherStream = p.Value.GetStream();
                 StreamWriter otherStreamWriter = new StreamWriter(otherStream);
                 await otherStreamWriter.WriteLineAsync(to_send);
                 await otherStreamWriter.FlushAsync();
            }
        }
    }
}
