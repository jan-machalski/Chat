using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messages;

namespace Lab_Froms
{
    public partial class Form2 : Form
    {
        private Form1 parent;
        public Form2()
        {
            InitializeComponent();
            parent = new Form1();
        }
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            keyBox.UseSystemPasswordChar = true;
        }

        private void showKeyBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showKeyBox.Checked == true)
                keyBox.UseSystemPasswordChar = false;
            else
                keyBox.UseSystemPasswordChar = true;
        }
        public void UpdateProgressBar(int l)
        {
            progressBar.Value = l;
        }
        public void Finish(string message)
        {
            MessageBox.Show(message);
            this.Close();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            await parent.ConnectToServer(this, textBoxAddress.Text, int.Parse(portBox.Text), userBox.Text, keyBox.Text);
        }
    }
}
