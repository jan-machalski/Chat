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

        public ChatRectangle(string author, string message, string time)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            userLabel.Text = author;
            messageLabel.Text = message;
            timeLabel.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString(); 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
