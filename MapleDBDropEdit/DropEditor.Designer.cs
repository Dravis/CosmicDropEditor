namespace MapleDBDropEdit
{
    partial class DropEditor
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
            label1 = new Label();
            comboBoxConnection = new ComboBox();
            buttonConnect = new Button();
            groupBox1 = new GroupBox();
            buttonAddMob = new Button();
            groupBox2 = new GroupBox();
            labelSpeed = new Label();
            labelEva = new Label();
            labelAcc = new Label();
            labelMDef = new Label();
            labelMAtt = new Label();
            labelPAtt = new Label();
            labelPDef = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            labelXP = new Label();
            labelMP = new Label();
            labelHP = new Label();
            labelLevel = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAddDrop = new Button();
            buttonEditDrop = new Button();
            buttonDeleteDrop = new Button();
            pictureBoxMob = new PictureBox();
            listViewDrops = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            listViewMobs = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            buttonEditConnections = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMob).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Connection:";
            // 
            // comboBoxConnection
            // 
            comboBoxConnection.FormattingEnabled = true;
            comboBoxConnection.Location = new Point(90, 9);
            comboBoxConnection.Name = "comboBoxConnection";
            comboBoxConnection.Size = new Size(204, 23);
            comboBoxConnection.TabIndex = 2;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(300, 9);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(75, 23);
            buttonConnect.TabIndex = 3;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddMob);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(buttonAddDrop);
            groupBox1.Controls.Add(buttonEditDrop);
            groupBox1.Controls.Add(buttonDeleteDrop);
            groupBox1.Controls.Add(pictureBoxMob);
            groupBox1.Controls.Add(listViewDrops);
            groupBox1.Controls.Add(listViewMobs);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 468);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editor";
            // 
            // buttonAddMob
            // 
            buttonAddMob.Location = new Point(184, 437);
            buttonAddMob.Name = "buttonAddMob";
            buttonAddMob.Size = new Size(80, 23);
            buttonAddMob.TabIndex = 9;
            buttonAddMob.Text = "Add Mob..";
            buttonAddMob.UseVisualStyleBackColor = true;
            buttonAddMob.Click += buttonAddMob_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelSpeed);
            groupBox2.Controls.Add(labelEva);
            groupBox2.Controls.Add(labelAcc);
            groupBox2.Controls.Add(labelMDef);
            groupBox2.Controls.Add(labelMAtt);
            groupBox2.Controls.Add(labelPAtt);
            groupBox2.Controls.Add(labelPDef);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(labelXP);
            groupBox2.Controls.Add(labelMP);
            groupBox2.Controls.Add(labelHP);
            groupBox2.Controls.Add(labelLevel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(403, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 113);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Monster Info";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(345, 20);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(28, 15);
            labelSpeed.TabIndex = 27;
            labelSpeed.Text = "###";
            // 
            // labelEva
            // 
            labelEva.AutoSize = true;
            labelEva.Location = new Point(345, 35);
            labelEva.Name = "labelEva";
            labelEva.Size = new Size(28, 15);
            labelEva.TabIndex = 26;
            labelEva.Text = "###";
            // 
            // labelAcc
            // 
            labelAcc.AutoSize = true;
            labelAcc.Location = new Point(345, 50);
            labelAcc.Name = "labelAcc";
            labelAcc.Size = new Size(28, 15);
            labelAcc.TabIndex = 25;
            labelAcc.Text = "###";
            // 
            // labelMDef
            // 
            labelMDef.AutoSize = true;
            labelMDef.Location = new Point(222, 65);
            labelMDef.Name = "labelMDef";
            labelMDef.Size = new Size(35, 15);
            labelMDef.TabIndex = 24;
            labelMDef.Text = "####";
            // 
            // labelMAtt
            // 
            labelMAtt.AutoSize = true;
            labelMAtt.Location = new Point(222, 50);
            labelMAtt.Name = "labelMAtt";
            labelMAtt.Size = new Size(35, 15);
            labelMAtt.TabIndex = 23;
            labelMAtt.Text = "####";
            // 
            // labelPAtt
            // 
            labelPAtt.AutoSize = true;
            labelPAtt.Location = new Point(222, 20);
            labelPAtt.Name = "labelPAtt";
            labelPAtt.Size = new Size(35, 15);
            labelPAtt.TabIndex = 22;
            labelPAtt.Text = "####";
            // 
            // labelPDef
            // 
            labelPDef.AutoSize = true;
            labelPDef.Location = new Point(222, 35);
            labelPDef.Name = "labelPDef";
            labelPDef.Size = new Size(35, 15);
            labelPDef.TabIndex = 21;
            labelPDef.Text = "####";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(280, 50);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 20;
            label12.Text = "Accuracy:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(280, 35);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 19;
            label11.Text = "Evasion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(117, 65);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 18;
            label10.Text = "Magic Defence:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 50);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 17;
            label9.Text = "Magic Attack:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(117, 35);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 16;
            label8.Text = "Physical Defence:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 20);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 15;
            label7.Text = "Physical Attack:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 20);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Speed:";
            // 
            // labelXP
            // 
            labelXP.AutoSize = true;
            labelXP.Location = new Point(48, 65);
            labelXP.Name = "labelXP";
            labelXP.Size = new Size(42, 15);
            labelXP.TabIndex = 13;
            labelXP.Text = "#####";
            // 
            // labelMP
            // 
            labelMP.AutoSize = true;
            labelMP.Location = new Point(48, 50);
            labelMP.Name = "labelMP";
            labelMP.Size = new Size(42, 15);
            labelMP.TabIndex = 12;
            labelMP.Text = "#####";
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Location = new Point(48, 35);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(42, 15);
            labelHP.TabIndex = 11;
            labelHP.Text = "#####";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(48, 20);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(28, 15);
            labelLevel.TabIndex = 10;
            labelLevel.Text = "###";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 65);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 9;
            label5.Text = "XP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 50);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "MP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Level:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 7;
            label3.Text = "HP:";
            // 
            // buttonAddDrop
            // 
            buttonAddDrop.Location = new Point(652, 437);
            buttonAddDrop.Name = "buttonAddDrop";
            buttonAddDrop.Size = new Size(50, 23);
            buttonAddDrop.TabIndex = 5;
            buttonAddDrop.Text = "Add..";
            buttonAddDrop.UseVisualStyleBackColor = true;
            buttonAddDrop.Click += buttonAddDrop_Click;
            // 
            // buttonEditDrop
            // 
            buttonEditDrop.Location = new Point(708, 437);
            buttonEditDrop.Name = "buttonEditDrop";
            buttonEditDrop.Size = new Size(50, 23);
            buttonEditDrop.TabIndex = 4;
            buttonEditDrop.Text = "Edit..";
            buttonEditDrop.UseVisualStyleBackColor = true;
            buttonEditDrop.Click += buttonEditDrop_Click;
            // 
            // buttonDeleteDrop
            // 
            buttonDeleteDrop.Location = new Point(764, 437);
            buttonDeleteDrop.Name = "buttonDeleteDrop";
            buttonDeleteDrop.Size = new Size(50, 23);
            buttonDeleteDrop.TabIndex = 3;
            buttonDeleteDrop.Text = "Delete";
            buttonDeleteDrop.UseVisualStyleBackColor = true;
            buttonDeleteDrop.Click += buttonDeleteDrop_Click;
            // 
            // pictureBoxMob
            // 
            pictureBoxMob.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMob.Location = new Point(270, 20);
            pictureBoxMob.Name = "pictureBoxMob";
            pictureBoxMob.Size = new Size(127, 113);
            pictureBoxMob.TabIndex = 2;
            pictureBoxMob.TabStop = false;
            pictureBoxMob.Paint += pictureBoxMob_Paint;
            // 
            // listViewDrops
            // 
            listViewDrops.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader4, columnHeader9, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewDrops.FullRowSelect = true;
            listViewDrops.Location = new Point(270, 139);
            listViewDrops.MultiSelect = false;
            listViewDrops.Name = "listViewDrops";
            listViewDrops.Size = new Size(544, 292);
            listViewDrops.TabIndex = 1;
            listViewDrops.UseCompatibleStateImageBehavior = false;
            listViewDrops.View = View.Details;
            listViewDrops.SelectedIndexChanged += listViewMobs_SelectedIndexChanged;
            listViewDrops.MouseClick += listViewDrops_MouseClick;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Icon";
            columnHeader10.Width = 45;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Item ID";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Name";
            columnHeader9.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Min Qty";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Max Qty";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Quest ID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Chance";
            // 
            // listViewMobs
            // 
            listViewMobs.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewMobs.Location = new Point(6, 20);
            listViewMobs.MultiSelect = false;
            listViewMobs.Name = "listViewMobs";
            listViewMobs.Size = new Size(258, 411);
            listViewMobs.TabIndex = 0;
            listViewMobs.UseCompatibleStateImageBehavior = false;
            listViewMobs.View = View.Details;
            listViewMobs.SelectedIndexChanged += listViewMobs_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mob ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "# Drops";
            // 
            // statusStrip
            // 
            statusStrip.AccessibleRole = AccessibleRole.Indicator;
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 508);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(844, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // buttonEditConnections
            // 
            buttonEditConnections.Location = new Point(702, 9);
            buttonEditConnections.Name = "buttonEditConnections";
            buttonEditConnections.Size = new Size(124, 23);
            buttonEditConnections.TabIndex = 6;
            buttonEditConnections.Text = "Edit Connections..";
            buttonEditConnections.UseVisualStyleBackColor = true;
            buttonEditConnections.Click += buttonEditConnections_Click;
            // 
            // DropEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 530);
            Controls.Add(buttonEditConnections);
            Controls.Add(statusStrip);
            Controls.Add(groupBox1);
            Controls.Add(buttonConnect);
            Controls.Add(comboBoxConnection);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DropEditor";
            Text = "DB Item Editor";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMob).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBoxConnection;
        private Button buttonConnect;
        private GroupBox groupBox1;
        private ListView listViewDrops;
        private ListView listViewMobs;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private PictureBox pictureBoxMob;
        private ColumnHeader columnHeader10;
        private Button buttonAddDrop;
        private Button buttonEditDrop;
        private Button buttonDeleteDrop;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label labelXP;
        private Label labelMP;
        private Label labelHP;
        private Label labelLevel;
        private Label label7;
        private Label label6;
        private Label labelAcc;
        private Label labelMDef;
        private Label labelMAtt;
        private Label labelPAtt;
        private Label labelPDef;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label labelSpeed;
        private Label labelEva;
        private Button buttonAddMob;
        private Button buttonEditConnections;
    }
}
