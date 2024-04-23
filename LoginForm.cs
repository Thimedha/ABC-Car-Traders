using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {  //==== Close button code===//
           Application.Exit();  
        }
        //========Login form password show code ======//////////////////////////////////////
    
        /// ========   Start  ===============///
        private void chbPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPasswordShow.Checked==true ) 
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        ///=========  END ====================///
        private void lilblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Customer_Register obj = new Customer_Register();
            obj.ShowDialog();
        }

      
    }
}
