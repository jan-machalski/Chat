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
            Canvas = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chatRectangle1 = new ChatRectangle();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
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
            textBox.Location = new Point(12, 527);
            textBox.Name = "textBox";
            textBox.Size = new Size(279, 23);
            textBox.TabIndex = 1;
            // 
            // Canvas
            // 
            Canvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Canvas.Location = new Point(5, 5);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(373, 515);
            Canvas.TabIndex = 2;
            Canvas.TabStop = false;
            // 
            // chatRectangle1
            // 
            chatRectangle1.BackColor = Color.Orange;
            chatRectangle1.Location = new Point(72, 108);
            chatRectangle1.Name = "chatRectangle1";
            chatRectangle1.Size = new Size(219, 65);
            chatRectangle1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(chatRectangle1);
            Controls.Add(Canvas);
            Controls.Add(textBox);
            Controls.Add(sendButton);
            MinimumSize = new Size(320, 480);
            Name = "Form1";
            Text = "Group Chat";
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendButton;
        private TextBox textBox;
        private PictureBox Canvas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ChatRectangle chatRectangle1;
    }
}
