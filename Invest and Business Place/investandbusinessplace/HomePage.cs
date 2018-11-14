using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investandbusinessplace
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            HomePage n = new HomePage();
            this.Controls.Add(n);
            n.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInvester_Click(object sender, EventArgs e)
        {
            invester_register invreg = new invester_register();
            this.Controls.Add(invreg);
            invreg.BringToFront();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnHome.Enabled = false;
            btnInnovator.Enabled = false;
            btnInvester.Enabled = false;
            btnAboutUs.Enabled = false;
            //InvesterSignIn s = new InvesterSignIn();
            //this.Controls.Add(s);
            panelsignin.Hide();
            //s.BringToFront();
            panelEnableButton.Show();
            panelForgotPassword.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelsignin.Hide();
            panelForgotPassword.Hide();
            panelnewSignIn.Hide();
            panelNewResetPassword.Hide();
            panelEnableButton.Hide();
            HomePage a = new HomePage();
            this.Controls.Add(a);
            a.BringToFront();
        }

        private void btnForgorPassword_Click(object sender, EventArgs e)
        {
            invester_reset m = new invester_reset();
            this.Controls.Add(m);
            panelForgotPassword.Hide();
            panelsignin.Show();
            m.BringToFront();
        }

        private void btnnewSignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
