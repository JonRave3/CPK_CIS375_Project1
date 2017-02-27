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
        protected internal static bool isLoggedIn {get; set;}
        protected internal static DBConnect connection;
        public RxCPK()
        {
            InitializeComponent();
            connection = new DBConnect();
            isLoggedIn = false;
        }
        
        #region Buttons Actions
        private void addDialog_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddForm().Show();
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
            new AboutForm().Show();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginForm(this).Show();
        }
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigForm().Show();
        }
        private void editDialog_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditForm().Show();
        }
        private void removeDialog_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveForm().Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            checkLoggedIn();
            MessageBox.Show("You have been logged out the System!", "Logged Out!", MessageBoxButtons.OK);
        }
        #endregion


        #region Helper Methods
        protected internal void checkLoggedIn()
        {
            if (isLoggedIn)
            {
                viewToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                export_ToolStripMenuItem.Enabled = true;
            }
            else 
            {
                viewToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                export_ToolStripMenuItem.Enabled = false;
            }
        }
        #endregion

    }
}
