﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders_New
{
    public partial class Customer_Register : Form
    {
        public Customer_Register()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.ShowDialog();   
        }

        private void chbPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPasswordShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtCPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtCPassword.UseSystemPasswordChar = false;
            }
        }

        
    }
}
