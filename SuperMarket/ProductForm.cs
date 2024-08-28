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
    public partial class AdminProduct : Form
    {
        public AdminProduct()
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

        private void GetCateg()
        {
            string selectQuerry = "SELECT * FROM CATEGORY";
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CATEGORYNAME";
        }

        private void GetTable()
        {
            string selectQuerry = "SELECT PROID, SSN, PRONAME, TYPE, PRICE, QUANTITY, CATEGORYNAME FROM PRODUCT";
           
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_product.DataSource = table;

        }

        private void clear_data()
        {
            TextBox_ID.Clear();
            TextBox_SSN.Clear();
            TextBox_Name.Clear();
            TextBox_Type.Clear();
            TextBox_Price.Clear();
            TextBox_Quantity.Clear();
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_SSN.Text == "" || TextBox_Name.Text == "" || TextBox_Type.Text == "" || TextBox_Price.Text == "" || TextBox_Quantity.Text == "")
                {
                    MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO PRODUCT VALUES(" + TextBox_ID.Text + ",'" + TextBox_SSN.Text + "','" + TextBox_Name.Text + "','" + TextBox_Type.Text + "','" + TextBox_Price.Text + "','" + TextBox_Quantity.Text + "','" + comboBox_category.Text + "','" + null + "')";
                    SqlCommand command = new SqlCommand(insertQuery, class1.GetConnection());
                    class1.OpenConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully", "Add information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    class1.CloseConnection();
                    GetTable();
                    clear_data();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            GetTable();
            GetCateg();
        }

        private void Button_UPDATE_Click(object sender, EventArgs e)
        {
            try 
            {
                string updateQuery = "UPDATE PRODUCT SET SSN = '" + TextBox_SSN.Text + "', PRONAME = '" + TextBox_Name.Text + "', TYPE = '" + TextBox_Type.Text + "', PRICE = '" + TextBox_Price.Text + "' , QUANTITY = '" + TextBox_Quantity.Text + "' , CATEGORYNAME = '" + comboBox_category.Text + "' WHERE PROID = '" + TextBox_ID.Text + "'";
                SqlCommand command = new SqlCommand(updateQuery, class1.GetConnection());
                class1.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully","Update information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                class1.CloseConnection();
                GetTable();
                clear_data();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void table_product_Click(object sender, EventArgs e)
        {
            TextBox_ID.Text = table_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_SSN.Text = table_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Name.Text = table_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Type.Text = table_product.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_Price.Text = table_product.SelectedRows[0].Cells[4].Value.ToString();
            TextBox_Quantity.Text = table_product.SelectedRows[0].Cells[5].Value.ToString();
            comboBox_category.Text = table_product.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuerry = "DELETE FROM PRODUCT WHERE PROID = "+TextBox_ID.Text+"";
                SqlCommand command = new SqlCommand(deleteQuerry, class1.GetConnection());
                class1.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully", "delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class1.CloseConnection();
                GetTable();
                clear_data();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_customers_Click(object sender, EventArgs e)
        {
            CustomersForm cusForm = new CustomersForm();
            cusForm.Show();
            this.Hide();
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            string selectQuerry;
            if (TextBox_search.Text != "")
            {
                selectQuerry = "SELECT PROID, SSN, PRONAME, TYPE, PRICE, QUANTITY, CATEGORYNAME FROM PRODUCT WHERE PRONAME = '" + TextBox_search.Text + "'";
            }
            else
            {
                selectQuerry = "SELECT PROID, SSN, PRONAME, TYPE, PRICE, QUANTITY, CATEGORYNAME FROM PRODUCT";
            }
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_product.DataSource = table;
        }

        private void comboBox_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuerry;
            if (comboBox_view.SelectedItem.ToString() == "All available products")
            {
                selectQuerry = "SELECT PROID, SSN, PRONAME, TYPE, PRICE, QUANTITY, CATEGORYNAME FROM PRODUCT";
            }
            else
            {
                selectQuerry = "SELECT PROID, SSN, PRONAME, TYPE, PRICE, QUANTITY, CATEGORYNAME FROM PRODUCT WHERE QUANTITY <= 10";
            }
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_product.DataSource = table;
        }
    }
}

