using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Lab_Froms
{
    public partial class Form1 : Form
    {
        private Panel panel;
        private bool youSend;

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
                //var ch = new ChatRectangle(text, textBox.Text, time,panel.Width);
                if(panel.Height > panelContainer.Height)
                {
                    panelContainer.AutoScrollPosition = new Point(0, panel.Height - panelContainer.Height);
                }
                messages.Add((text, textBox.Text, time));
                textBox.Text = "";

                //ch.Location = new Point(1, r.Next() % panel.Height);
                //panel.Controls.Add(ch);
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
    }

}
