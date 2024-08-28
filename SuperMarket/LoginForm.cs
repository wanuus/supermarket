using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SuperMarket
{
    public partial class LoginForm : Form
    {
        Class1 class1 = new Class1();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkCyan;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text == "" || textbox_password.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex >= 0)
                {
                    if (comboBox_role.SelectedItem.ToString() == "Admin")
                    {
                        string selectQuery = "SELECT * FROM ADMIN WHERE ADMINNAME = '" + textbox_username.Text + "' AND ADMINPASSWORD = '" + textbox_password.Text + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, class1.GetConnection());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            AdminProduct loginad = new AdminProduct();
                            loginad.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM ACCOUNT WHERE ACCUSERNAME = '" + textbox_username.Text + "' AND ACCPASSWORD = '" + textbox_password.Text + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, class1.GetConnection());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            CustomerView cusview = new CustomerView();
                            cusview.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Please select a role first", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
