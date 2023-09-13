﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.WinForm
{
    using Login.Core;

    public partial class Form1 : Form
    {
        private LoginService loginService = new LoginService(new Database());
        public Form1()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string pass = txtPass.Text;
            try
            {
                if (loginService.CheckUser(userName, pass))
                {
                    MessageBox.Show("Login successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login fail with reason: " + ex.Message);
            }   
            
        }
    }
}
