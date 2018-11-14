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
    public partial class InnovatorSignIn : UserControl
    {
        public InnovatorSignIn()
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

                    lblMessage.Text = "Sign in Succesfully";
                    this.Dock = DockStyle.Fill;
                    panel1.Show();
                    txtPassword.Text = "";
                    lblMessage.Text = "";

                }
                else
                {
                    lblMessage.Text = "Invalid Email or Password";
                }
            }
        }

        private void btnLoadInfo_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.connectionstring))
            {
                con.Open();
                SqlDataAdapter ss = new SqlDataAdapter("Select * from Innovator where Email = '" + txtEmail.Text + "'", con);
                DataTable tbl = new DataTable();
                ss.Fill(tbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.SkyBlue;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
                dataGridView1.DataSource = tbl;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlc = new SqlConnection(StringConnection.connectionstring))
            {
                sqlc.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Update innovator set Idea = '" + rtxtIdea.Text + "' where Email = '" + txtEmail.Text + "'", sqlc);
                DataSet set = new DataSet();
                sqlda.Fill(set);
                MessageBox.Show("Idea Updated and press Load button to see your updated idea");
                rtxtIdea.Text = "";
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            this.Dock = DockStyle.Top;
        }

        private void InnovatorSignIn_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
