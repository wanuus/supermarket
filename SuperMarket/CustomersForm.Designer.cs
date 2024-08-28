namespace SuperMarket
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.Button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_UPDATE = new Guna.UI2.WinForms.Guna2Button();
            this.Button_ADD = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Street = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_City = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_LastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.comboBox_view = new System.Windows.Forms.ComboBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.TextBox_Building = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_products = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.table_customers = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(436, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 36);
            this.label8.TabIndex = 53;
            this.label8.Text = "Manage Customers:";
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_Delete.BorderRadius = 15;
            this.Button_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Delete.FillColor = System.Drawing.Color.Azure;
            this.Button_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.Color.CadetBlue;
            this.Button_Delete.Location = new System.Drawing.Point(1043, 454);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(99, 38);
            this.Button_Delete.TabIndex = 52;
            this.Button_Delete.Text = "DELETE";
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_UPDATE
            // 
            this.Button_UPDATE.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_UPDATE.BorderRadius = 15;
            this.Button_UPDATE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_UPDATE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_UPDATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_UPDATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_UPDATE.FillColor = System.Drawing.Color.Azure;
            this.Button_UPDATE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UPDATE.ForeColor = System.Drawing.Color.CadetBlue;
            this.Button_UPDATE.Location = new System.Drawing.Point(936, 454);
            this.Button_UPDATE.Margin = new System.Windows.Forms.Padding(4);
            this.Button_UPDATE.Name = "Button_UPDATE";
            this.Button_UPDATE.Size = new System.Drawing.Size(99, 38);
            this.Button_UPDATE.TabIndex = 51;
            this.Button_UPDATE.Text = "UPDATE";
            this.Button_UPDATE.Click += new System.EventHandler(this.Button_UPDATE_Click);
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
            this.Button_ADD.Location = new System.Drawing.Point(829, 454);
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
            this.label7.Location = new System.Drawing.Point(883, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 31);
            this.label7.TabIndex = 49;
            this.label7.Text = "Customer info:";
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BorderRadius = 10;
            this.TextBox_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ID.DefaultText = "";
            this.TextBox_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_ID.Location = new System.Drawing.Point(956, 399);
            this.TextBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.Size = new System.Drawing.Size(176, 28);
            this.TextBox_ID.TabIndex = 46;
            // 
            // TextBox_Street
            // 
            this.TextBox_Street.BorderRadius = 10;
            this.TextBox_Street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Street.DefaultText = "";
            this.TextBox_Street.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Street.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Street.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Street.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Street.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Street.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Street.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Street.Location = new System.Drawing.Point(956, 307);
            this.TextBox_Street.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Street.Name = "TextBox_Street";
            this.TextBox_Street.PasswordChar = '\0';
            this.TextBox_Street.PlaceholderText = "";
            this.TextBox_Street.SelectedText = "";
            this.TextBox_Street.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Street.TabIndex = 45;
            // 
            // TextBox_City
            // 
            this.TextBox_City.BorderRadius = 10;
            this.TextBox_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_City.DefaultText = "";
            this.TextBox_City.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_City.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_City.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_City.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_City.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_City.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_City.Location = new System.Drawing.Point(956, 265);
            this.TextBox_City.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_City.Name = "TextBox_City";
            this.TextBox_City.PasswordChar = '\0';
            this.TextBox_City.PlaceholderText = "";
            this.TextBox_City.SelectedText = "";
            this.TextBox_City.Size = new System.Drawing.Size(176, 28);
            this.TextBox_City.TabIndex = 44;
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.BorderRadius = 10;
            this.TextBox_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_LastName.DefaultText = "";
            this.TextBox_LastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_LastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_LastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_LastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_LastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_LastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_LastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_LastName.Location = new System.Drawing.Point(956, 222);
            this.TextBox_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.PasswordChar = '\0';
            this.TextBox_LastName.PlaceholderText = "";
            this.TextBox_LastName.SelectedText = "";
            this.TextBox_LastName.Size = new System.Drawing.Size(176, 28);
            this.TextBox_LastName.TabIndex = 43;
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.BorderRadius = 10;
            this.TextBox_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FirstName.DefaultText = "";
            this.TextBox_FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_FirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_FirstName.Location = new System.Drawing.Point(956, 182);
            this.TextBox_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.PasswordChar = '\0';
            this.TextBox_FirstName.PlaceholderText = "";
            this.TextBox_FirstName.SelectedText = "";
            this.TextBox_FirstName.Size = new System.Drawing.Size(176, 28);
            this.TextBox_FirstName.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(835, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Street No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(835, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(835, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(835, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "City";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Azure;
            this.ID.Location = new System.Drawing.Point(835, 182);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(106, 25);
            this.ID.TabIndex = 35;
            this.ID.Text = "First Name";
            // 
            // comboBox_view
            // 
            this.comboBox_view.ForeColor = System.Drawing.Color.Teal;
            this.comboBox_view.FormattingEnabled = true;
            this.comboBox_view.Items.AddRange(new object[] {
            "All customers",
            "Frequent customers"});
            this.comboBox_view.Location = new System.Drawing.Point(31, 81);
            this.comboBox_view.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_view.Name = "comboBox_view";
            this.comboBox_view.Size = new System.Drawing.Size(224, 24);
            this.comboBox_view.TabIndex = 34;
            this.comboBox_view.Text = "View";
            this.comboBox_view.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Azure;
            this.label_exit.Location = new System.Drawing.Point(1137, -10);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(40, 50);
            this.label_exit.TabIndex = 32;
            this.label_exit.Text = "x";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // TextBox_Building
            // 
            this.TextBox_Building.BorderRadius = 10;
            this.TextBox_Building.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Building.DefaultText = "";
            this.TextBox_Building.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Building.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Building.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Building.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Building.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Building.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Building.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Building.Location = new System.Drawing.Point(956, 352);
            this.TextBox_Building.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Building.Name = "TextBox_Building";
            this.TextBox_Building.PasswordChar = '\0';
            this.TextBox_Building.PlaceholderText = "";
            this.TextBox_Building.SelectedText = "";
            this.TextBox_Building.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Building.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(835, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Building No.";
            // 
            // Button_products
            // 
            this.Button_products.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_products.BorderRadius = 15;
            this.Button_products.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_products.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_products.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_products.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_products.FillColor = System.Drawing.Color.LightSeaGreen;
            this.Button_products.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_products.ForeColor = System.Drawing.Color.Azure;
            this.Button_products.Location = new System.Drawing.Point(126, 559);
            this.Button_products.Margin = new System.Windows.Forms.Padding(4);
            this.Button_products.Name = "Button_products";
            this.Button_products.Size = new System.Drawing.Size(118, 25);
            this.Button_products.TabIndex = 57;
            this.Button_products.Text = "Products";
            this.Button_products.Click += new System.EventHandler(this.Button_products_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(32, 559);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Manage:";
            // 
            // table_customers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.table_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_customers.BackgroundColor = System.Drawing.Color.White;
            this.table_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_customers.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_customers.DefaultCellStyle = dataGridViewCellStyle3;
            this.table_customers.EnableHeadersVisualStyles = false;
            this.table_customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_customers.Location = new System.Drawing.Point(31, 123);
            this.table_customers.Name = "table_customers";
            this.table_customers.RowHeadersVisible = false;
            this.table_customers.RowHeadersWidth = 51;
            this.table_customers.RowTemplate.Height = 24;
            this.table_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_customers.Size = new System.Drawing.Size(770, 433);
            this.table_customers.TabIndex = 58;
            this.table_customers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table_customers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table_customers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table_customers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table_customers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table_customers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.table_customers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_customers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.table_customers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table_customers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_customers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table_customers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_customers.ThemeStyle.HeaderStyle.Height = 29;
            this.table_customers.ThemeStyle.ReadOnly = false;
            this.table_customers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.table_customers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_customers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_customers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_customers.ThemeStyle.RowsStyle.Height = 24;
            this.table_customers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_customers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_customers.Click += new System.EventHandler(this.table_customers_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 615);
            this.Controls.Add(this.table_customers);
            this.Controls.Add(this.Button_products);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBox_Building);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_UPDATE);
            this.Controls.Add(this.Button_ADD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.TextBox_Street);
            this.Controls.Add(this.TextBox_City);
            this.Controls.Add(this.TextBox_LastName);
            this.Controls.Add(this.TextBox_FirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.comboBox_view);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button Button_Delete;
        private Guna.UI2.WinForms.Guna2Button Button_UPDATE;
        private Guna.UI2.WinForms.Guna2Button Button_ADD;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Street;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_City;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_LastName;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_FirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboBox_view;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Building;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Button_products;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView table_customers;
    }
}