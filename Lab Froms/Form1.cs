using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Messages;
using System.Net.Sockets;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text;

namespace Lab_Froms
{
    public partial class Form1 : Form
    {
        private Panel panel;
        private bool youSend;
        private string username = "";
        private TcpClient tcpClient = null;
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

        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            AddMessage();
        }
        private void AddToPanel(string author, string message, string time)
        {
            int offset = 49;
            if (author != "you")
                offset = 3;
            var place = new Point(offset, panel.Height);
            var ch = new ChatRectangle(author, message, time, panel.Width);
            panel.Height += (5 + ch.Height);
            ch.Location = place;
            panel.Controls.Add(ch);

        }
        private void AddMessage()
        {

            if (textBox.Text.Length > 0)
            {

                string time = $"{DateTime.Now:HH:mm}";
                var place = new Point(1, 1);
                string text;
                if (youSend)
                    text = "you";
                else
                    text = "not you";
                youSend = !youSend;
                AddToPanel(text, textBox.Text, time);
                if (panel.Height > panelContainer.Height)
                {
                    panelContainer.AutoScrollPosition = new Point(0, panel.Height - panelContainer.Height);
                }
                messages.Add((text, textBox.Text, time));
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
        public async Task ConnectToServer(Form2 child, string address, int port, string username, string key)
        {
            try
            {
                tcpClient = new TcpClient();
                Authorization authorization = new Authorization(username, key);
                string json = JsonSerializer.Serialize(authorization);

                await tcpClient.ConnectAsync(address, port);
                child.UpdateProgressBar(25);


                using (NetworkStream stream = tcpClient.GetStream())
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(json);
                    child.UpdateProgressBar(50);
                    StreamReader streamReader = new StreamReader(stream);
                    string recieved = await streamReader.ReadToEndAsync();
                    MessageBox.Show(recieved);
                    Messages.Message message = JsonSerializer.Deserialize<Messages.Message>(recieved);

                    if (message.Text == Messages.Message.Authorized)
                        child.UpdateProgressBar(75);
                    else
                    {
                        child.UpdateProgressBar(0);
                        connectToolStripMenuItem.Enabled = true;
                        child.Finish("Unable to connect to server");
                        connectToolStripMenuItem.Enabled = true;
                        tcpClient.Close();
                    }
                    child.UpdateProgressBar(100);
                    disconnectToolStripMenuItem.Enabled = true;
                    child.Finish("Connected succesfully");
                }
            }
            catch (Exception ex)
            {
                child.UpdateProgressBar(0);
                connectToolStripMenuItem.Enabled = true;
                child.Finish("Unable to connect to server");
                connectToolStripMenuItem.Enabled = true;
                tcpClient.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tcpClient != null)
            {
                tcpClient.Close();
            }
            this.Close();
        }
    }

}
