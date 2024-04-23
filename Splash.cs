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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        // === Progress Splash loder code =======//
        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        int strartPoint = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            strartPoint += 2;
            myprogressBar.Value = strartPoint;  
            if (myprogressBar.Value == 100) 
            {
                timer.Stop();
                myprogressBar.Value = 0;
                LoginForm login =new LoginForm(); // link to form connecteion //
                this.Hide();    
                login.Show();   
            }
        }
    }
}
