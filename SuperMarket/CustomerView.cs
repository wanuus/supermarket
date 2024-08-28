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
    public partial class CustomerView : Form
    {
        public CustomerView()
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

        private void clear_data()
        {
            TextBox_Name.Clear();
            TextBox_Price.Clear();
            TextBox_Quantity.Clear();
        }


        private void GetTable()
        {
            string selectQuerry = "SELECT PRONAME, PRICE FROM PRODUCT";
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_product.DataSource = table;
        }

        private void GetOrderTable()
        {
            string selectQuerry = "SELECT * FROM ORDER";
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table_all.DataSource = table;
        }

        int total = 0, i = 0, qty = 0;
        private void Button_ADD_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "" || TextBox_Price.Text == "" || TextBox_Quantity.Text == "")
            {
                MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int totl = Convert.ToInt32(TextBox_Price.Text) * Convert.ToInt32(TextBox_Quantity.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(table_order);
                addRow.Cells[0].Value = ++i;
                addRow.Cells[1].Value = TextBox_Name.Text;
                addRow.Cells[2].Value = TextBox_Price.Text;
                addRow.Cells[3].Value = TextBox_Quantity.Text;
                addRow.Cells[4].Value = totl;
                table_order.Rows.Add(addRow);
                total += totl;
                label_total.Text = total + "egp";
                qty += Convert.ToInt32(TextBox_Quantity.Text);
            }
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            string selectQuerry;
            if (TextBox_search.Text != "")
            {
                selectQuerry = "SELECT PRONAME, PRICE FROM PRODUCT WHERE PRONAME = '" + TextBox_search.Text + "'";
            }
            else
            {
                selectQuerry = "SELECT PRONAME, PRICE FROM PRODUCT";
            }
            SqlCommand command = new SqlCommand(selectQuerry, class1.GetConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            table_product.DataSource = table;
        }


        private void Button_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO ORDER (CUSID, ORDERQUANTITY, ORDERITEM, TOTALCOST,DATE) SELECT ID ,'" + TextBox_Quantity.Text + "','" + TextBox_Name.Text + "','" + total.ToString() + "','" + label_date.Text + "' FROM CUSTOMER WHERE FIRSTNAME = '" + TextBox_Customer.Text + "'"; 
                SqlCommand command = new SqlCommand(insertQuery, class1.GetConnection());
                class1.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Order added successfully", "Add information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class1.CloseConnection();
                GetOrderTable();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            GetTable();
        }

        private void table_products_Click(object sender, EventArgs e)
        {
            TextBox_Name.Text = table_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Price.Text = table_product.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
