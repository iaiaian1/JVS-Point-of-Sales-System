namespace POS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label7 = new System.Windows.Forms.Label();
            this.totalcost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cashkush = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.newsubmission = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.productlistdatagrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new POS.DatabaseDataSet1();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new POS.DatabaseDataSet1TableAdapters.InventoryTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idtxtboxCART = new System.Windows.Forms.TextBox();
            this.piecestxtboxCART = new System.Windows.Forms.TextBox();
            this.addCART = new System.Windows.Forms.Button();
            this.shoppingcartdatagrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new POS.DatabaseDataSet3();
            this.shoppingCartTableAdapter = new POS.DatabaseDataSet3TableAdapters.ShoppingCartTableAdapter();
            this.cartresetbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.discountlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.discountcombobox = new System.Windows.Forms.ComboBox();
            this.cartdeleteinventorybutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lessvat = new System.Windows.Forms.TextBox();
            this.discounttextbox = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productnamelabel = new System.Windows.Forms.Label();
            this.productnameinventory = new System.Windows.Forms.TextBox();
            this.salesreportbutton = new System.Windows.Forms.Button();
            this.textboxforcashiername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeuser = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productlistdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingcartdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total cost:";
            // 
            // totalcost
            // 
            this.totalcost.AutoSize = true;
            this.totalcost.Location = new System.Drawing.Point(168, 153);
            this.totalcost.Name = "totalcost";
            this.totalcost.Size = new System.Drawing.Size(50, 25);
            this.totalcost.TabIndex = 15;
            this.totalcost.Text = "0.00";
            this.totalcost.Click += new System.EventHandler(this.totalcost_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(9, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cash:";
            // 
            // cashkush
            // 
            this.cashkush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cashkush.Location = new System.Drawing.Point(136, 345);
            this.cashkush.Name = "cashkush";
            this.cashkush.Size = new System.Drawing.Size(179, 23);
            this.cashkush.TabIndex = 17;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Lime;
            this.enter.Location = new System.Drawing.Point(63, 192);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(111, 40);
            this.enter.TabIndex = 18;
            this.enter.Text = "Pay";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // newsubmission
            // 
            this.newsubmission.BackColor = System.Drawing.Color.DarkOrange;
            this.newsubmission.Location = new System.Drawing.Point(187, 192);
            this.newsubmission.Name = "newsubmission";
            this.newsubmission.Size = new System.Drawing.Size(111, 40);
            this.newsubmission.TabIndex = 19;
            this.newsubmission.Text = "New order";
            this.newsubmission.UseVisualStyleBackColor = false;
            this.newsubmission.Click += new System.EventHandler(this.newsubmission_Click);
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.Chocolate;
            this.inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inventory.Location = new System.Drawing.Point(17, 591);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(108, 40);
            this.inventory.TabIndex = 20;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // productlistdatagrid
            // 
            this.productlistdatagrid.AllowUserToAddRows = false;
            this.productlistdatagrid.AllowUserToDeleteRows = false;
            this.productlistdatagrid.AutoGenerateColumns = false;
            this.productlistdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productlistdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.piecesDataGridViewTextBoxColumn});
            this.productlistdatagrid.DataSource = this.inventoryBindingSource1;
            this.productlistdatagrid.Location = new System.Drawing.Point(385, 134);
            this.productlistdatagrid.Name = "productlistdatagrid";
            this.productlistdatagrid.ReadOnly = true;
            this.productlistdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productlistdatagrid.Size = new System.Drawing.Size(443, 543);
            this.productlistdatagrid.TabIndex = 21;
            this.productlistdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // piecesDataGridViewTextBoxColumn
            // 
            this.piecesDataGridViewTextBoxColumn.DataPropertyName = "Pieces";
            this.piecesDataGridViewTextBoxColumn.HeaderText = "Pieces";
            this.piecesDataGridViewTextBoxColumn.Name = "piecesDataGridViewTextBoxColumn";
            this.piecesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.databaseDataSet1;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(9, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Product ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(9, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Pieces:";
            // 
            // idtxtboxCART
            // 
            this.idtxtboxCART.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idtxtboxCART.Location = new System.Drawing.Point(136, 232);
            this.idtxtboxCART.Name = "idtxtboxCART";
            this.idtxtboxCART.Size = new System.Drawing.Size(179, 23);
            this.idtxtboxCART.TabIndex = 24;
            // 
            // piecestxtboxCART
            // 
            this.piecestxtboxCART.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.piecestxtboxCART.Location = new System.Drawing.Point(136, 268);
            this.piecestxtboxCART.Name = "piecestxtboxCART";
            this.piecestxtboxCART.Size = new System.Drawing.Size(179, 23);
            this.piecestxtboxCART.TabIndex = 25;
            // 
            // addCART
            // 
            this.addCART.BackColor = System.Drawing.SystemColors.Info;
            this.addCART.Location = new System.Drawing.Point(136, 392);
            this.addCART.Name = "addCART";
            this.addCART.Size = new System.Drawing.Size(73, 34);
            this.addCART.TabIndex = 26;
            this.addCART.Text = "Add to cart";
            this.addCART.UseVisualStyleBackColor = false;
            this.addCART.Click += new System.EventHandler(this.addCART_Click);
            // 
            // shoppingcartdatagrid
            // 
            this.shoppingcartdatagrid.AllowUserToAddRows = false;
            this.shoppingcartdatagrid.AllowUserToDeleteRows = false;
            this.shoppingcartdatagrid.AutoGenerateColumns = false;
            this.shoppingcartdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingcartdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.Id});
            this.shoppingcartdatagrid.DataSource = this.shoppingCartBindingSource;
            this.shoppingcartdatagrid.Location = new System.Drawing.Point(855, 134);
            this.shoppingcartdatagrid.Name = "shoppingcartdatagrid";
            this.shoppingcartdatagrid.ReadOnly = true;
            this.shoppingcartdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shoppingcartdatagrid.Size = new System.Drawing.Size(343, 273);
            this.shoppingcartdatagrid.TabIndex = 28;
            this.shoppingcartdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // shoppingCartBindingSource
            // 
            this.shoppingCartBindingSource.DataMember = "ShoppingCart";
            this.shoppingCartBindingSource.DataSource = this.databaseDataSet3;
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "DatabaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingCartTableAdapter
            // 
            this.shoppingCartTableAdapter.ClearBeforeFill = true;
            // 
            // cartresetbutton
            // 
            this.cartresetbutton.BackColor = System.Drawing.SystemColors.Info;
            this.cartresetbutton.Location = new System.Drawing.Point(136, 432);
            this.cartresetbutton.Name = "cartresetbutton";
            this.cartresetbutton.Size = new System.Drawing.Size(73, 34);
            this.cartresetbutton.TabIndex = 29;
            this.cartresetbutton.Text = "Clear cart";
            this.cartresetbutton.UseVisualStyleBackColor = false;
            this.cartresetbutton.Click += new System.EventHandler(this.cartresetbutton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(850, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Cart:";
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.discountlbl.Location = new System.Drawing.Point(9, 308);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(119, 17);
            this.discountlbl.TabIndex = 3;
            this.discountlbl.Text = "Discount percent:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 33);
            this.label4.TabIndex = 35;
            this.label4.Text = "Order Detail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discountcombobox
            // 
            this.discountcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.discountcombobox.FormattingEnabled = true;
            this.discountcombobox.Items.AddRange(new object[] {
            "REGULAR",
            "STUDENT",
            "SENIOR CITIZEN",
            "PWD"});
            this.discountcombobox.Location = new System.Drawing.Point(136, 304);
            this.discountcombobox.Name = "discountcombobox";
            this.discountcombobox.Size = new System.Drawing.Size(179, 24);
            this.discountcombobox.TabIndex = 37;
            this.discountcombobox.SelectedIndexChanged += new System.EventHandler(this.discountcombobox_SelectedIndexChanged);
            // 
            // cartdeleteinventorybutton
            // 
            this.cartdeleteinventorybutton.BackColor = System.Drawing.SystemColors.Info;
            this.cartdeleteinventorybutton.Location = new System.Drawing.Point(242, 392);
            this.cartdeleteinventorybutton.Name = "cartdeleteinventorybutton";
            this.cartdeleteinventorybutton.Size = new System.Drawing.Size(73, 34);
            this.cartdeleteinventorybutton.TabIndex = 39;
            this.cartdeleteinventorybutton.Text = "Delete from cart";
            this.cartdeleteinventorybutton.UseVisualStyleBackColor = false;
            this.cartdeleteinventorybutton.Click += new System.EventHandler(this.cartdeleteinventorybutton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(385, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(813, 33);
            this.label5.TabIndex = 41;
            this.label5.Text = "Register";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lessvat);
            this.groupBox1.Controls.Add(this.discounttextbox);
            this.groupBox1.Controls.Add(this.newsubmission);
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Controls.Add(this.subtotal);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.totalcost);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(855, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 249);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lessvat
            // 
            this.lessvat.Location = new System.Drawing.Point(173, 71);
            this.lessvat.Name = "lessvat";
            this.lessvat.ReadOnly = true;
            this.lessvat.Size = new System.Drawing.Size(125, 30);
            this.lessvat.TabIndex = 23;
            this.lessvat.Text = "0";
            // 
            // discounttextbox
            // 
            this.discounttextbox.Location = new System.Drawing.Point(173, 107);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.ReadOnly = true;
            this.discounttextbox.Size = new System.Drawing.Size(125, 30);
            this.discounttextbox.TabIndex = 22;
            // 
            // subtotal
            // 
            this.subtotal.Location = new System.Drawing.Point(173, 35);
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Size = new System.Drawing.Size(125, 30);
            this.subtotal.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Less VAT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Discount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(58, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Sub-total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(385, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Menu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1087, 736);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "JVS Pos System 2021";
            // 
            // productnamelabel
            // 
            this.productnamelabel.AutoSize = true;
            this.productnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productnamelabel.Location = new System.Drawing.Point(9, 198);
            this.productnamelabel.Name = "productnamelabel";
            this.productnamelabel.Size = new System.Drawing.Size(100, 17);
            this.productnamelabel.TabIndex = 4;
            this.productnamelabel.Text = "Product name:";
            // 
            // productnameinventory
            // 
            this.productnameinventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productnameinventory.Location = new System.Drawing.Point(136, 195);
            this.productnameinventory.Name = "productnameinventory";
            this.productnameinventory.Size = new System.Drawing.Size(179, 23);
            this.productnameinventory.TabIndex = 11;
            this.productnameinventory.TextChanged += new System.EventHandler(this.cashiername_TextChanged);
            // 
            // salesreportbutton
            // 
            this.salesreportbutton.BackColor = System.Drawing.Color.Chocolate;
            this.salesreportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.salesreportbutton.Location = new System.Drawing.Point(156, 591);
            this.salesreportbutton.Name = "salesreportbutton";
            this.salesreportbutton.Size = new System.Drawing.Size(108, 40);
            this.salesreportbutton.TabIndex = 45;
            this.salesreportbutton.Text = "Sales";
            this.salesreportbutton.UseVisualStyleBackColor = false;
            this.salesreportbutton.Click += new System.EventHandler(this.salesreportbutton_Click);
            // 
            // textboxforcashiername
            // 
            this.textboxforcashiername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textboxforcashiername.Enabled = false;
            this.textboxforcashiername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxforcashiername.Location = new System.Drawing.Point(85, 701);
            this.textboxforcashiername.Name = "textboxforcashiername";
            this.textboxforcashiername.ReadOnly = true;
            this.textboxforcashiername.Size = new System.Drawing.Size(179, 26);
            this.textboxforcashiername.TabIndex = 46;
            this.textboxforcashiername.TextChanged += new System.EventHandler(this.textboxforcashiername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Cashier:";
            // 
            // changeuser
            // 
            this.changeuser.BackColor = System.Drawing.Color.Chocolate;
            this.changeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.changeuser.Location = new System.Drawing.Point(17, 637);
            this.changeuser.Name = "changeuser";
            this.changeuser.Size = new System.Drawing.Size(108, 40);
            this.changeuser.TabIndex = 48;
            this.changeuser.Text = "LOGOUT";
            this.changeuser.UseVisualStyleBackColor = false;
            this.changeuser.Click += new System.EventHandler(this.changeuser_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleDescription = "";
            this.pictureBox3.AccessibleName = "";
            this.pictureBox3.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(385, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleDescription = "";
            this.pictureBox2.AccessibleName = "";
            this.pictureBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 758);
            this.Controls.Add(this.changeuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxforcashiername);
            this.Controls.Add(this.salesreportbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cartdeleteinventorybutton);
            this.Controls.Add(this.discountcombobox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cartresetbutton);
            this.Controls.Add(this.shoppingcartdatagrid);
            this.Controls.Add(this.addCART);
            this.Controls.Add(this.piecestxtboxCART);
            this.Controls.Add(this.idtxtboxCART);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.productlistdatagrid);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.cashkush);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productnameinventory);
            this.Controls.Add(this.productnamelabel);
            this.Controls.Add(this.discountlbl);
            this.Controls.Add(this.label5);
            this.Name = "frmMain";
            this.Text = "JVS POS System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productlistdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingcartdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalcost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cashkush;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button newsubmission;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.DataGridView productlistdatagrid;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private DatabaseDataSet1TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idtxtboxCART;
        private System.Windows.Forms.TextBox piecestxtboxCART;
        private System.Windows.Forms.Button addCART;
        private System.Windows.Forms.DataGridView shoppingcartdatagrid;
        private DatabaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource shoppingCartBindingSource;
        private DatabaseDataSet3TableAdapters.ShoppingCartTableAdapter shoppingCartTableAdapter;
        private System.Windows.Forms.Button cartresetbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cartdeleteinventorybutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lessvat;
        private System.Windows.Forms.TextBox discounttextbox;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productnamelabel;
        private System.Windows.Forms.TextBox productnameinventory;
        private System.Windows.Forms.Button salesreportbutton;
        private System.Windows.Forms.TextBox textboxforcashiername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeuser;
        private System.Windows.Forms.ComboBox discountcombobox;
    }
}

