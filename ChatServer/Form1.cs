using System.Net;
using System.Net.Sockets;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private string address = null;
        private string username = null;
        private string key = null;
        private int port = -1;
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<int,TcpClient> clientID = new Dictionary<int,TcpClient>();
        private Dictionary<TcpClient, string> clientNames = new Dictionary<TcpClient, string>(); 
        private int lastID = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowKeyBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowKeyBox.Checked == true)
                KeyBox.UseSystemPasswordChar = false;
            else
                KeyBox.UseSystemPasswordChar = true;
        }
        private void AppendLogTextBox(string text)
        {
            logTextBox.AppendText($"{DateTime.Now:HH:mm} | " + text + Environment.NewLine);
        }
        private async Task Start()
        {

            listener = new TcpListener(IPAddress.Parse(address), port);
            listener.Start();
            AppendLogTextBox("Listening for incoming connections...");
            AppendLogTextBox("IP: " + (IPAddress.Parse(address)).ToString() + ", Port: " + port.ToString());
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                clientID.Add(++lastID, client);
                AppendLogTextBox("New client... Authorizing");
            }

        }
        private async Task HandleClient(TcpClient client)
        {

        }
    }
}
