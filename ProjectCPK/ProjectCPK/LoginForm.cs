﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void login_submit_btn_Click(object sender, EventArgs e)
        {
            //send login information to DB
            //if connection successful and user account and password match
            //enable functionality of application
            //close this form
            
            this.Close();
            //otherwise prompt user that information is incorrect and allow to retry
            
        }

        private void login_test_btn_Click(object sender, EventArgs e)
        {
            //disable window
            this.Enabled = false;
            //test connection
            this.Enabled = true;
        }
        
    }
}