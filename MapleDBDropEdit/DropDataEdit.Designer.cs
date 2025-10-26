namespace MapleDBDropEdit
{
    partial class DropDataEdit
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxItemId = new TextBox();
            textBoxMinQty = new TextBox();
            textBoxMaxQty = new TextBox();
            textBoxChance = new TextBox();
            textBoxQuestId = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label7 = new Label();
            textBoxMobId = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listBoxItems = new ListBox();
            textBoxSearch = new TextBox();
            label8 = new Label();
            buttonSelect = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Item ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Min Qty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Max Qty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Drop Chance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 137);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Quest ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 118);
            label6.Name = "label6";
            label6.Size = new Size(76, 13);
            label6.TabIndex = 5;
            label6.Text = "(x / 1'000'000)";
            // 
            // textBoxItemId
            // 
            textBoxItemId.Location = new Point(76, 41);
            textBoxItemId.Name = "textBoxItemId";
            textBoxItemId.Size = new Size(149, 23);
            textBoxItemId.TabIndex = 6;
            // 
            // textBoxMinQty
            // 
            textBoxMinQty.Location = new Point(76, 71);
            textBoxMinQty.Name = "textBoxMinQty";
            textBoxMinQty.Size = new Size(55, 23);
            textBoxMinQty.TabIndex = 7;
            textBoxMinQty.Text = "1";
            // 
            // textBoxMaxQty
            // 
            textBoxMaxQty.Location = new Point(198, 71);
            textBoxMaxQty.Name = "textBoxMaxQty";
            textBoxMaxQty.Size = new Size(66, 23);
            textBoxMaxQty.TabIndex = 8;
            textBoxMaxQty.Text = "1";
            // 
            // textBoxChance
            // 
            textBoxChance.Location = new Point(97, 100);
            textBoxChance.Name = "textBoxChance";
            textBoxChance.Size = new Size(167, 23);
            textBoxChance.TabIndex = 9;
            textBoxChance.Text = "500000";
            // 
            // textBoxQuestId
            // 
            textBoxQuestId.Location = new Point(97, 129);
            textBoxQuestId.Name = "textBoxQuestId";
            textBoxQuestId.Size = new Size(167, 23);
            textBoxQuestId.TabIndex = 10;
            textBoxQuestId.Text = "0";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(189, 164);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(13, 164);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 15);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 13;
            label7.Text = "Mob Id:";
            // 
            // textBoxMobId
            // 
            textBoxMobId.Enabled = false;
            textBoxMobId.Location = new Point(76, 12);
            textBoxMobId.Name = "textBoxMobId";
            textBoxMobId.Size = new Size(188, 23);
            textBoxMobId.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(231, 42);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 15;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSelect);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(listBoxItems);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(288, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 175);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Finder";
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 15;
            listBoxItems.Location = new Point(6, 58);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(239, 79);
            listBoxItems.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(80, 24);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(165, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 27);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 2;
            label8.Text = "Item Name:";
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(181, 143);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(64, 23);
            buttonSelect.TabIndex = 3;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // DropDataEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 195);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBoxMobId);
            Controls.Add(label7);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxQuestId);
            Controls.Add(textBoxChance);
            Controls.Add(textBoxMaxQty);
            Controls.Add(textBoxMinQty);
            Controls.Add(textBoxItemId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DropDataEdit";
            Text = "Drop Data Edit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxItemId;
        private TextBox textBoxMinQty;
        private TextBox textBoxMaxQty;
        private TextBox textBoxChance;
        private TextBox textBoxQuestId;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label7;
        private TextBox textBoxMobId;
        private Button button1;
        private GroupBox groupBox1;
        private ListBox listBoxItems;
        private TextBox textBoxSearch;
        private Button buttonSelect;
        private Label label8;
    }
}