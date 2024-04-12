using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Lab_Froms
{

    public partial class ChatRectangle : UserControl
    {
        public bool you;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // width of ellipse
               int nHeightEllipse // height of ellipse
           );
        public ChatRectangle()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            userLabel.Text = "You";
            messageLabel.Text = "message";
            timeLabel.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        public ChatRectangle(string author, string message, string time,int width)
        {
            InitializeComponent();
            you = (author == "you");
            Width = width - 50;
            using(Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                Height = 60 + (int)Math.Round(g.MeasureString(message, new Font(FontFamily.GenericSansSerif, 11),width).Height);
            }
            //Height = CalculateHeight(message, Width);
            timeLabel.Width = messageLabel.Width = userLabel.Width = Width;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            userLabel.Text = author;
            messageLabel.Text = message;
            timeLabel.Text = time; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
