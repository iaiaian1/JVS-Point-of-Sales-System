namespace POS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new POS.DatabaseDataSet2();
            this.inventoryTableAdapter = new POS.DatabaseDataSet2TableAdapters.InventoryTableAdapter();
            this.pricetxtbox = new System.Windows.Forms.TextBox();
            this.piecestxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productnametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addproduct = new System.Windows.Forms.Button();
            this.updateproduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.productidtxtbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.databaseDataSet11 = new POS.DatabaseDataSet11();
            this.stockoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockoutTableAdapter = new POS.DatabaseDataSet11TableAdapters.StockoutTableAdapter();
            this.stockoutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet12 = new POS.DatabaseDataSet12();
            this.stockoutTableAdapter1 = new POS.DatabaseDataSet12TableAdapters.StockoutTableAdapter();
            this.databaseDataSet13 = new POS.DatabaseDataSet13();
            this.stockoutBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stockoutTableAdapter2 = new POS.DatabaseDataSet13TableAdapters.StockoutTableAdapter();
            this.databaseDataSet14 = new POS.DatabaseDataSet14();
            this.stockoutBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stockoutTableAdapter3 = new POS.DatabaseDataSet14TableAdapters.StockoutTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.databaseDataSet15 = new POS.DatabaseDataSet15();
            this.stockoutBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.stockoutTableAdapter4 = new POS.DatabaseDataSet15TableAdapters.StockoutTableAdapter();
            this.databaseDataSet16 = new POS.DatabaseDataSet16();
            this.stockoutBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.stockoutTableAdapter5 = new POS.DatabaseDataSet16TableAdapters.StockoutTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet17 = new POS.DatabaseDataSet17();
            this.stockoutBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.stockoutTableAdapter6 = new POS.DatabaseDataSet17TableAdapters.StockoutTableAdapter();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piecesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockoutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockinTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.piecesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(337, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 270);
            this.dataGridView1.TabIndex = 0;
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
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // pricetxtbox
            // 
            this.pricetxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pricetxtbox.Location = new System.Drawing.Point(136, 142);
            this.pricetxtbox.Name = "pricetxtbox";
            this.pricetxtbox.Size = new System.Drawing.Size(154, 23);
            this.pricetxtbox.TabIndex = 30;
            // 
            // piecestxtbox
            // 
            this.piecestxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.piecestxtbox.Location = new System.Drawing.Point(136, 181);
            this.piecestxtbox.Name = "piecestxtbox";
            this.piecestxtbox.Size = new System.Drawing.Size(154, 23);
            this.piecestxtbox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pieces:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(30, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Price:";
            // 
            // productnametxtbox
            // 
            this.productnametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productnametxtbox.Location = new System.Drawing.Point(136, 98);
            this.productnametxtbox.Name = "productnametxtbox";
            this.productnametxtbox.Size = new System.Drawing.Size(154, 23);
            this.productnametxtbox.TabIndex = 26;
            this.productnametxtbox.TextChanged += new System.EventHandler(this.productnametxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Product name:";
            // 
            // addproduct
            // 
            this.addproduct.BackColor = System.Drawing.SystemColors.Info;
            this.addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addproduct.Location = new System.Drawing.Point(33, 241);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(108, 36);
            this.addproduct.TabIndex = 31;
            this.addproduct.Text = "Add";
            this.addproduct.UseVisualStyleBackColor = false;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // updateproduct
            // 
            this.updateproduct.BackColor = System.Drawing.SystemColors.Info;
            this.updateproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateproduct.Location = new System.Drawing.Point(167, 241);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(108, 36);
            this.updateproduct.TabIndex = 32;
            this.updateproduct.Text = "Update";
            this.updateproduct.UseVisualStyleBackColor = false;
            this.updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(30, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Product ID:";
            // 
            // productidtxtbox
            // 
            this.productidtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productidtxtbox.Location = new System.Drawing.Point(136, 62);
            this.productidtxtbox.Name = "productidtxtbox";
            this.productidtxtbox.Size = new System.Drawing.Size(154, 23);
            this.productidtxtbox.TabIndex = 34;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.SystemColors.Info;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchbutton.Location = new System.Drawing.Point(33, 296);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(108, 36);
            this.searchbutton.TabIndex = 35;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.IndianRed;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deletebutton.Location = new System.Drawing.Point(167, 296);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(108, 36);
            this.deletebutton.TabIndex = 36;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(136, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(519, 33);
            this.label5.TabIndex = 37;
            this.label5.Text = "Inventory Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleDescription = "";
            this.pictureBox2.AccessibleName = "";
            this.pictureBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // databaseDataSet11
            // 
            this.databaseDataSet11.DataSetName = "DatabaseDataSet11";
            this.databaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutBindingSource
            // 
            this.stockoutBindingSource.DataMember = "Stockout";
            this.stockoutBindingSource.DataSource = this.databaseDataSet11;
            // 
            // stockoutTableAdapter
            // 
            this.stockoutTableAdapter.ClearBeforeFill = true;
            // 
            // stockoutBindingSource1
            // 
            this.stockoutBindingSource1.DataMember = "Stockout";
            this.stockoutBindingSource1.DataSource = this.databaseDataSet12;
            // 
            // databaseDataSet12
            // 
            this.databaseDataSet12.DataSetName = "DatabaseDataSet12";
            this.databaseDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutTableAdapter1
            // 
            this.stockoutTableAdapter1.ClearBeforeFill = true;
            // 
            // databaseDataSet13
            // 
            this.databaseDataSet13.DataSetName = "DatabaseDataSet13";
            this.databaseDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutBindingSource2
            // 
            this.stockoutBindingSource2.DataMember = "Stockout";
            this.stockoutBindingSource2.DataSource = this.databaseDataSet13;
            // 
            // stockoutTableAdapter2
            // 
            this.stockoutTableAdapter2.ClearBeforeFill = true;
            // 
            // databaseDataSet14
            // 
            this.databaseDataSet14.DataSetName = "DatabaseDataSet14";
            this.databaseDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutBindingSource3
            // 
            this.stockoutBindingSource3.DataMember = "Stockout";
            this.stockoutBindingSource3.DataSource = this.databaseDataSet14;
            // 
            // stockoutTableAdapter3
            // 
            this.stockoutTableAdapter3.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(147, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 33);
            this.label6.TabIndex = 40;
            this.label6.Text = "Inventory Report";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // databaseDataSet15
            // 
            this.databaseDataSet15.DataSetName = "DatabaseDataSet15";
            this.databaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutBindingSource4
            // 
            this.stockoutBindingSource4.DataMember = "Stockout";
            this.stockoutBindingSource4.DataSource = this.databaseDataSet15;
            // 
            // stockoutTableAdapter4
            // 
            this.stockoutTableAdapter4.ClearBeforeFill = true;
            // 
            // databaseDataSet16
            // 
            this.databaseDataSet16.DataSetName = "DatabaseDataSet16";
            this.databaseDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutBindingSource5
            // 
            this.stockoutBindingSource5.DataMember = "Stockout";
            this.stockoutBindingSource5.DataSource = this.databaseDataSet16;
            // 
            // stockoutTableAdapter5
            // 
            this.stockoutTableAdapter5.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.piecesDataGridViewTextBoxColumn1,
            this.stockoutDataGridViewTextBoxColumn,
            this.stockoutTimeDataGridViewTextBoxColumn,
            this.stockinDataGridViewTextBoxColumn,
            this.stockinTimeDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stockoutBindingSource6;
            this.dataGridView2.Location = new System.Drawing.Point(33, 427);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(746, 326);
            this.dataGridView2.TabIndex = 42;
            // 
            // databaseDataSet17
            // 
            this.databaseDataSet17.DataSetName = "DatabaseDataSet17";
            this.databaseDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockoutBindingSource6
            // 
            this.stockoutBindingSource6.DataMember = "Stockout";
            this.stockoutBindingSource6.DataSource = this.databaseDataSet17;
            // 
            // stockoutTableAdapter6
            // 
            this.stockoutTableAdapter6.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // piecesDataGridViewTextBoxColumn1
            // 
            this.piecesDataGridViewTextBoxColumn1.DataPropertyName = "Pieces";
            this.piecesDataGridViewTextBoxColumn1.HeaderText = "Pieces";
            this.piecesDataGridViewTextBoxColumn1.Name = "piecesDataGridViewTextBoxColumn1";
            this.piecesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stockoutDataGridViewTextBoxColumn
            // 
            this.stockoutDataGridViewTextBoxColumn.DataPropertyName = "Stockout";
            this.stockoutDataGridViewTextBoxColumn.HeaderText = "Stockout";
            this.stockoutDataGridViewTextBoxColumn.Name = "stockoutDataGridViewTextBoxColumn";
            this.stockoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockoutTimeDataGridViewTextBoxColumn
            // 
            this.stockoutTimeDataGridViewTextBoxColumn.DataPropertyName = "StockoutTime";
            this.stockoutTimeDataGridViewTextBoxColumn.HeaderText = "StockoutTime";
            this.stockoutTimeDataGridViewTextBoxColumn.Name = "stockoutTimeDataGridViewTextBoxColumn";
            this.stockoutTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockinDataGridViewTextBoxColumn
            // 
            this.stockinDataGridViewTextBoxColumn.DataPropertyName = "Stockin";
            this.stockinDataGridViewTextBoxColumn.HeaderText = "Stockin";
            this.stockinDataGridViewTextBoxColumn.Name = "stockinDataGridViewTextBoxColumn";
            this.stockinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockinTimeDataGridViewTextBoxColumn
            // 
            this.stockinTimeDataGridViewTextBoxColumn.DataPropertyName = "StockinTime";
            this.stockinTimeDataGridViewTextBoxColumn.HeaderText = "StockinTime";
            this.stockinTimeDataGridViewTextBoxColumn.Name = "stockinTimeDataGridViewTextBoxColumn";
            this.stockinTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 774);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.productidtxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateproduct);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.pricetxtbox);
            this.Controls.Add(this.piecestxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productnametxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockoutBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private DatabaseDataSet2TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox pricetxtbox;
        private System.Windows.Forms.TextBox piecestxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productnametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button updateproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productidtxtbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DatabaseDataSet11 databaseDataSet11;
        private System.Windows.Forms.BindingSource stockoutBindingSource;
        private DatabaseDataSet11TableAdapters.StockoutTableAdapter stockoutTableAdapter;
        private DatabaseDataSet12 databaseDataSet12;
        private System.Windows.Forms.BindingSource stockoutBindingSource1;
        private DatabaseDataSet12TableAdapters.StockoutTableAdapter stockoutTableAdapter1;
        private DatabaseDataSet13 databaseDataSet13;
        private System.Windows.Forms.BindingSource stockoutBindingSource2;
        private DatabaseDataSet13TableAdapters.StockoutTableAdapter stockoutTableAdapter2;
        private DatabaseDataSet14 databaseDataSet14;
        private System.Windows.Forms.BindingSource stockoutBindingSource3;
        private DatabaseDataSet14TableAdapters.StockoutTableAdapter stockoutTableAdapter3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseDataSet15 databaseDataSet15;
        private System.Windows.Forms.BindingSource stockoutBindingSource4;
        private DatabaseDataSet15TableAdapters.StockoutTableAdapter stockoutTableAdapter4;
        private DatabaseDataSet16 databaseDataSet16;
        private System.Windows.Forms.BindingSource stockoutBindingSource5;
        private DatabaseDataSet16TableAdapters.StockoutTableAdapter stockoutTableAdapter5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DatabaseDataSet17 databaseDataSet17;
        private System.Windows.Forms.BindingSource stockoutBindingSource6;
        private DatabaseDataSet17TableAdapters.StockoutTableAdapter stockoutTableAdapter6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn piecesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockoutTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockinTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
    }
}