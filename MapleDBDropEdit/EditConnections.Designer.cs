namespace MapleDBDropEdit
{
    partial class EditConnections
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
            listViewConnections = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            buttonAdd = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // listViewConnections
            // 
            listViewConnections.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewConnections.Location = new Point(12, 12);
            listViewConnections.Name = "listViewConnections";
            listViewConnections.Size = new Size(464, 277);
            listViewConnections.TabIndex = 0;
            listViewConnections.UseCompatibleStateImageBehavior = false;
            listViewConnections.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Host";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Database";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Wz Path";
            columnHeader3.Width = 220;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(356, 295);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(57, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add..";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(419, 295);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(57, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // EditConnections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 325);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(listViewConnections);
            Name = "EditConnections";
            Text = "EditConnections";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewConnections;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}