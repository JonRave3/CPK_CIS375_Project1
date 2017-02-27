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
            string server = config_server_txtbx.Text;
            string database = config_db_txtbx.Text;
            string un = config_un_txtbx.Text;
            string pw = config_pw_txtbx.Text;
            string conn_str = String.Format("server={0};database={1};uid={2};pwd={3};", server, database, un, pw);
            RxCPK.connection.UpdateConnection(conn_str);
            this.Close();
        }

        private void config_testConn_btn_Click(object sender, EventArgs e)
        {
            string server = config_server_txtbx.Text;
            string database = config_db_txtbx.Text;
            string un = config_un_txtbx.Text;
            string pw = config_pw_txtbx.Text;
            string conn_str = String.Format("server={0};database={1};uid={2};pwd={3};", server, database, un, pw);
            if (RxCPK.connection.TestConnection(conn_str))
            {
                MessageBox.Show("Connection Successful!");
            }
            else MessageBox.Show("Connection Failed! :(");
        }
    }
}
