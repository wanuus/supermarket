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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
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

        private void GetTable()
        {
            string selectQuerry = "SELECT * FROM CUSTOMER";
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_customers.DataSource = table;
        }

        private void clear_data()
        {
            TextBox_FirstName.Clear();
            TextBox_LastName.Clear();
            TextBox_City.Clear();
            TextBox_Street.Clear();
            TextBox_Building.Clear();
            TextBox_ID.Clear();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void Button_UPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE CUSTOMER SET FIRSTNAME = '" + TextBox_FirstName.Text + "' , LASTNAME = '" + TextBox_LastName.Text + "', CITY = '" + TextBox_City.Text + "', STREETNO = '" + TextBox_Street.Text + "' , BUILDINGNO_ = '" + TextBox_Building.Text + "'  WHERE  ID = '" + TextBox_ID.Text + "'";
                SqlCommand command = new SqlCommand(updateQuery, class1.GetConnection());
                class1.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully", "Customer information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class1.CloseConnection();
                GetTable();
                clear_data();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void table_customers_Click(object sender, EventArgs e)
        {
            TextBox_FirstName.Text = table_customers.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_LastName.Text = table_customers.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_City.Text = table_customers.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Street.Text = table_customers.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_Building.Text = table_customers.SelectedRows[0].Cells[4].Value.ToString();
            TextBox_ID.Text = table_customers.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuerry = "DELETE FROM CUSTOMER WHERE ID = '" + TextBox_ID.Text + "'";
                SqlCommand command = new SqlCommand(deleteQuerry, class1.GetConnection());
                string deleteQuerry2 = "DELETE FROM ACCOUNT WHERE ID = '" + TextBox_ID.Text + "'";
                SqlCommand command2 = new SqlCommand(deleteQuerry2, class1.GetConnection());
                class1.OpenConnection();
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                MessageBox.Show("Customer deleted successfully", "delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class1.CloseConnection();
                GetTable();
                clear_data();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_products_Click(object sender, EventArgs e)
        {
            AdminProduct prodForm = new AdminProduct();
            prodForm.Show();
            this.Hide();
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuerry;
            if (comboBox_view.SelectedItem.ToString() == "All customers")
            {
                selectQuerry = "SELECT * FROM CUSTOMER";
            }
            else
            {
                selectQuerry = "SELECT * FROM CUSTOMER WHERE ORDERS > 10";
            }
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_customers.DataSource = table;
        }
    }
}

