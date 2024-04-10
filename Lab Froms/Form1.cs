using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Messages;
using System.Net.Sockets;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text;
using System.IO;

namespace Lab_Froms
{
    public partial class Form1 : Form
    {
        private Panel panel;
        private bool youSend;
        private string username = "";
        private TcpClient tcpClient = null;
        private string name = null;
        private bool connected = false;

        //private Bitmap messageArea;
        List<(string who, string message, string when)> messages;
        public Form1()
        {
            InitializeComponent();


            messages = new List<(string who, string message, string when)>();
            youSend = true;
            panel = new Panel();
            panel.Size = new Size(panelContainer.Width - 20, 5);
            panel.BackColor = Color.White;
            panelContainer.Controls.Add(panel);

            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            AddMessage();
        }
        private void AddToPanel(string author, string message, string time)
        {
            if (author != null)
            {
                int offset = 49;
                if (author != "you")
                    offset = 1;
                var place = new Point(offset, panel.Height);
                var ch = new ChatRectangle(author, message, time, panel.Width);
                panel.Height += (5 + ch.Height);
                ch.Location = place;
                panel.Controls.Add(ch);
            }
            else
            {

                Label connectedLabel = new Label();
                connectedLabel.Text = message;
                connectedLabel.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Regular);
                connectedLabel.ForeColor = Color.DarkGray;
                connectedLabel.BackColor = Color.Transparent;
                var place = new Point(panel.Width / 2 - 20, panel.Height);
                connectedLabel.Location = place;
                panel.Height += (5 + connectedLabel.Height);
                panel.Controls.Add(connectedLabel);

            }

        }
        private async void AddMessage(string user, string message, DateTime time)
        {
            string when = $"{time:HH:mm}";
            AddToPanel(user, message, when);
            messages.Add((user, message, when));
            if (panel.Height > panelContainer.Height)
            {
                panelContainer.AutoScrollPosition = new Point(0, panel.Height - panelContainer.Height);
            }
        }
        private async void AddMessage()
        {

            if (textBox.Text.Length > 0)
            {

                string time = $"{DateTime.Now:HH:mm}";
                await SendMessage(new Messages.Message(name, textBox.Text, DateTime.Now));
                AddToPanel("you", textBox.Text, time);
                if (panel.Height > panelContainer.Height)
                {
                    panelContainer.AutoScrollPosition = new Point(0, panel.Height - panelContainer.Height);
                }
                messages.Add(("you", textBox.Text, time));
                textBox.Text = "";
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddMessage();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            panelContainer.Location = new Point(0, 25);
            panelContainer.Size = new Size(this.Width - 16, textBox.Location.Y - 5 - 25);
            panelContainer.Controls.Clear();
            panel = new Panel();
            panel.Controls.Clear();
            panel.Size = new Size(panelContainer.Width - 20, 5);
            panel.BackColor = Color.White;
            panelContainer.Controls.Add(panel);
            foreach (var t in messages)
                AddToPanel(t.who, t.message, t.when);


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectToolStripMenuItem.Enabled = false;
            Form2 connect_window = new Form2(this);
            connect_window.ShowDialog();
        }
        public async Task SendMessage(Messages.Message message)
        {
            if (tcpClient == null)
                return;
            string json = JsonSerializer.Serialize(message);
            NetworkStream stream = tcpClient.GetStream();

            StreamWriter writer = new StreamWriter(stream);
            await writer.WriteLineAsync(json);
            await writer.FlushAsync();

        }
        public async Task ConnectToServer(Form2 child, string address, int port, string username, string key)
        {

            name = username;
            tcpClient = new TcpClient();
            Authorization authorization = new Authorization(username, key);
            string json = JsonSerializer.Serialize(authorization);

            await tcpClient.ConnectAsync(address, port);
            child.UpdateProgressBar(25);


            NetworkStream stream = tcpClient.GetStream();

            StreamWriter writer = new StreamWriter(stream);
            await writer.WriteLineAsync(json);
            await writer.FlushAsync();

            child.UpdateProgressBar(50);
            StreamReader streamReader = new StreamReader(stream);
            string recieved = streamReader.ReadLine();
            Messages.Message message = JsonSerializer.Deserialize<Messages.Message>(recieved);


            if (message.Text == Messages.Message.Authorized)
            {
                child.UpdateProgressBar(75);
            }
            else
            {

                child.UpdateProgressBar(0);
                connectToolStripMenuItem.Enabled = true;
                child.Finish("Unable to connect to serverA");
                connectToolStripMenuItem.Enabled = true;
                tcpClient.Close();
            }

            child.UpdateProgressBar(100);
            messages.Add((null, "Connected", null));
            AddToPanel(null, "Connected", null);
            disconnectToolStripMenuItem.Enabled = true;
            child.Finish("Connected succesfully");
            ReadMessages();

        }
        public async Task ReadMessages()
        {
            Stream stream = tcpClient.GetStream();
            StreamReader streamReader = new StreamReader(stream);
            while (tcpClient != null)
            {
                
                string recieved = await streamReader.ReadLineAsync();
                if(recieved == null)
                {
                    Server_Disconnect();
                }
                Messages.Message message = JsonSerializer.Deserialize<Messages.Message>(recieved);
                AddMessage(message.Sender, message.Text, message.Time);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
            this.Close();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server_Disconnect();
        }
        private void Server_Disconnect()
        {
            tcpClient.Close();
            disconnectToolStripMenuItem.Enabled = false;
            connectToolStripMenuItem.Enabled = true;
            AddMessage(null, "Disconnected", DateTime.Now);
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tcpClient !=null)
                tcpClient.Close();
        }
    }

}
