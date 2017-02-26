namespace ProjectCPK
{
    partial class AddForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.add_item_tab = new System.Windows.Forms.TabPage();
            this.add_employee_tab = new System.Windows.Forms.TabPage();
            this.add_store_tab = new System.Windows.Forms.TabPage();
            this.add_customer_tab = new System.Windows.Forms.TabPage();
            this.add_batch_tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.add_item_tab);
            this.tabControl1.Controls.Add(this.add_customer_tab);
            this.tabControl1.Controls.Add(this.add_employee_tab);
            this.tabControl1.Controls.Add(this.add_store_tab);
            this.tabControl1.Controls.Add(this.add_batch_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // add_item_tab
            // 
            this.add_item_tab.Location = new System.Drawing.Point(4, 22);
            this.add_item_tab.Name = "add_item_tab";
            this.add_item_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_item_tab.Size = new System.Drawing.Size(786, 473);
            this.add_item_tab.TabIndex = 0;
            this.add_item_tab.Text = "Item";
            this.add_item_tab.UseVisualStyleBackColor = true;
            // 
            // add_employee_tab
            // 
            this.add_employee_tab.Location = new System.Drawing.Point(4, 22);
            this.add_employee_tab.Name = "add_employee_tab";
            this.add_employee_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_employee_tab.Size = new System.Drawing.Size(786, 473);
            this.add_employee_tab.TabIndex = 1;
            this.add_employee_tab.Text = "Employee";
            this.add_employee_tab.UseVisualStyleBackColor = true;
            // 
            // add_store_tab
            // 
            this.add_store_tab.Location = new System.Drawing.Point(4, 22);
            this.add_store_tab.Name = "add_store_tab";
            this.add_store_tab.Size = new System.Drawing.Size(786, 473);
            this.add_store_tab.TabIndex = 2;
            this.add_store_tab.Text = "Store";
            this.add_store_tab.UseVisualStyleBackColor = true;
            // 
            // add_customer_tab
            // 
            this.add_customer_tab.Location = new System.Drawing.Point(4, 22);
            this.add_customer_tab.Name = "add_customer_tab";
            this.add_customer_tab.Size = new System.Drawing.Size(786, 473);
            this.add_customer_tab.TabIndex = 3;
            this.add_customer_tab.Text = "Customer Account";
            this.add_customer_tab.UseVisualStyleBackColor = true;
            // 
            // add_batch_tab
            // 
            this.add_batch_tab.Location = new System.Drawing.Point(4, 22);
            this.add_batch_tab.Name = "add_batch_tab";
            this.add_batch_tab.Size = new System.Drawing.Size(786, 473);
            this.add_batch_tab.TabIndex = 4;
            this.add_batch_tab.Text = "Batch Upload";
            this.add_batch_tab.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddForm";
            this.Text = "AddFrom";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage add_item_tab;
        private System.Windows.Forms.TabPage add_employee_tab;
        private System.Windows.Forms.TabPage add_store_tab;
        private System.Windows.Forms.TabPage add_customer_tab;
        private System.Windows.Forms.TabPage add_batch_tab;
    }
}