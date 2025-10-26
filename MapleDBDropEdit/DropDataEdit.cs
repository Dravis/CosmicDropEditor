using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleDBDropEdit
{


    public partial class DropDataEdit : Form
    {
        public enum EditorState
        {
            AddMonster,
            Add,
            Edit
        }

        EditorState editorState;
        public bool Save;
        public MobDropData dropData;
        long recordID;
        Dictionary<string, string> items;

        public DropDataEdit(EditorState state)
        {
            InitializeComponent();
            Save = false;
            dropData = new MobDropData();
            editorState = state;

            if (state == EditorState.Add)
                recordID = 0;

            if (state == EditorState.AddMonster)
                textBoxMobId.Enabled = true;

            Width = 290;
        }

        public void SetData(MobDropData dropData)
        {
            this.dropData = dropData;
            recordID = dropData.ID;
            textBoxMobId.Text = dropData.MobId.ToString();
            textBoxItemId.Text = dropData.ItemId.ToString();
            textBoxMinQty.Text = dropData.MinimumQuantity.ToString();
            textBoxMaxQty.Text = dropData.MaximumQuantity.ToString();
            textBoxChance.Text = dropData.Chance.ToString();
            textBoxQuestId.Text = dropData.QuestId.ToString();
        }

        public void SetData(int mobId)
        {
            textBoxMobId.Text = mobId.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save = true;
            dropData.ID = recordID;
            dropData.MobId = int.Parse(textBoxMobId.Text);
            dropData.ItemId = int.Parse(textBoxItemId.Text);
            dropData.MinimumQuantity = int.Parse(textBoxMinQty.Text);
            dropData.MaximumQuantity = int.Parse(textBoxMaxQty.Text);
            dropData.Chance = int.Parse(textBoxChance.Text);
            dropData.QuestId = int.Parse(textBoxQuestId.Text);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Save = false;
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (items == null)
            {
                WZDataProvider wzProvider = WZDataProvider.GetInstance();
                items = wzProvider.GetAllItemIDNames();
            }

            if (Width == 290)
                Width = 567;
            else
                Width = 290;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = textBoxSearch.Text.ToLower();

            List<KeyValuePair<string, string>> res = items.Where(x => x.Value.ToLower().Contains(textToSearch)).Take(100).ToList();
            listBoxItems.Items.Clear();
            foreach (KeyValuePair<string, string> item in res)
                listBoxItems.Items.Add(item.Key + " - " + item.Value);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                string textToEnter = (string)listBoxItems.SelectedItem;
                textToEnter = textToEnter.Substring(0, textToEnter.IndexOf(" -"));
                textBoxItemId.Text = textToEnter;
            }
        }
    }
}
