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
    public partial class RxCPK : Form
    {
        AddForm add_form;
        LoginForm login_form;
        EditForm edit_form;
        RemoveForm remove_form;
        ConfigForm config_form;
        public RxCPK()
        {
            InitializeComponent();
            InitializeWindows();
        }
        private void InitializeWindows()
        {
            add_form = new AddForm();
            login_form = new LoginForm();
            edit_form = new EditForm();
            remove_form = new RemoveForm();
            config_form = new ConfigForm();
        }
        #region Buttons
        private void addStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config_form.Show();
        }
    }
}
