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
    public partial class invester_register : UserControl
    {
        string query;
        public invester_register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtContact.Text != "" && cmbCategory.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "" && cmbSelectQuestion.Text != "" && txtAnswer.Text != "")
            {
                System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (expr.IsMatch(txtEmail.Text))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        using (SqlConnection connection = new SqlConnection(StringConnection.connectionstring))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand("Select count(*) from Invester where Email = '" + txtEmail.Text + "'", connection);
                            int result = Convert.ToInt32(cmd.ExecuteScalar());
                            if (result > 0)
                            {
                                lblmessages.Text = txtEmail.Text + " Already Exist";
                                txtEmail.Text = "";
                            }
                            else
                            {
                                query = "Insert Into Invester(Name, Email, Contact, Category, Password, Question, Answer) VALUES ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtContact.Text + "', '" + cmbCategory.Text + "', '" + txtPassword.Text + "', '" + cmbSelectQuestion.Text + "' , '" + txtAnswer.Text + "')";
                                SqlCommand sqlcmd = new SqlCommand(query, connection);
                                sqlcmd.ExecuteNonQuery();
                                MessageBox.Show("Registeration Successful");

                            }
                            clear();
                        }
                    }
                    else
                    {
                        lblmessages.Text = "Passwords are not matches.";
                        txtPassword.Text = txtConfirmPassword.Text = "";
                    }
                }
                else
                {
                    lblmessages.Text = "Invalid Email";
                    txtEmail.Text = "";
                }
            }
            else
            {
                lblmessages.Text = "You missing important fields.";
            }
        }

        private void clear()
        {
            txtName.Text = txtEmail.Text = txtContact.Text = txtPassword.Text = txtConfirmPassword.Text = txtAnswer.Text = cmbCategory.Text = cmbSelectQuestion.Text = "";
        }
    }

}
