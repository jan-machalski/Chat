namespace Lab_Froms
{
    public partial class Form1 : Form
    {
        private bool youSend;
        private Bitmap messageArea;
        List<ChatRectangle> messages;
        public Form1()
        {
            InitializeComponent();
            youSend = true;
            messageArea = new Bitmap(Canvas.Width, Canvas.Height);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length >0)
            {

                using (Graphics g = Graphics.FromImage(messageArea))
                {
                    string time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                    var place = new Point(1, 1);
                    string text;
                    if (youSend)
                    {
                        text = "you";
                    }
                    else
                        text = "not you";
                    youSend = !youSend;
                    var ch = new ChatRectangle(text, textBox.Text, time);
                    ch.DrawToBitmap(messageArea, new Rectangle (20,20,ch.Width+20,ch.Height+20 ));
                    //messageArea.Clear(Color.White);
                    Canvas.Image = messageArea;
                    Canvas.Refresh();
                }
            }
        }
    }

}
