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
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.byWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(1097, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStoreToolStripMenuItem,
            this.addAccountToolStripMenuItem,
            this.customerAccountsToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addStoreToolStripMenuItem
            // 
            this.addStoreToolStripMenuItem.Name = "addStoreToolStripMenuItem";
            this.addStoreToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.addStoreToolStripMenuItem.Text = "Add";
            this.addStoreToolStripMenuItem.Click += new System.EventHandler(this.addStoreToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.addAccountToolStripMenuItem.Text = "Edit";
            // 
            // customerAccountsToolStripMenuItem
            // 
            this.customerAccountsToolStripMenuItem.Name = "customerAccountsToolStripMenuItem";
            this.customerAccountsToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.customerAccountsToolStripMenuItem.Text = "Remove";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.salesReportsToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byDayToolStripMenuItem,
            this.byItemToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.salesToolStripMenuItem.Text = "Inventory";
            // 
            // byDayToolStripMenuItem
            // 
            this.byDayToolStripMenuItem.Name = "byDayToolStripMenuItem";
            this.byDayToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.byDayToolStripMenuItem.Text = "By Store";
            // 
            // byItemToolStripMenuItem
            // 
            this.byItemToolStripMenuItem.Name = "byItemToolStripMenuItem";
            this.byItemToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.byItemToolStripMenuItem.Text = "By Item";
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byDayToolStripMenuItem1,
            this.byWeekToolStripMenuItem,
            this.byMonthToolStripMenuItem,
            this.byYearToolStripMenuItem});
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            // 
            // byDayToolStripMenuItem1
            // 
            this.byDayToolStripMenuItem1.Name = "byDayToolStripMenuItem1";
            this.byDayToolStripMenuItem1.Size = new System.Drawing.Size(174, 30);
            this.byDayToolStripMenuItem1.Text = "By Day";
            // 
            // byMonthToolStripMenuItem
            // 
            this.byMonthToolStripMenuItem.Name = "byMonthToolStripMenuItem";
            this.byMonthToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.byMonthToolStripMenuItem.Text = "By Month";
            // 
            // byYearToolStripMenuItem
            // 
            this.byYearToolStripMenuItem.Name = "byYearToolStripMenuItem";
            this.byYearToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.byYearToolStripMenuItem.Text = "By Year";
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
            // byWeekToolStripMenuItem
            // 
            this.byWeekToolStripMenuItem.Name = "byWeekToolStripMenuItem";
            this.byWeekToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.byWeekToolStripMenuItem.Text = "By Week";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // RxCPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 578);
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
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byYearToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem byWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
    }
}

