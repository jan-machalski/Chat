namespace Lab_Froms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxAddress = new TextBox();
            portLabel = new Label();
            portBox = new TextBox();
            userBox = new TextBox();
            label2 = new Label();
            keyLabel = new Label();
            keyBox = new TextBox();
            showKeyBox = new CheckBox();
            progressBar = new ProgressBar();
            connectButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(70, 20);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 1;
            textBoxAddress.Text = "localhost";
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(201, 23);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(32, 15);
            portLabel.TabIndex = 2;
            portLabel.Text = "Port:";
            // 
            // portBox
            // 
            portBox.Location = new Point(239, 20);
            portBox.Name = "portBox";
            portBox.Size = new Size(100, 23);
            portBox.TabIndex = 3;
            portBox.Text = "9000";
            portBox.TextAlign = HorizontalAlignment.Center;
            // 
            // userBox
            // 
            userBox.Location = new Point(70, 63);
            userBox.Name = "userBox";
            userBox.Size = new Size(100, 23);
            userBox.TabIndex = 4;
            userBox.Text = "user";
            userBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(201, 66);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(29, 15);
            keyLabel.TabIndex = 6;
            keyLabel.Text = "Key:";
            // 
            // keyBox
            // 
            keyBox.Location = new Point(239, 63);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(100, 23);
            keyBox.TabIndex = 7;
            keyBox.TextAlign = HorizontalAlignment.Center;
            // 
            // showKeyBox
            // 
            showKeyBox.AutoSize = true;
            showKeyBox.Location = new Point(256, 92);
            showKeyBox.Name = "showKeyBox";
            showKeyBox.Size = new Size(76, 19);
            showKeyBox.TabIndex = 8;
            showKeyBox.Text = "Show key";
            showKeyBox.UseVisualStyleBackColor = true;
            showKeyBox.CheckedChanged += showKeyBox_CheckedChanged;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 112);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(239, 23);
            progressBar.Step = 25;
            progressBar.TabIndex = 9;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(257, 112);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(82, 23);
            connectButton.TabIndex = 10;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 143);
            Controls.Add(connectButton);
            Controls.Add(progressBar);
            Controls.Add(showKeyBox);
            Controls.Add(keyBox);
            Controls.Add(keyLabel);
            Controls.Add(label2);
            Controls.Add(userBox);
            Controls.Add(portBox);
            Controls.Add(portLabel);
            Controls.Add(textBoxAddress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Connect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAddress;
        private Label portLabel;
        private TextBox portBox;
        private TextBox userBox;
        private Label label2;
        private Label keyLabel;
        private TextBox keyBox;
        private CheckBox showKeyBox;
        private ProgressBar progressBar;
        private Button connectButton;
    }
}