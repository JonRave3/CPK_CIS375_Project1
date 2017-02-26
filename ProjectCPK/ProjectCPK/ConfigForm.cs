using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCPK
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void config_save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void config_testConn_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
