namespace MapleDBDropEdit
{
    partial class ConnectForm
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
            textBoxHost = new TextBox();
            textBoxPort = new TextBox();
            textBoxDatabase = new TextBox();
            textBoxUsername = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxWzPath = new TextBox();
            SuspendLayout();
            // 
            // textBoxHost
            // 
            textBoxHost.Location = new Point(53, 12);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.Size = new Size(155, 23);
            textBoxHost.TabIndex = 0;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(252, 12);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(67, 23);
            textBoxPort.TabIndex = 1;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Location = new Point(81, 41);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(238, 23);
            textBoxDatabase.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(81, 70);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(238, 23);
            textBoxUsername.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 163);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(252, 163);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Host:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 15);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 44);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Database:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Username:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(81, 99);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(238, 23);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 11;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 131);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "WZ Path:";
            // 
            // textBoxWzPath
            // 
            textBoxWzPath.Location = new Point(81, 128);
            textBoxWzPath.Name = "textBoxWzPath";
            textBoxWzPath.Size = new Size(238, 23);
            textBoxWzPath.TabIndex = 5;
            textBoxWzPath.TextChanged += textBox1_TextChanged;
            // 
            // ConnectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 198);
            Controls.Add(label6);
            Controls.Add(textBoxWzPath);
            Controls.Add(label5);
            Controls.Add(textBoxPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxDatabase);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxHost);
            Name = "ConnectForm";
            Text = "Connection..";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHost;
        private TextBox textBoxPort;
        private TextBox textBoxDatabase;
        private TextBox textBoxUsername;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label6;
        private TextBox textBoxWzPath;
    }
}