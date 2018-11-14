using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace investandbusinessplace
{
    public partial class InvesterSignIn : UserControl
    {
        public InvesterSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection.connectionstring))
            {
                connection.Open();
                string newconnection = "Select * from Innovator where Email = '" + txtEmail.Text + "' and Password = '" + txtPassword.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(newconnection, connection);
                DataSet s = new DataSet();
                adp.Fill(s);
                DataTable dt = s.Tables[0];
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Sign In Successfully");
                    this.Dock = DockStyle.Fill;
                    panelInvester.Show();
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    lblMessage.Text = "";

                }
                else
                {
                    lblMessage.Text = "Invalid Email or Password";
                }
            }
        }

        private void BtnloadData_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.connectionstring))
            {
                con.Open();
                SqlDataAdapter s = new SqlDataAdapter("Select * from Innovator", con);
                DataTable dt = new DataTable();
                s.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.Yellow;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
                dataGridView1.DataSource = dt;

            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            panelInvester.Hide();
            
            this.Dock = DockStyle.Top;
        }

        private void InvesterSignIn_Load(object sender, EventArgs e)
        {
            panelInvester.Hide();
        }
    }
}
