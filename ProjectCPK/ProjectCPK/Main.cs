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
        AboutForm about_form;
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
            about_form = new AboutForm();
        }
        #region Buttons
        private void addDialog_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_form.Show();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form.Show();
        }
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config_form.Show();
        }
        private void editDialog_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_form.Show();
        }
        private void removeDialog_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove_form.Show();
        }
        #endregion
    }
}
