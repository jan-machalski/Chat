namespace ChatServer
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
            ServerMessageBox = new TextBox();
            SendButton = new Button();
            logTextBox = new TextBox();
            ClearButton = new Button();
            label5 = new Label();
            DisconnectAllButton = new Button();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(4, 12);
            StartStopButton.Margin = new Padding(4, 5, 4, 5);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(107, 38);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Start";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView.Columns.AddRange(new ColumnHeader[] { ID_column, NameColumn, DisconnectColumn });
            listView.Enabled = false;
            listView.Location = new Point(511, 3);
            listView.Margin = new Padding(4, 5, 4, 5);
            listView.Name = "listView";
            listView.Size = new Size(321, 514);
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
            label1.Location = new Point(148, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 2;
            label1.Text = "Address:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(351, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            // 
            // AddressBox
            // 
            AddressBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddressBox.Location = new Point(233, 12);
            AddressBox.Margin = new Padding(4, 5, 4, 5);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(105, 31);
            AddressBox.TabIndex = 4;
            AddressBox.Text = "localhost";
            AddressBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PortBox
            // 
            PortBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PortBox.Location = new Point(403, 12);
            PortBox.Margin = new Padding(4, 5, 4, 5);
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(98, 31);
            PortBox.TabIndex = 5;
            PortBox.Text = "9000";
            PortBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UsernameBox.Location = new Point(233, 77);
            UsernameBox.Margin = new Padding(4, 5, 4, 5);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(105, 31);
            UsernameBox.TabIndex = 6;
            UsernameBox.Text = "Server";
            UsernameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // KeyBox
            // 
            KeyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KeyBox.Location = new Point(403, 77);
            KeyBox.Margin = new Padding(4, 5, 4, 5);
            KeyBox.Name = "KeyBox";
            KeyBox.Size = new Size(98, 31);
            KeyBox.TabIndex = 7;
            KeyBox.TextAlign = HorizontalAlignment.Center;
            KeyBox.UseSystemPasswordChar = true;
            KeyBox.TextChanged += KeyBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(134, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 8;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(351, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 9;
            label4.Text = "Key:";
            // 
            // ShowKeyBox
            // 
            ShowKeyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowKeyBox.AutoSize = true;
            ShowKeyBox.Location = new Point(375, 125);
            ShowKeyBox.Margin = new Padding(4, 5, 4, 5);
            ShowKeyBox.Name = "ShowKeyBox";
            ShowKeyBox.Size = new Size(114, 29);
            ShowKeyBox.TabIndex = 10;
            ShowKeyBox.Text = "Show key";
            ShowKeyBox.UseVisualStyleBackColor = true;
            ShowKeyBox.CheckedChanged += ShowKeyBox_CheckedChanged;
            // 
            // ServerMessageBox
            // 
            ServerMessageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServerMessageBox.Location = new Point(4, 480);
            ServerMessageBox.Margin = new Padding(4, 5, 4, 5);
            ServerMessageBox.Name = "ServerMessageBox";
            ServerMessageBox.Size = new Size(381, 31);
            ServerMessageBox.TabIndex = 11;
            // 
            // SendButton
            // 
            SendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendButton.Location = new Point(396, 480);
            SendButton.Margin = new Padding(4, 5, 4, 5);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(107, 38);
            SendButton.TabIndex = 12;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.BackColor = Color.White;
            logTextBox.Location = new Point(4, 240);
            logTextBox.Margin = new Padding(4, 5, 4, 5);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(497, 227);
            logTextBox.TabIndex = 13;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(4, 198);
            ClearButton.Margin = new Padding(4, 5, 4, 5);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(107, 38);
            ClearButton.TabIndex = 15;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Location = new Point(206, 203);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 32);
            label5.TabIndex = 16;
            label5.Text = "Log";
            // 
            // DisconnectAllButton
            // 
            DisconnectAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DisconnectAllButton.Location = new Point(361, 197);
            DisconnectAllButton.Margin = new Padding(4, 5, 4, 5);
            DisconnectAllButton.Name = "DisconnectAllButton";
            DisconnectAllButton.Size = new Size(141, 38);
            DisconnectAllButton.TabIndex = 17;
            DisconnectAllButton.Text = "Disconnect all";
            DisconnectAllButton.UseVisualStyleBackColor = true;
            DisconnectAllButton.Click += DisconnectAllButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 518);
            Controls.Add(DisconnectAllButton);
            Controls.Add(label5);
            Controls.Add(ClearButton);
            Controls.Add(logTextBox);
            Controls.Add(SendButton);
            Controls.Add(ServerMessageBox);
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
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(848, 546);
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
        private TextBox ServerMessageBox;
        private Button SendButton;
        private TextBox logTextBox;
        private Button ClearButton;
        private Label label5;
        private Button DisconnectAllButton;
        private ColumnHeader NameColumn;
        private ColumnHeader DisconnectColumn;
    }
}
