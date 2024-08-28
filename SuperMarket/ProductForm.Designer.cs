namespace SuperMarket
{
    partial class AdminProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_exit = new System.Windows.Forms.Label();
            this.comboBox_view = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_SSN = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Type = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_ADD = new Guna.UI2.WinForms.Guna2Button();
            this.Button_UPDATE = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.table_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Button_customers = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.Button_search = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_product)).BeginInit();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Azure;
            this.label_exit.Location = new System.Drawing.Point(1141, -10);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(40, 50);
            this.label_exit.TabIndex = 10;
            this.label_exit.Text = "x";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // comboBox_view
            // 
            this.comboBox_view.ForeColor = System.Drawing.Color.Teal;
            this.comboBox_view.FormattingEnabled = true;
            this.comboBox_view.Items.AddRange(new object[] {
            "All available products",
            "Products to be restocked"});
            this.comboBox_view.Location = new System.Drawing.Point(35, 81);
            this.comboBox_view.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_view.Name = "comboBox_view";
            this.comboBox_view.Size = new System.Drawing.Size(224, 24);
            this.comboBox_view.TabIndex = 12;
            this.comboBox_view.Text = "View";
            this.comboBox_view.SelectedIndexChanged += new System.EventHandler(this.comboBox_view_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Azure;
            this.ID.Location = new System.Drawing.Point(832, 183);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(36, 29);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(832, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(832, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(832, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(832, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(832, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "SSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(832, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type";
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
            this.TextBox_ID.Location = new System.Drawing.Point(953, 183);
            this.TextBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.Size = new System.Drawing.Size(176, 28);
            this.TextBox_ID.TabIndex = 20;
            // 
            // TextBox_SSN
            // 
            this.TextBox_SSN.BorderRadius = 10;
            this.TextBox_SSN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_SSN.DefaultText = "";
            this.TextBox_SSN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_SSN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_SSN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_SSN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_SSN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_SSN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_SSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_SSN.Location = new System.Drawing.Point(953, 223);
            this.TextBox_SSN.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_SSN.Name = "TextBox_SSN";
            this.TextBox_SSN.PasswordChar = '\0';
            this.TextBox_SSN.PlaceholderText = "";
            this.TextBox_SSN.SelectedText = "";
            this.TextBox_SSN.Size = new System.Drawing.Size(176, 28);
            this.TextBox_SSN.TabIndex = 21;
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
            this.TextBox_Name.Location = new System.Drawing.Point(953, 266);
            this.TextBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Name.TabIndex = 22;
            // 
            // TextBox_Type
            // 
            this.TextBox_Type.BorderRadius = 10;
            this.TextBox_Type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Type.DefaultText = "";
            this.TextBox_Type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Type.Location = new System.Drawing.Point(953, 308);
            this.TextBox_Type.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Type.Name = "TextBox_Type";
            this.TextBox_Type.PasswordChar = '\0';
            this.TextBox_Type.PlaceholderText = "";
            this.TextBox_Type.SelectedText = "";
            this.TextBox_Type.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Type.TabIndex = 23;
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
            this.TextBox_Price.Location = new System.Drawing.Point(953, 353);
            this.TextBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.PasswordChar = '\0';
            this.TextBox_Price.PlaceholderText = "";
            this.TextBox_Price.SelectedText = "";
            this.TextBox_Price.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Price.TabIndex = 24;
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
            this.TextBox_Quantity.Location = new System.Drawing.Point(953, 394);
            this.TextBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Quantity.Name = "TextBox_Quantity";
            this.TextBox_Quantity.PasswordChar = '\0';
            this.TextBox_Quantity.PlaceholderText = "";
            this.TextBox_Quantity.SelectedText = "";
            this.TextBox_Quantity.Size = new System.Drawing.Size(176, 28);
            this.TextBox_Quantity.TabIndex = 25;
            // 
            // comboBox_category
            // 
            this.comboBox_category.ForeColor = System.Drawing.Color.Teal;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(955, 438);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(173, 24);
            this.comboBox_category.TabIndex = 26;
            this.comboBox_category.Text = "Select category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(880, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Product Info:";
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
            this.Button_ADD.Location = new System.Drawing.Point(830, 503);
            this.Button_ADD.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(99, 38);
            this.Button_ADD.TabIndex = 28;
            this.Button_ADD.Text = "ADD";
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
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
            this.Button_UPDATE.Location = new System.Drawing.Point(936, 503);
            this.Button_UPDATE.Margin = new System.Windows.Forms.Padding(4);
            this.Button_UPDATE.Name = "Button_UPDATE";
            this.Button_UPDATE.Size = new System.Drawing.Size(99, 38);
            this.Button_UPDATE.TabIndex = 29;
            this.Button_UPDATE.Text = "UPDATE";
            this.Button_UPDATE.Click += new System.EventHandler(this.Button_UPDATE_Click);
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
            this.Button_Delete.Location = new System.Drawing.Point(1043, 503);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(99, 38);
            this.Button_Delete.TabIndex = 30;
            this.Button_Delete.Text = "DELETE";
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(440, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 36);
            this.label8.TabIndex = 31;
            this.label8.Text = "Manage Products";
            // 
            // table_product
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.table_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_product.BackgroundColor = System.Drawing.Color.White;
            this.table_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.table_product.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_product.DefaultCellStyle = dataGridViewCellStyle6;
            this.table_product.EnableHeadersVisualStyles = false;
            this.table_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_product.Location = new System.Drawing.Point(35, 124);
            this.table_product.Name = "table_product";
            this.table_product.RowHeadersVisible = false;
            this.table_product.RowHeadersWidth = 51;
            this.table_product.RowTemplate.Height = 24;
            this.table_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_product.Size = new System.Drawing.Size(735, 417);
            this.table_product.TabIndex = 32;
            this.table_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.table_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.table_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_product.ThemeStyle.HeaderStyle.Height = 24;
            this.table_product.ThemeStyle.ReadOnly = false;
            this.table_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.table_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_product.ThemeStyle.RowsStyle.Height = 24;
            this.table_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_product.Click += new System.EventHandler(this.table_product_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(29, 544);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Manage:";
            // 
            // Button_customers
            // 
            this.Button_customers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Button_customers.BorderRadius = 15;
            this.Button_customers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_customers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_customers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_customers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_customers.FillColor = System.Drawing.Color.LightSeaGreen;
            this.Button_customers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_customers.ForeColor = System.Drawing.Color.Azure;
            this.Button_customers.Location = new System.Drawing.Point(123, 544);
            this.Button_customers.Margin = new System.Windows.Forms.Padding(4);
            this.Button_customers.Name = "Button_customers";
            this.Button_customers.Size = new System.Drawing.Size(118, 25);
            this.Button_customers.TabIndex = 34;
            this.Button_customers.Text = "Customers";
            this.Button_customers.Click += new System.EventHandler(this.Button_customers_Click);
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
            this.TextBox_search.Location = new System.Drawing.Point(530, 77);
            this.TextBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_search.Name = "TextBox_search";
            this.TextBox_search.PasswordChar = '\0';
            this.TextBox_search.PlaceholderText = "";
            this.TextBox_search.SelectedText = "";
            this.TextBox_search.Size = new System.Drawing.Size(176, 25);
            this.TextBox_search.TabIndex = 35;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.Azure;
            this.label_search.Location = new System.Drawing.Point(434, 77);
            this.label_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(88, 25);
            this.label_search.TabIndex = 36;
            this.label_search.Text = "Search:";
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
            this.Button_search.Location = new System.Drawing.Point(714, 77);
            this.Button_search.Margin = new System.Windows.Forms.Padding(4);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(56, 25);
            this.Button_search.TabIndex = 37;
            this.Button_search.Text = "🔍";
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // AdminProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 615);
            this.Controls.Add(this.Button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.TextBox_search);
            this.Controls.Add(this.Button_customers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.table_product);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_UPDATE);
            this.Controls.Add(this.Button_ADD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.TextBox_Quantity);
            this.Controls.Add(this.TextBox_Price);
            this.Controls.Add(this.TextBox_Type);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_SSN);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.comboBox_view);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form2";
            this.Load += new System.EventHandler(this.AdminProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.ComboBox comboBox_view;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_SSN;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Type;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button Button_ADD;
        private Guna.UI2.WinForms.Guna2Button Button_UPDATE;
        private Guna.UI2.WinForms.Guna2Button Button_Delete;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView table_product;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button Button_customers;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_search;
        private System.Windows.Forms.Label label_search;
        private Guna.UI2.WinForms.Guna2Button Button_search;
    }
}