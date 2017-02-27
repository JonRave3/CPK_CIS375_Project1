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
            this.add_itemQtyUnits_combo = new System.Windows.Forms.ComboBox();
            this.add_itemDesc_txtbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.add_itemQty_txtbx = new System.Windows.Forms.TextBox();
            this.add_itemDose_txtbx = new System.Windows.Forms.TextBox();
            this.add_item_productMan_txtbx = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.add_itemName_lbl = new System.Windows.Forms.Label();
            this.add_itemSubmit_btn = new System.Windows.Forms.Button();
            this.add_customer_tab = new System.Windows.Forms.TabPage();
            this.add_customerAccount_btn = new System.Windows.Forms.Button();
            this.add_state_txtbx = new System.Windows.Forms.TextBox();
            this.add_zip_txtbx = new System.Windows.Forms.TextBox();
            this.add_lname_txtbx = new System.Windows.Forms.TextBox();
            this.add_bday_txtbx = new System.Windows.Forms.TextBox();
            this.add_ssn_txtbx = new System.Windows.Forms.TextBox();
            this.add_addr_txtbx = new System.Windows.Forms.TextBox();
            this.add_city_txtbx = new System.Windows.Forms.TextBox();
            this.add_fname_txtbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_employee_tab = new System.Windows.Forms.TabPage();
            this.add_store_tab = new System.Windows.Forms.TabPage();
            this.add_batch_tab = new System.Windows.Forms.TabPage();
            this.add_itemDoseUnits_combo = new System.Windows.Forms.ComboBox();
            this.add_item_productID_txtbx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.add_item_tab.SuspendLayout();
            this.add_customer_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.add_item_tab);
            this.tabControl1.Controls.Add(this.add_batch_tab);
            this.tabControl1.Controls.Add(this.add_customer_tab);
            this.tabControl1.Controls.Add(this.add_employee_tab);
            this.tabControl1.Controls.Add(this.add_store_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // add_item_tab
            // 
            this.add_item_tab.Controls.Add(this.add_item_productID_txtbx);
            this.add_item_tab.Controls.Add(this.label13);
            this.add_item_tab.Controls.Add(this.add_itemDoseUnits_combo);
            this.add_item_tab.Controls.Add(this.add_itemQtyUnits_combo);
            this.add_item_tab.Controls.Add(this.add_itemDesc_txtbx);
            this.add_item_tab.Controls.Add(this.label12);
            this.add_item_tab.Controls.Add(this.add_itemQty_txtbx);
            this.add_item_tab.Controls.Add(this.add_itemDose_txtbx);
            this.add_item_tab.Controls.Add(this.add_item_productMan_txtbx);
            this.add_item_tab.Controls.Add(this.textBox1);
            this.add_item_tab.Controls.Add(this.label11);
            this.add_item_tab.Controls.Add(this.label9);
            this.add_item_tab.Controls.Add(this.label10);
            this.add_item_tab.Controls.Add(this.add_itemName_lbl);
            this.add_item_tab.Controls.Add(this.add_itemSubmit_btn);
            this.add_item_tab.Location = new System.Drawing.Point(4, 22);
            this.add_item_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_item_tab.Name = "add_item_tab";
            this.add_item_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_item_tab.Size = new System.Drawing.Size(315, 358);
            this.add_item_tab.TabIndex = 0;
            this.add_item_tab.Text = "Item";
            this.add_item_tab.UseVisualStyleBackColor = true;
            // 
            // add_itemQtyUnits_combo
            // 
            this.add_itemQtyUnits_combo.FormattingEnabled = true;
            this.add_itemQtyUnits_combo.Items.AddRange(new object[] {
            "btl",
            "pkg",
            "case"});
            this.add_itemQtyUnits_combo.Location = new System.Drawing.Point(208, 120);
            this.add_itemQtyUnits_combo.Name = "add_itemQtyUnits_combo";
            this.add_itemQtyUnits_combo.Size = new System.Drawing.Size(50, 21);
            this.add_itemQtyUnits_combo.TabIndex = 11;
            // 
            // add_itemDesc_txtbx
            // 
            this.add_itemDesc_txtbx.Location = new System.Drawing.Point(23, 170);
            this.add_itemDesc_txtbx.Multiline = true;
            this.add_itemDesc_txtbx.Name = "add_itemDesc_txtbx";
            this.add_itemDesc_txtbx.Size = new System.Drawing.Size(179, 146);
            this.add_itemDesc_txtbx.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Description";
            // 
            // add_itemQty_txtbx
            // 
            this.add_itemQty_txtbx.Location = new System.Drawing.Point(102, 121);
            this.add_itemQty_txtbx.Name = "add_itemQty_txtbx";
            this.add_itemQty_txtbx.Size = new System.Drawing.Size(100, 20);
            this.add_itemQty_txtbx.TabIndex = 8;
            // 
            // add_itemDose_txtbx
            // 
            this.add_itemDose_txtbx.Location = new System.Drawing.Point(102, 95);
            this.add_itemDose_txtbx.Name = "add_itemDose_txtbx";
            this.add_itemDose_txtbx.Size = new System.Drawing.Size(100, 20);
            this.add_itemDose_txtbx.TabIndex = 7;
            // 
            // add_item_productMan_txtbx
            // 
            this.add_item_productMan_txtbx.Location = new System.Drawing.Point(102, 69);
            this.add_item_productMan_txtbx.Name = "add_item_productMan_txtbx";
            this.add_item_productMan_txtbx.Size = new System.Drawing.Size(100, 20);
            this.add_item_productMan_txtbx.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dosage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Manufacturer";
            // 
            // add_itemName_lbl
            // 
            this.add_itemName_lbl.AutoSize = true;
            this.add_itemName_lbl.Location = new System.Drawing.Point(21, 46);
            this.add_itemName_lbl.Name = "add_itemName_lbl";
            this.add_itemName_lbl.Size = new System.Drawing.Size(75, 13);
            this.add_itemName_lbl.TabIndex = 1;
            this.add_itemName_lbl.Text = "Product Name";
            // 
            // add_itemSubmit_btn
            // 
            this.add_itemSubmit_btn.Location = new System.Drawing.Point(127, 322);
            this.add_itemSubmit_btn.Name = "add_itemSubmit_btn";
            this.add_itemSubmit_btn.Size = new System.Drawing.Size(75, 23);
            this.add_itemSubmit_btn.TabIndex = 0;
            this.add_itemSubmit_btn.Text = "Add Item";
            this.add_itemSubmit_btn.UseVisualStyleBackColor = true;
            // 
            // add_customer_tab
            // 
            this.add_customer_tab.Controls.Add(this.add_customerAccount_btn);
            this.add_customer_tab.Controls.Add(this.add_state_txtbx);
            this.add_customer_tab.Controls.Add(this.add_zip_txtbx);
            this.add_customer_tab.Controls.Add(this.add_lname_txtbx);
            this.add_customer_tab.Controls.Add(this.add_bday_txtbx);
            this.add_customer_tab.Controls.Add(this.add_ssn_txtbx);
            this.add_customer_tab.Controls.Add(this.add_addr_txtbx);
            this.add_customer_tab.Controls.Add(this.add_city_txtbx);
            this.add_customer_tab.Controls.Add(this.add_fname_txtbx);
            this.add_customer_tab.Controls.Add(this.label8);
            this.add_customer_tab.Controls.Add(this.label7);
            this.add_customer_tab.Controls.Add(this.label6);
            this.add_customer_tab.Controls.Add(this.label5);
            this.add_customer_tab.Controls.Add(this.label4);
            this.add_customer_tab.Controls.Add(this.label3);
            this.add_customer_tab.Controls.Add(this.label2);
            this.add_customer_tab.Controls.Add(this.label1);
            this.add_customer_tab.Location = new System.Drawing.Point(4, 22);
            this.add_customer_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_customer_tab.Name = "add_customer_tab";
            this.add_customer_tab.Size = new System.Drawing.Size(315, 358);
            this.add_customer_tab.TabIndex = 3;
            this.add_customer_tab.Text = "Customer Account";
            this.add_customer_tab.UseVisualStyleBackColor = true;
            // 
            // add_customerAccount_btn
            // 
            this.add_customerAccount_btn.Location = new System.Drawing.Point(140, 260);
            this.add_customerAccount_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_customerAccount_btn.Name = "add_customerAccount_btn";
            this.add_customerAccount_btn.Size = new System.Drawing.Size(150, 35);
            this.add_customerAccount_btn.TabIndex = 9;
            this.add_customerAccount_btn.Text = "Submit";
            this.add_customerAccount_btn.UseVisualStyleBackColor = true;
            this.add_customerAccount_btn.Click += new System.EventHandler(this.add_customerAccount_btn_Click);
            // 
            // add_state_txtbx
            // 
            this.add_state_txtbx.Location = new System.Drawing.Point(142, 200);
            this.add_state_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_state_txtbx.Name = "add_state_txtbx";
            this.add_state_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_state_txtbx.TabIndex = 7;
            // 
            // add_zip_txtbx
            // 
            this.add_zip_txtbx.Location = new System.Drawing.Point(142, 230);
            this.add_zip_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_zip_txtbx.Name = "add_zip_txtbx";
            this.add_zip_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_zip_txtbx.TabIndex = 8;
            // 
            // add_lname_txtbx
            // 
            this.add_lname_txtbx.Location = new System.Drawing.Point(142, 50);
            this.add_lname_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_lname_txtbx.Name = "add_lname_txtbx";
            this.add_lname_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_lname_txtbx.TabIndex = 2;
            // 
            // add_bday_txtbx
            // 
            this.add_bday_txtbx.Location = new System.Drawing.Point(142, 80);
            this.add_bday_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_bday_txtbx.Name = "add_bday_txtbx";
            this.add_bday_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_bday_txtbx.TabIndex = 3;
            this.add_bday_txtbx.Text = "YYYY-MM-DD";
            // 
            // add_ssn_txtbx
            // 
            this.add_ssn_txtbx.Location = new System.Drawing.Point(142, 110);
            this.add_ssn_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_ssn_txtbx.Name = "add_ssn_txtbx";
            this.add_ssn_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_ssn_txtbx.TabIndex = 4;
            this.add_ssn_txtbx.Text = "XXXXXXXXX";
            // 
            // add_addr_txtbx
            // 
            this.add_addr_txtbx.Location = new System.Drawing.Point(142, 140);
            this.add_addr_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_addr_txtbx.Name = "add_addr_txtbx";
            this.add_addr_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_addr_txtbx.TabIndex = 5;
            // 
            // add_city_txtbx
            // 
            this.add_city_txtbx.Location = new System.Drawing.Point(142, 170);
            this.add_city_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_city_txtbx.Name = "add_city_txtbx";
            this.add_city_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_city_txtbx.TabIndex = 6;
            // 
            // add_fname_txtbx
            // 
            this.add_fname_txtbx.Location = new System.Drawing.Point(142, 20);
            this.add_fname_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_fname_txtbx.Name = "add_fname_txtbx";
            this.add_fname_txtbx.Size = new System.Drawing.Size(148, 20);
            this.add_fname_txtbx.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 233);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Street Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Social Security Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Birthdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // add_employee_tab
            // 
            this.add_employee_tab.Location = new System.Drawing.Point(4, 22);
            this.add_employee_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_employee_tab.Name = "add_employee_tab";
            this.add_employee_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_employee_tab.Size = new System.Drawing.Size(315, 358);
            this.add_employee_tab.TabIndex = 1;
            this.add_employee_tab.Text = "Employee";
            this.add_employee_tab.UseVisualStyleBackColor = true;
            // 
            // add_store_tab
            // 
            this.add_store_tab.Location = new System.Drawing.Point(4, 22);
            this.add_store_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_store_tab.Name = "add_store_tab";
            this.add_store_tab.Size = new System.Drawing.Size(315, 446);
            this.add_store_tab.TabIndex = 2;
            this.add_store_tab.Text = "Store";
            this.add_store_tab.UseVisualStyleBackColor = true;
            // 
            // add_batch_tab
            // 
            this.add_batch_tab.Location = new System.Drawing.Point(4, 22);
            this.add_batch_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_batch_tab.Name = "add_batch_tab";
            this.add_batch_tab.Size = new System.Drawing.Size(315, 358);
            this.add_batch_tab.TabIndex = 4;
            this.add_batch_tab.Text = "Batch Upload";
            this.add_batch_tab.UseVisualStyleBackColor = true;
            // 
            // add_itemDoseUnits_combo
            // 
            this.add_itemDoseUnits_combo.FormattingEnabled = true;
            this.add_itemDoseUnits_combo.Items.AddRange(new object[] {
            "mL",
            "L",
            "kL",
            "mg",
            "g",
            "Kg"});
            this.add_itemDoseUnits_combo.Location = new System.Drawing.Point(208, 94);
            this.add_itemDoseUnits_combo.Name = "add_itemDoseUnits_combo";
            this.add_itemDoseUnits_combo.Size = new System.Drawing.Size(50, 21);
            this.add_itemDoseUnits_combo.TabIndex = 12;
            // 
            // add_item_productID_txtbx
            // 
            this.add_item_productID_txtbx.Location = new System.Drawing.Point(102, 17);
            this.add_item_productID_txtbx.Name = "add_item_productID_txtbx";
            this.add_item_productID_txtbx.Size = new System.Drawing.Size(100, 20);
            this.add_item_productID_txtbx.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Product ID";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 384);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddForm";
            this.Text = "Add";
            this.tabControl1.ResumeLayout(false);
            this.add_item_tab.ResumeLayout(false);
            this.add_item_tab.PerformLayout();
            this.add_customer_tab.ResumeLayout(false);
            this.add_customer_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage add_item_tab;
        private System.Windows.Forms.TabPage add_employee_tab;
        private System.Windows.Forms.TabPage add_store_tab;
        private System.Windows.Forms.TabPage add_customer_tab;
        private System.Windows.Forms.TabPage add_batch_tab;
        private System.Windows.Forms.Button add_customerAccount_btn;
        private System.Windows.Forms.TextBox add_state_txtbx;
        private System.Windows.Forms.TextBox add_zip_txtbx;
        private System.Windows.Forms.TextBox add_lname_txtbx;
        private System.Windows.Forms.TextBox add_bday_txtbx;
        private System.Windows.Forms.TextBox add_ssn_txtbx;
        private System.Windows.Forms.TextBox add_addr_txtbx;
        private System.Windows.Forms.TextBox add_city_txtbx;
        private System.Windows.Forms.TextBox add_fname_txtbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label add_itemName_lbl;
        private System.Windows.Forms.Button add_itemSubmit_btn;
        private System.Windows.Forms.ComboBox add_itemQtyUnits_combo;
        private System.Windows.Forms.TextBox add_itemDesc_txtbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox add_itemQty_txtbx;
        private System.Windows.Forms.TextBox add_itemDose_txtbx;
        private System.Windows.Forms.TextBox add_item_productMan_txtbx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox add_item_productID_txtbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox add_itemDoseUnits_combo;
    }
}