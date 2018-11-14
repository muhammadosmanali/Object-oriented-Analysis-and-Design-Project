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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hideallpanel()
        {
            panelEnableButton.Hide();
            panelForgotPassword.Hide();
            panelnewSignIn.Hide();
            panelNewResetPassword.Hide();
            panelsignin.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            innovator_reset inr = new innovator_reset();
            this.Controls.Add(inr);
            inr.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideallpanel();
        }

        private void btnInvester_Click(object sender, EventArgs e)
        {
            hideallpanel();
            invester_register invreg = new invester_register();
            this.Controls.Add(invreg);
            panelsignin.Show();
            invreg.BringToFront();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            InvesterSignIn n = new InvesterSignIn();
            panelEnableButton.Hide();
            panelNewResetPassword.Hide();
            panelnewSignIn.Hide();
            panelsignin.Hide();
            
            panelForgotPassword.Show();
            this.Controls.Add(n);
            n.BringToFront();
        }

        private void btnForgorPassword_Click(object sender, EventArgs e)
        {
            invester_reset m = new invester_reset();
            this.Controls.Add(m);
            panelForgotPassword.Hide();
            panelsignin.Show();
            m.BringToFront();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInnovator_Click(object sender, EventArgs e)
        {
            hideallpanel();
            Innovator_register inr = new Innovator_register();
            this.Controls.Add(inr);
            inr.BringToFront();
            panelnewSignIn.Show();
        }

        private void btnnewSignIn_Click(object sender, EventArgs e)
        {
            hideallpanel();
            InnovatorSignIn ins = new InnovatorSignIn();
            this.Controls.Add(ins);
            ins.BringToFront();
            panelnewSignIn.Show();
            panelNewResetPassword.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            hideallpanel();
            Admin ad = new Admin();
            this.Controls.Add(ad);
            ad.BringToFront();
        }
    }
}
