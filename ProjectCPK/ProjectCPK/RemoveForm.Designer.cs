namespace ProjectCPK
{
    partial class RemoveForm
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
            this.remove_item_tab = new System.Windows.Forms.TabPage();
            this.remove_customer_tab = new System.Windows.Forms.TabPage();
            this.remove_employee_tab = new System.Windows.Forms.TabPage();
            this.remove_store_tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.remove_item_tab);
            this.tabControl1.Controls.Add(this.remove_customer_tab);
            this.tabControl1.Controls.Add(this.remove_employee_tab);
            this.tabControl1.Controls.Add(this.remove_store_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 484);
            this.tabControl1.TabIndex = 1;
            // 
            // remove_item_tab
            // 
            this.remove_item_tab.Location = new System.Drawing.Point(4, 29);
            this.remove_item_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_item_tab.Name = "remove_item_tab";
            this.remove_item_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_item_tab.Size = new System.Drawing.Size(720, 451);
            this.remove_item_tab.TabIndex = 0;
            this.remove_item_tab.Text = "Item";
            this.remove_item_tab.UseVisualStyleBackColor = true;
            // 
            // remove_customer_tab
            // 
            this.remove_customer_tab.Location = new System.Drawing.Point(4, 29);
            this.remove_customer_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_customer_tab.Name = "remove_customer_tab";
            this.remove_customer_tab.Size = new System.Drawing.Size(1000, 431);
            this.remove_customer_tab.TabIndex = 3;
            this.remove_customer_tab.Text = "Customer Account";
            this.remove_customer_tab.UseVisualStyleBackColor = true;
            // 
            // remove_employee_tab
            // 
            this.remove_employee_tab.Location = new System.Drawing.Point(4, 29);
            this.remove_employee_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_employee_tab.Name = "remove_employee_tab";
            this.remove_employee_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_employee_tab.Size = new System.Drawing.Size(1000, 431);
            this.remove_employee_tab.TabIndex = 1;
            this.remove_employee_tab.Text = "Employee";
            this.remove_employee_tab.UseVisualStyleBackColor = true;
            // 
            // remove_store_tab
            // 
            this.remove_store_tab.Location = new System.Drawing.Point(4, 29);
            this.remove_store_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_store_tab.Name = "remove_store_tab";
            this.remove_store_tab.Size = new System.Drawing.Size(1000, 431);
            this.remove_store_tab.TabIndex = 2;
            this.remove_store_tab.Text = "Store";
            this.remove_store_tab.UseVisualStyleBackColor = true;
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 484);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RemoveForm";
            this.Text = "Remove";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage remove_item_tab;
        private System.Windows.Forms.TabPage remove_customer_tab;
        private System.Windows.Forms.TabPage remove_employee_tab;
        private System.Windows.Forms.TabPage remove_store_tab;
    }
}