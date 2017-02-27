namespace ProjectCPK
{
    partial class RxCPK
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.export_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventory_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventory_byStore_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventory_byItem_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReports_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sr_byDay_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sr_byWeek_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sr_byMonth_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sr_byYear_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.export_ToolStripMenuItem,
            this.login_ToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.config_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // export_ToolStripMenuItem
            // 
            this.export_ToolStripMenuItem.Enabled = false;
            this.export_ToolStripMenuItem.Name = "export_ToolStripMenuItem";
            this.export_ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.export_ToolStripMenuItem.Text = "Export";
            this.export_ToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // login_ToolStripMenuItem
            // 
            this.login_ToolStripMenuItem.Name = "login_ToolStripMenuItem";
            this.login_ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.login_ToolStripMenuItem.Text = "Login";
            this.login_ToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // config_ToolStripMenuItem
            // 
            this.config_ToolStripMenuItem.Name = "config_ToolStripMenuItem";
            this.config_ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.config_ToolStripMenuItem.Text = "Config";
            this.config_ToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exit_ToolStripMenuItem.Text = "Exit";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_ToolStripMenuItem,
            this.edit_ToolStripMenuItem,
            this.remove_ToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // add_ToolStripMenuItem
            // 
            this.add_ToolStripMenuItem.Name = "add_ToolStripMenuItem";
            this.add_ToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.add_ToolStripMenuItem.Text = "Add";
            this.add_ToolStripMenuItem.Click += new System.EventHandler(this.addDialog_ToolStripMenuItem_Click);
            // 
            // edit_ToolStripMenuItem
            // 
            this.edit_ToolStripMenuItem.Name = "edit_ToolStripMenuItem";
            this.edit_ToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.edit_ToolStripMenuItem.Text = "Edit";
            this.edit_ToolStripMenuItem.Click += new System.EventHandler(this.editDialog_ToolStripMenuItem_Click);
            // 
            // remove_ToolStripMenuItem
            // 
            this.remove_ToolStripMenuItem.Name = "remove_ToolStripMenuItem";
            this.remove_ToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.remove_ToolStripMenuItem.Text = "Remove";
            this.remove_ToolStripMenuItem.Click += new System.EventHandler(this.removeDialog_ToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventory_ToolStripMenuItem,
            this.salesReports_ToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // inventory_ToolStripMenuItem
            // 
            this.inventory_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventory_byStore_ToolStripMenuItem,
            this.inventory_byItem_ToolStripMenuItem});
            this.inventory_ToolStripMenuItem.Name = "inventory_ToolStripMenuItem";
            this.inventory_ToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.inventory_ToolStripMenuItem.Text = "Inventory";
            // 
            // inventory_byStore_ToolStripMenuItem
            // 
            this.inventory_byStore_ToolStripMenuItem.Name = "inventory_byStore_ToolStripMenuItem";
            this.inventory_byStore_ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.inventory_byStore_ToolStripMenuItem.Text = "By Store";
            // 
            // inventory_byItem_ToolStripMenuItem
            // 
            this.inventory_byItem_ToolStripMenuItem.Name = "inventory_byItem_ToolStripMenuItem";
            this.inventory_byItem_ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.inventory_byItem_ToolStripMenuItem.Text = "By Item";
            // 
            // salesReports_ToolStripMenuItem
            // 
            this.salesReports_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sr_byDay_ToolStripMenuItem1,
            this.sr_byWeek_ToolStripMenuItem,
            this.sr_byMonth_ToolStripMenuItem,
            this.sr_byYear_ToolStripMenuItem});
            this.salesReports_ToolStripMenuItem.Name = "salesReports_ToolStripMenuItem";
            this.salesReports_ToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.salesReports_ToolStripMenuItem.Text = "Sales Reports";
            // 
            // sr_byDay_ToolStripMenuItem1
            // 
            this.sr_byDay_ToolStripMenuItem1.Name = "sr_byDay_ToolStripMenuItem1";
            this.sr_byDay_ToolStripMenuItem1.Size = new System.Drawing.Size(174, 30);
            this.sr_byDay_ToolStripMenuItem1.Text = "By Day";
            // 
            // sr_byWeek_ToolStripMenuItem
            // 
            this.sr_byWeek_ToolStripMenuItem.Name = "sr_byWeek_ToolStripMenuItem";
            this.sr_byWeek_ToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.sr_byWeek_ToolStripMenuItem.Text = "By Week";
            // 
            // sr_byMonth_ToolStripMenuItem
            // 
            this.sr_byMonth_ToolStripMenuItem.Name = "sr_byMonth_ToolStripMenuItem";
            this.sr_byMonth_ToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.sr_byMonth_ToolStripMenuItem.Text = "By Month";
            // 
            // sr_byYear_ToolStripMenuItem
            // 
            this.sr_byYear_ToolStripMenuItem.Name = "sr_byYear_ToolStripMenuItem";
            this.sr_byYear_ToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.sr_byYear_ToolStripMenuItem.Text = "By Year";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RxCPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 37);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RxCPK";
            this.Text = "Rx CPK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem export_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remove_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventory_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventory_byStore_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventory_byItem_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReports_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sr_byDay_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sr_byMonth_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sr_byYear_ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sr_byWeek_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem login_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

