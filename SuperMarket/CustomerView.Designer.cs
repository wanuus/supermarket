namespace SuperMarket
{
    partial class CustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.Button_ADD = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.table_product = new System.Windows.Forms.DataGridView();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.table_order = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.table_all = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.Button_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Button_search = new Guna.UI2.WinForms.Guna2Button();
            this.label_search = new System.Windows.Forms.Label();
            this.TextBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Customer = new System.Windows.Forms.Label();
            this.TextBox_Customer = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_all)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(499, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 36);
            this.label8.TabIndex = 53;
            this.label8.Text = "Order Now";
            // 
            // Button_ADD
            // 
            this.Button_ADD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_ADD.BorderRadius = 15;
            this.Button_ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_ADD.FillColor = System.Drawing.Color.Azure;
            this.Button_ADD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ADD.ForeColor = System.Drawing.Color.CadetBlue;
            this.Button_ADD.Location = new System.Drawing.Point(919, 270);
            this.Button_ADD.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(99, 38);
            this.Button_ADD.TabIndex = 50;
            this.Button_ADD.Text = "ADD";
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(867, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 31);
            this.label7.TabIndex = 49;
            this.label7.Text = "Product Info:";
            // 
            // TextBox_Quantity
            // 
            this.TextBox_Quantity.BorderRadius = 10;
            this.TextBox_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Quantity.DefaultText = "";
            this.TextBox_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Quantity.Location = new System.Drawing.Point(939, 225);
            this.TextBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Quantity.Name = "TextBox_Quantity";
            this.TextBox_Quantity.PasswordChar = '\0';
            this.TextBox_Quantity.PlaceholderText = "";
            this.TextBox_Quantity.SelectedText = "";
            this.TextBox_Quantity.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Quantity.TabIndex = 45;
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.BorderRadius = 10;
            this.TextBox_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Price.DefaultText = "";
            this.TextBox_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Price.Location = new System.Drawing.Point(939, 183);
            this.TextBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.PasswordChar = '\0';
            this.TextBox_Price.PlaceholderText = "";
            this.TextBox_Price.ReadOnly = true;
            this.TextBox_Price.SelectedText = "";
            this.TextBox_Price.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Price.TabIndex = 44;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BorderRadius = 10;
            this.TextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Name.DefaultText = "";
            this.TextBox_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.Location = new System.Drawing.Point(939, 140);
            this.TextBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.ReadOnly = true;
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Name.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(818, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(818, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(818, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Price";
            // 
            // table_product
            // 
            this.table_product.BackgroundColor = System.Drawing.Color.Azure;
            this.table_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_product.Location = new System.Drawing.Point(55, 117);
            this.table_product.Margin = new System.Windows.Forms.Padding(4);
            this.table_product.Name = "table_product";
            this.table_product.RowHeadersWidth = 51;
            this.table_product.Size = new System.Drawing.Size(723, 204);
            this.table_product.TabIndex = 33;
            this.table_product.Click += new System.EventHandler(this.table_products_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Azure;
            this.label_exit.Location = new System.Drawing.Point(1139, -6);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(40, 50);
            this.label_exit.TabIndex = 32;
            this.label_exit.Text = "x";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Azure;
            this.label_date.Location = new System.Drawing.Point(49, 84);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(69, 29);
            this.label_date.TabIndex = 54;
            this.label_date.Text = "Date:";
            // 
            // table_order
            // 
            this.table_order.BackgroundColor = System.Drawing.Color.Azure;
            this.table_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.ProdName,
            this.Price,
            this.Quantity,
            this.Total_price});
            this.table_order.Location = new System.Drawing.Point(231, 362);
            this.table_order.Margin = new System.Windows.Forms.Padding(4);
            this.table_order.Name = "table_order";
            this.table_order.RowHeadersWidth = 51;
            this.table_order.Size = new System.Drawing.Size(339, 204);
            this.table_order.TabIndex = 55;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProdID";
            this.ProdID.MinimumWidth = 6;
            this.ProdID.Name = "ProdID";
            this.ProdID.Width = 125;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total_price
            // 
            this.Total_price.HeaderText = "Total_price";
            this.Total_price.MinimumWidth = 6;
            this.Total_price.Name = "Total_price";
            this.Total_price.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(48, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 56;
            this.label3.Text = "Your order:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(607, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 58;
            this.label4.Text = "All orders:";
            // 
            // table_all
            // 
            this.table_all.BackgroundColor = System.Drawing.Color.Azure;
            this.table_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_all.Location = new System.Drawing.Point(789, 362);
            this.table_all.Margin = new System.Windows.Forms.Padding(4);
            this.table_all.Name = "table_all";
            this.table_all.RowHeadersWidth = 51;
            this.table_all.Size = new System.Drawing.Size(339, 204);
            this.table_all.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(49, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.Azure;
            this.label_total.Location = new System.Drawing.Point(50, 445);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(48, 25);
            this.label_total.TabIndex = 60;
            this.label_total.Text = "egp";
            // 
            // Button_confirm
            // 
            this.Button_confirm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_confirm.BorderRadius = 15;
            this.Button_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_confirm.FillColor = System.Drawing.Color.Azure;
            this.Button_confirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_confirm.ForeColor = System.Drawing.Color.CadetBlue;
            this.Button_confirm.Location = new System.Drawing.Point(54, 528);
            this.Button_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.Button_confirm.Name = "Button_confirm";
            this.Button_confirm.Size = new System.Drawing.Size(99, 38);
            this.Button_confirm.TabIndex = 61;
            this.Button_confirm.Text = "Confirm";
            this.Button_confirm.Click += new System.EventHandler(this.Button_confirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(50, 499);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 62;
            this.label10.Text = "Confirm order:";
            // 
            // Button_search
            // 
            this.Button_search.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_search.BorderRadius = 10;
            this.Button_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_search.FillColor = System.Drawing.Color.Azure;
            this.Button_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_search.ForeColor = System.Drawing.Color.CadetBlue;
            this.Button_search.Location = new System.Drawing.Point(722, 84);
            this.Button_search.Margin = new System.Windows.Forms.Padding(4);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(56, 25);
            this.Button_search.TabIndex = 65;
            this.Button_search.Text = "🔍";
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.Azure;
            this.label_search.Location = new System.Drawing.Point(474, 82);
            this.label_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(88, 25);
            this.label_search.TabIndex = 64;
            this.label_search.Text = "Search:";
            // 
            // TextBox_search
            // 
            this.TextBox_search.BorderRadius = 10;
            this.TextBox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_search.DefaultText = "";
            this.TextBox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search.Location = new System.Drawing.Point(570, 84);
            this.TextBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_search.Name = "TextBox_search";
            this.TextBox_search.PasswordChar = '\0';
            this.TextBox_search.PlaceholderText = "";
            this.TextBox_search.SelectedText = "";
            this.TextBox_search.Size = new System.Drawing.Size(144, 25);
            this.TextBox_search.TabIndex = 63;
            // 
            // label_Customer
            // 
            this.label_Customer.AutoSize = true;
            this.label_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customer.ForeColor = System.Drawing.Color.Azure;
            this.label_Customer.Location = new System.Drawing.Point(48, 55);
            this.label_Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Customer.Name = "label_Customer";
            this.label_Customer.Size = new System.Drawing.Size(123, 29);
            this.label_Customer.TabIndex = 66;
            this.label_Customer.Text = "Customer:";
            // 
            // TextBox_Customer
            // 
            this.TextBox_Customer.BorderRadius = 10;
            this.TextBox_Customer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Customer.DefaultText = "";
            this.TextBox_Customer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Customer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Customer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Customer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Customer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Customer.Location = new System.Drawing.Point(179, 59);
            this.TextBox_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Customer.Name = "TextBox_Customer";
            this.TextBox_Customer.PasswordChar = '\0';
            this.TextBox_Customer.PlaceholderText = "";
            this.TextBox_Customer.SelectedText = "";
            this.TextBox_Customer.Size = new System.Drawing.Size(144, 25);
            this.TextBox_Customer.TabIndex = 67;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 615);
            this.Controls.Add(this.TextBox_Customer);
            this.Controls.Add(this.label_Customer);
            this.Controls.Add(this.Button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.TextBox_search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Button_confirm);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.table_all);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.table_order);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button_ADD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBox_Quantity);
            this.Controls.Add(this.TextBox_Price);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_product);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button Button_ADD;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Quantity;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table_product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DataGridView table_order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView table_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_total;
        private Guna.UI2.WinForms.Guna2Button Button_confirm;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button Button_search;
        private System.Windows.Forms.Label label_search;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_search;
        private System.Windows.Forms.Label label_Customer;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Customer;
    }
}