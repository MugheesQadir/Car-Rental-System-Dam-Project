namespace CarRentalSystemDamProject
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxCarReg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.UserDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.RentalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbxCustId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbxModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(9, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 39);
            this.label4.TabIndex = 57;
            this.label4.Text = "Rental Date";
            // 
            // cmbxCarReg
            // 
            this.cmbxCarReg.AutoRoundedCorners = true;
            this.cmbxCarReg.BackColor = System.Drawing.Color.Transparent;
            this.cmbxCarReg.BorderColor = System.Drawing.Color.Maroon;
            this.cmbxCarReg.BorderRadius = 17;
            this.cmbxCarReg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxCarReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCarReg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxCarReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxCarReg.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.cmbxCarReg.ForeColor = System.Drawing.Color.Maroon;
            this.cmbxCarReg.ItemHeight = 30;
            this.cmbxCarReg.Location = new System.Drawing.Point(200, 244);
            this.cmbxCarReg.Name = "cmbxCarReg";
            this.cmbxCarReg.Size = new System.Drawing.Size(206, 36);
            this.cmbxCarReg.TabIndex = 56;
            this.cmbxCarReg.SelectedIndexChanged += new System.EventHandler(this.cmbxCarReg_SelectedIndexChanged);
            this.cmbxCarReg.SelectionChangeCommitted += new System.EventHandler(this.cmbxCarReg_SelectionChangeCommitted);
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderColor = System.Drawing.Color.Maroon;
            this.txtName.BorderRadius = 19;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(200, 441);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtName.PlaceholderText = "Please Enter Name";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(204, 41);
            this.txtName.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 39);
            this.label3.TabIndex = 54;
            this.label3.Text = "Name";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Animated = true;
            this.BtnUpdate.AutoRoundedCorners = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.BorderColor = System.Drawing.Color.Maroon;
            this.BtnUpdate.BorderRadius = 27;
            this.BtnUpdate.BorderThickness = 1;
            this.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdate.FillColor = System.Drawing.Color.Maroon;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.IndicateFocus = true;
            this.BtnUpdate.Location = new System.Drawing.Point(641, 522);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 57);
            this.BtnUpdate.TabIndex = 53;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseTransparentBackground = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDGV.BackgroundColor = System.Drawing.Color.Maroon;
            this.UserDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDGV.ColumnHeadersHeight = 24;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDGV.Location = new System.Drawing.Point(440, 244);
            this.UserDGV.Margin = new System.Windows.Forms.Padding(4);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.RowTemplate.Height = 24;
            this.UserDGV.Size = new System.Drawing.Size(502, 271);
            this.UserDGV.TabIndex = 52;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Maroon;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserDGV.ThemeStyle.BackColor = System.Drawing.Color.Maroon;
            this.UserDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.UserDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Maroon;
            this.UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.UserDGV.ThemeStyle.ReadOnly = true;
            this.UserDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDGV.ThemeStyle.RowsStyle.Height = 24;
            this.UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Maroon;
            this.btnBack.BorderRadius = 27;
            this.btnBack.BorderThickness = 1;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IndicateFocus = true;
            this.btnBack.Location = new System.Drawing.Point(520, 585);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(353, 57);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Maroon;
            this.btnDelete.BorderRadius = 27;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(759, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 57);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Maroon;
            this.btnAdd.BorderRadius = 27;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Maroon;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(520, 522);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 57);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 85);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Rental Palace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 47;
            this.label2.Text = "CarReg";
            // 
            // txtId
            // 
            this.txtId.AutoRoundedCorners = true;
            this.txtId.BorderColor = System.Drawing.Color.Maroon;
            this.txtId.BorderRadius = 19;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtId.ForeColor = System.Drawing.Color.Maroon;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(200, 145);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtId.PlaceholderText = "Please Enter ID";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(206, 41);
            this.txtId.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(12, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 39);
            this.label7.TabIndex = 44;
            this.label7.Text = "CustID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(9, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 39);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(586, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 39);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cars On Rent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Maroon;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(904, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 39);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 30);
            this.panel1.TabIndex = 41;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2CustomGradientPanel1.Controls.Add(this.label10);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.Exit);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(958, 138);
            this.guna2CustomGradientPanel1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(431, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 49);
            this.label10.TabIndex = 25;
            this.label10.Text = "Rental";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(7, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 39);
            this.label8.TabIndex = 58;
            this.label8.Text = "Return Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(12, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 39);
            this.label9.TabIndex = 59;
            this.label9.Text = "Rent Fee";
            // 
            // txtFee
            // 
            this.txtFee.AutoRoundedCorners = true;
            this.txtFee.BorderColor = System.Drawing.Color.Maroon;
            this.txtFee.BorderRadius = 19;
            this.txtFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFee.DefaultText = "";
            this.txtFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFee.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtFee.ForeColor = System.Drawing.Color.Maroon;
            this.txtFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFee.Location = new System.Drawing.Point(200, 597);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtFee.PlaceholderText = "Please Enter Fees";
            this.txtFee.SelectedText = "";
            this.txtFee.Size = new System.Drawing.Size(204, 41);
            this.txtFee.TabIndex = 60;
            // 
            // RentalDate
            // 
            this.RentalDate.AutoRoundedCorners = true;
            this.RentalDate.BackColor = System.Drawing.Color.Transparent;
            this.RentalDate.BorderColor = System.Drawing.Color.Maroon;
            this.RentalDate.BorderRadius = 18;
            this.RentalDate.BorderThickness = 1;
            this.RentalDate.Checked = true;
            this.RentalDate.FillColor = System.Drawing.Color.White;
            this.RentalDate.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDate.ForeColor = System.Drawing.Color.Maroon;
            this.RentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.RentalDate.Location = new System.Drawing.Point(200, 498);
            this.RentalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RentalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.Size = new System.Drawing.Size(206, 39);
            this.RentalDate.TabIndex = 61;
            this.RentalDate.Value = new System.DateTime(2024, 5, 9, 23, 33, 25, 630);
            // 
            // ReturnDate
            // 
            this.ReturnDate.AutoRoundedCorners = true;
            this.ReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.ReturnDate.BorderColor = System.Drawing.Color.Maroon;
            this.ReturnDate.BorderRadius = 18;
            this.ReturnDate.BorderThickness = 1;
            this.ReturnDate.Checked = true;
            this.ReturnDate.FillColor = System.Drawing.Color.White;
            this.ReturnDate.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.ForeColor = System.Drawing.Color.Maroon;
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReturnDate.Location = new System.Drawing.Point(200, 551);
            this.ReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(206, 39);
            this.ReturnDate.TabIndex = 62;
            this.ReturnDate.Value = new System.DateTime(2024, 5, 9, 23, 33, 25, 630);
            // 
            // cmbxCustId
            // 
            this.cmbxCustId.AutoRoundedCorners = true;
            this.cmbxCustId.BackColor = System.Drawing.Color.Transparent;
            this.cmbxCustId.BorderColor = System.Drawing.Color.Maroon;
            this.cmbxCustId.BorderRadius = 17;
            this.cmbxCustId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCustId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxCustId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxCustId.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.cmbxCustId.ForeColor = System.Drawing.Color.Maroon;
            this.cmbxCustId.ItemHeight = 30;
            this.cmbxCustId.Location = new System.Drawing.Point(200, 390);
            this.cmbxCustId.Name = "cmbxCustId";
            this.cmbxCustId.Size = new System.Drawing.Size(204, 36);
            this.cmbxCustId.TabIndex = 63;
            this.cmbxCustId.SelectedIndexChanged += new System.EventHandler(this.cmbxCustId_SelectedIndexChanged);
            this.cmbxCustId.SelectionChangeCommitted += new System.EventHandler(this.cmbxCustId_SelectionChangeCommitted);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.BorderColor = System.Drawing.Color.Maroon;
            this.txtPrice.BorderRadius = 17;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(200, 341);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtPrice.PlaceholderText = "Please Enter Price";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(206, 37);
            this.txtPrice.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(13, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 31);
            this.label12.TabIndex = 65;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(5, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 40);
            this.label13.TabIndex = 64;
            this.label13.Text = "Model";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Maroon;
            this.guna2Button2.BorderRadius = 19;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(847, 196);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(95, 41);
            this.guna2Button2.TabIndex = 74;
            this.guna2Button2.Text = "Refresh";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Maroon;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(747, 193);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 41);
            this.guna2Button1.TabIndex = 73;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoRoundedCorners = true;
            this.txtsearch.BorderColor = System.Drawing.Color.Maroon;
            this.txtsearch.BorderRadius = 19;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtsearch.ForeColor = System.Drawing.Color.Maroon;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Location = new System.Drawing.Point(541, 193);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtsearch.PlaceholderText = "Please search here";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(199, 41);
            this.txtsearch.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(433, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 39);
            this.label14.TabIndex = 71;
            this.label14.Text = "Search";
            // 
            // cmbxModel
            // 
            this.cmbxModel.AutoRoundedCorners = true;
            this.cmbxModel.BackColor = System.Drawing.Color.Transparent;
            this.cmbxModel.BorderColor = System.Drawing.Color.Maroon;
            this.cmbxModel.BorderRadius = 17;
            this.cmbxModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxModel.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.cmbxModel.ForeColor = System.Drawing.Color.Maroon;
            this.cmbxModel.ItemHeight = 30;
            this.cmbxModel.Location = new System.Drawing.Point(200, 198);
            this.cmbxModel.Name = "cmbxModel";
            this.cmbxModel.Size = new System.Drawing.Size(206, 36);
            this.cmbxModel.TabIndex = 75;
            this.cmbxModel.SelectedIndexChanged += new System.EventHandler(this.cmbxModel_SelectedIndexChanged);
            this.cmbxModel.SelectionChangeCommitted += new System.EventHandler(this.cmbxModel_SelectionChangeCommitted);
            // 
            // txtbrand
            // 
            this.txtbrand.AutoRoundedCorners = true;
            this.txtbrand.BorderColor = System.Drawing.Color.Maroon;
            this.txtbrand.BorderRadius = 17;
            this.txtbrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbrand.DefaultText = "";
            this.txtbrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbrand.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtbrand.ForeColor = System.Drawing.Color.Maroon;
            this.txtbrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbrand.Location = new System.Drawing.Point(200, 291);
            this.txtbrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.PasswordChar = '\0';
            this.txtbrand.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtbrand.PlaceholderText = "Please Enter Price";
            this.txtbrand.ReadOnly = true;
            this.txtbrand.SelectedText = "";
            this.txtbrand.Size = new System.Drawing.Size(206, 37);
            this.txtbrand.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(13, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 31);
            this.label11.TabIndex = 76;
            this.label11.Text = "Brand";
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 677);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbxModel);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbxCustId);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.RentalDate);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbxCarReg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbxCarReg;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView UserDGV;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtFee;
        private Guna.UI2.WinForms.Guna2DateTimePicker RentalDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cmbxCustId;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ComboBox cmbxModel;
        private Guna.UI2.WinForms.Guna2TextBox txtbrand;
        private System.Windows.Forms.Label label11;
    }
}