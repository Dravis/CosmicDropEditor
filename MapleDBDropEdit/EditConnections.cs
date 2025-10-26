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
    public partial class EditConnections : Form
    {
        List<DatabaseConfig> configs;

        public EditConnections()
        {
            InitializeComponent();
            FillConnectionList();
        }

        public void FillConnectionList()
        {
            listViewConnections.Items.Clear();
            configs = DatabaseConfigManager.Load();
            foreach (DatabaseConfig config in configs)
            {
                ListViewItem listViewItem = new ListViewItem(config.Host + ":" + config.Port);
                listViewItem.SubItems.Add(config.Database);
                listViewItem.SubItems.Add(config.WZPath);
                listViewConnections.Items.Add(listViewItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm();
            connectForm.ShowDialog();
            configs.Add(connectForm.Config);
            DatabaseConfigManager.Save(configs);

            FillConnectionList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm();
            string toCompare = listViewConnections.SelectedItems[0].SubItems[0].Text + listViewConnections.SelectedItems[0].SubItems[1].Text + listViewConnections.SelectedItems[0].SubItems[2].Text;
            configs.Remove(configs.FirstOrDefault(x => x.Host + ":" + x.Port + x.Database + x.WZPath == toCompare));
            DatabaseConfigManager.Save(configs);
            FillConnectionList();
        }
    }
}
