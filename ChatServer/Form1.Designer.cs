﻿namespace ChatServer
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
            StartStopButton = new Button();
            listView = new ListView();
            ID_column = new ColumnHeader();
            NameColumn = new ColumnHeader();
            DisconnectColumn = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            AddressBox = new TextBox();
            PortBox = new TextBox();
            UsernameBox = new TextBox();
            KeyBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ShowKeyBox = new CheckBox();
            MessageBox = new TextBox();
            SendButton = new Button();
            logTextBox = new TextBox();
            ClearButton = new Button();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(3, 7);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(75, 23);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Start";
            StartStopButton.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView.Columns.AddRange(new ColumnHeader[] { ID_column, NameColumn, DisconnectColumn });
            listView.Enabled = false;
            listView.Location = new Point(358, 2);
            listView.Name = "listView";
            listView.Size = new Size(226, 310);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // ID_column
            // 
            ID_column.Text = "ID";
            ID_column.Width = 68;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 80;
            // 
            // DisconnectColumn
            // 
            DisconnectColumn.Text = "Disconnect";
            DisconnectColumn.Width = 80;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(114, 10);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Address:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(253, 10);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            // 
            // AddressBox
            // 
            AddressBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddressBox.Location = new Point(163, 7);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(75, 23);
            AddressBox.TabIndex = 4;
            AddressBox.Text = "localhost";
            AddressBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PortBox
            // 
            PortBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PortBox.Location = new Point(282, 7);
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(70, 23);
            PortBox.TabIndex = 5;
            PortBox.Text = "9000";
            PortBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UsernameBox.Location = new Point(163, 46);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(75, 23);
            UsernameBox.TabIndex = 6;
            UsernameBox.Text = "Server";
            UsernameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // KeyBox
            // 
            KeyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KeyBox.Location = new Point(282, 46);
            KeyBox.Name = "KeyBox";
            KeyBox.PasswordChar = '*';
            KeyBox.Size = new Size(70, 23);
            KeyBox.TabIndex = 7;
            KeyBox.TextAlign = HorizontalAlignment.Center;
            KeyBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(94, 49);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(253, 49);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "Key:";
            // 
            // ShowKeyBox
            // 
            ShowKeyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowKeyBox.AutoSize = true;
            ShowKeyBox.Location = new Point(266, 75);
            ShowKeyBox.Name = "ShowKeyBox";
            ShowKeyBox.Size = new Size(76, 19);
            ShowKeyBox.TabIndex = 10;
            ShowKeyBox.Text = "Show key";
            ShowKeyBox.UseVisualStyleBackColor = true;
            ShowKeyBox.CheckedChanged += ShowKeyBox_CheckedChanged;
            // 
            // MessageBox
            // 
            MessageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessageBox.Location = new Point(3, 288);
            MessageBox.Name = "MessageBox";
            MessageBox.Size = new Size(268, 23);
            MessageBox.TabIndex = 11;
            // 
            // SendButton
            // 
            SendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendButton.Location = new Point(277, 288);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(75, 23);
            SendButton.TabIndex = 12;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.Location = new Point(3, 144);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.Size = new Size(349, 138);
            logTextBox.TabIndex = 13;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(3, 119);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 15;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Location = new Point(152, 122);
            label5.Name = "label5";
            label5.Size = new Size(29, 19);
            label5.TabIndex = 16;
            label5.Text = "Log";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(253, 118);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 17;
            button1.Text = "Disconnect all";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(ClearButton);
            Controls.Add(logTextBox);
            Controls.Add(SendButton);
            Controls.Add(MessageBox);
            Controls.Add(ShowKeyBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(KeyBox);
            Controls.Add(UsernameBox);
            Controls.Add(PortBox);
            Controls.Add(AddressBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView);
            Controls.Add(StartStopButton);
            MinimumSize = new Size(600, 350);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopButton;
        private ListView listView;
        private ColumnHeader ID_column;
        private Label label1;
        private Label label2;
        private TextBox AddressBox;
        private TextBox PortBox;
        private TextBox UsernameBox;
        private TextBox KeyBox;
        private Label label3;
        private Label label4;
        private CheckBox ShowKeyBox;
        private TextBox MessageBox;
        private Button SendButton;
        private TextBox logTextBox;
        private Button ClearButton;
        private Label label5;
        private Button button1;
        private ColumnHeader NameColumn;
        private ColumnHeader DisconnectColumn;
    }
}
