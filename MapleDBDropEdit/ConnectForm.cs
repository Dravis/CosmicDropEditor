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
    public partial class ConnectForm : Form
    {
        public DatabaseConfig Config { get; set; }

        public ConnectForm()
        {
            InitializeComponent();
            Config = new DatabaseConfig();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Config.Host = textBoxHost.Text;
            Config.Port = textBoxPort.Text;
            Config.Database = textBoxDatabase.Text;
            Config.Username = textBoxUsername.Text;
            Config.Password = textBoxPassword.Text;
            Config.WZPath = textBoxWzPath.Text;
            if (!Config.WZPath.EndsWith('\\'))
                Config.WZPath += "\\";

            this.Close();
        }

    }
}
