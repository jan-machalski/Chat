namespace Lab_Froms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sendButton = new Button();
            textBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelContainer = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            disconnectToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Location = new Point(297, 526);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.White;
            textBox.Location = new Point(12, 527);
            textBox.Name = "textBox";
            textBox.Size = new Size(279, 23);
            textBox.TabIndex = 1;
            textBox.KeyDown += textBox_KeyDown;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.White;
            panelContainer.Location = new Point(0, 25);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(384, 496);
            panelContainer.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, disconnectToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(180, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Enabled = false;
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new Size(180, 22);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(panelContainer);
            Controls.Add(textBox);
            Controls.Add(sendButton);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(320, 480);
            Name = "Form1";
            Text = "Group Chat";
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendButton;
        private TextBox textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelContainer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
