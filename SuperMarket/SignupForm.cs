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
    public partial class SignupForm : Form
    {
        public SignupForm()
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

        Class1 class1 = new Class1();
       

        private void button_login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        int intg = 2, ssn = 1;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                intg++;
                string strg = intg.ToString();
                string ssns = ssn.ToString();
                if (TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_City.Text == "" || TextBox_Street.Text == "" || TextBox_Building.Text == "" || TextBox_UserName.Text == "" || TextBox_Email.Text == "" || TextBox_Password.Text == "")
                {
                    MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO CUSTOMER (FIRSTNAME, LASTNAME, CITY, STREETNO, BUILDINGNO_) VALUES('" + TextBox_FirstName.Text + "','" + TextBox_LastName.Text + "','" + TextBox_City.Text + "','" + TextBox_Street.Text + "','" + TextBox_Building.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, class1.GetConnection());
                    class1.OpenConnection();
                    command.ExecuteNonQuery();
                    class1.CloseConnection();

                    string insertQuery3 = "INSERT INTO ACCOUNT (ID,ACCUSERNAME, ACCPASSWORD, ACCEMAIL) SELECT ID ,'" + TextBox_UserName.Text + "','" + TextBox_Password.Text + "','" + TextBox_Email.Text + "' FROM CUSTOMER WHERE FIRSTNAME = '" + TextBox_FirstName.Text + "'";
                    SqlCommand cmmd = new SqlCommand(insertQuery3, class1.GetConnection());
                    class1.OpenConnection();
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Signed up successfully", "Sign up information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    class1.CloseConnection();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
