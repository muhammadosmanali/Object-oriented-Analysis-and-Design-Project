using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investandbusinessplace
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                panelAdmin.Show();
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("INVALID INFO");
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            panelAdmin.Hide();
        }

        private void btnInnovatorApproval_Click(object sender, EventArgs e)
        {
            Innovator_register inr = new Innovator_register();
            inr.ApproveData(Innovator_register.person, Innovator_register.Email, Innovator_register.Contact, Innovator_register.Idea, Innovator_register.Password, Innovator_register.Question, Innovator_register.Answer);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            panelAdmin.Hide();
        }

        private void btnInvesterapproval_Click(object sender, EventArgs e)
        {
            invester_register n = new invester_register();
            n.ApproveData(invester_register.person, invester_register.Email, invester_register.Contact, invester_register.Category, invester_register.Password, invester_register.Question, invester_register.Answer);
        }
    }
}
