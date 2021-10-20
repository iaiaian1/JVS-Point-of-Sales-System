using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace POS
{
    public partial class frmMain : Form
    {
        SqlConnection connection;
        string connectionstring;


        public frmMain(string cashierlabelfromlogin)
        {
            InitializeComponent();

            connectionstring = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            discountcombobox.SelectedItem = "REGULAR";

            string currentcashier = cashierlabelfromlogin;

            textboxforcashiername.Text = currentcashier;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.ShoppingCart' table. You can move, or remove it, as needed.
            this.shoppingCartTableAdapter.Fill(this.databaseDataSet3.ShoppingCart);
            // TODO: This line of code loads data into the 'databaseDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.databaseDataSet1.Inventory);


        }


        private void PopulateShoppingCart() 
        {
            string query = "SELECT * FROM ShoppingCart";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable shoppingcarttable = new DataTable();
                adapter.Fill(shoppingcarttable);

                shoppingcartdatagrid.DataSource = shoppingcarttable;

            }
        }
        private void PopulateProductList() 
        {
            string query = "SELECT * FROM Inventory";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable productlist = new DataTable();
                adapter.Fill(productlist);

                productlistdatagrid.DataSource = productlist;

            }
        }
        private void Calculation() 
        {

            string query = "SELECT * FROM ShoppingCart";
            
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                DataTable sample = new DataTable();
                adapter.Fill(sample);

                shoppingcartdatagrid.DataSource = sample;

                double discount,discountedtotal;
                int price, quantity;
                int total = 0;

                foreach (DataGridViewRow row in shoppingcartdatagrid.Rows)
                {
                    price = Convert.ToInt32(row.Cells[1].Value);
                    quantity = Convert.ToInt32(row.Cells[2].Value);
                    total += price * quantity;
                }


                //DISCOUNT
                if (discountcombobox.SelectedItem == "STUDENT" || discountcombobox.SelectedItem == "SENIOR CITIZEN" || discountcombobox.SelectedItem == "PWD")
                {
                    discount = .20;
                }
                else
                {
                    discount = .0;
                }

                discountedtotal = total - (total * discount);
                
                subtotal.Text= total.ToString();
                lessvat.Text="0";
                totalcost.Text = discountedtotal.ToString();



            }

        }

        private void UpdateInventory() 
        {
        //SQL INVENTORY CODE

            foreach (DataGridViewRow row in shoppingcartdatagrid.Rows)
            {

                string query = "UPDATE Inventory SET Pieces = (Pieces - @quantity) WHERE Name LIKE '%' + @name + '%'";

                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@name", row.Cells[0].Value);
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[2].Value));

                    command.ExecuteScalar();
                }

                PopulateProductList();
            }

            TheStockOut();
        }
        private void SalesReport() 
        {
            //SQL SALES REPORT
            string query = "INSERT INTO SalesReport2 (Cashier, Subtotal, Total, Discount, Date)" +
                "SELECT @Cashier, @Subtotal, @Total, @Discount, getdate()";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Cashier", textboxforcashiername.Text);
                command.Parameters.AddWithValue("@Subtotal", subtotal.Text);
                command.Parameters.AddWithValue("@Total", totalcost.Text);
                command.Parameters.AddWithValue("@Discount", discountcombobox.Text);

                command.ExecuteScalar();
            }

        }

        //private void FAILEDStockOut() 
        //{
        //    foreach (DataGridViewRow row in shoppingcartdatagrid.Rows)
        //    {

        //        string query = "INSERT INTO Stockout (Name, Pieces, Stockout, StockoutTime) " +
        //        "SELECT S.ProductId, @quantity, @quantity, getdate() FROM Stockout S " +
        //        "INNER JOIN Inventory INV " +
        //        "ON S.ProductId = INV.Name ";

        //        using (connection = new SqlConnection(connectionstring))
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //        {
        //            connection.Open();

        //            command.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[2].Value));

        //            command.ExecuteScalar();
        //        }
        //    }

        //}


        private void TheStockOut()
        {
            foreach (DataGridViewRow row in shoppingcartdatagrid.Rows)
            {
                string query = "INSERT INTO Stockout (Name, Pieces, Stockout, StockoutTime, OrderId) VALUES (@name,@quantity ,@quantity, getdate(), (SELECT TOP 1 Id FROM SalesReport2 ORDER BY id DESC))";

                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@name", row.Cells[0].Value);
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[2].Value));


                    command.ExecuteScalar();
                }

            }
        }


















        private void sampleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void aaa1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customername_TextChanged(object sender, EventArgs e)
        {

        }

        private void newsubmission_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ShoppingCart";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.ExecuteScalar();
            }

            totalcost.Text = "0.00";

            PopulateShoppingCart();
            PopulateProductList();


            cashkush.Text = "";
            idtxtboxCART.Text = "";
            piecestxtboxCART.Text = "";
            subtotal.Text = "";
            productnameinventory.Text = "";

            discountcombobox.SelectedItem = "REGULAR";
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();


            //if(accounttype = admin){ 
            //messagebox.show("Opening Inventory");
            //Form2 f2 = new Form2();
            //f2.ShowDialog();
            //}else{
            //messagebox.show("No permission");
            //}
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int price, quantity;
            int total = 0;
            double discountedcost, discount, thediscount, cash, change;
            string cashierN, discountname;


            //CASHIER NAME CAN BE CHANGED ACCORDING TO WHO IS LOGGED IN, THIS IS EXAMPLE
            cashierN = textboxforcashiername.Text;


            if (double.TryParse(cashkush.Text, out cash))
            {
                cash = double.Parse(cashkush.Text);

            }
            else{ 
            MessageBox.Show("Please recheck inputs"); 
            }


            foreach (DataGridViewRow row in shoppingcartdatagrid.Rows)
            {
                price = Convert.ToInt32(row.Cells[1].Value);
                quantity = Convert.ToInt32(row.Cells[2].Value);
                total += price * quantity;
            }

            if (discountcombobox.SelectedItem == "STUDENT" || discountcombobox.SelectedItem == "SENIOR CITIZEN" || discountcombobox.SelectedItem == "PWD")
            {
                discount = 20;
            }
            else 
            {
                discount = 0;
            }

            //calculation
            if (discount == 0) {
                thediscount = 0;
            }

            discountname = discountcombobox.SelectedText;

            thediscount = discount * .01;
            discountedcost = total - (total * thediscount);
            change = cash - discountedcost;
            

            //end of calculation

            //Receiptdisplay
            MessageBox.Show("Cashier name: "+cashierN+"\n"+
                "Price: "+total+"\n"+
                "Discount: %"+discount+"\n"+
                "Total price: "+discountedcost+"\n"+
                "Change: " + change, "RECEIPT");


            SalesReport();
            UpdateInventory();


            RECEIPT_FORM receipt = new RECEIPT_FORM(cashkush.Text);
            receipt.ShowDialog();

        }



        private void addCART_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO ShoppingCart (Name, Price, Quantity)" +
                "SELECT Name, Price, @quantity FROM Inventory WHERE Id = @id";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", idtxtboxCART.Text);
                command.Parameters.AddWithValue("@quantity", piecestxtboxCART.Text);

                command.ExecuteScalar();
            }


            PopulateShoppingCart();
            PopulateProductList();
            Calculation();
        }

        private void showcartbutton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cartresetbutton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ShoppingCart";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.ExecuteScalar();
            }

            totalcost.Text = "0.00";
            productnameinventory.Text = "";

            PopulateShoppingCart();
            PopulateProductList();
            Calculation();
        }

        private void totalcost_Click(object sender, EventArgs e)
        {

        }

        private void discountcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashiername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartdeleteinventorybutton_Click(object sender, EventArgs e)
        {

            string query = "UPDATE ShoppingCart SET Quantity = (Quantity - @pieces) WHERE Name LIKE '%' + @name + '%'";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@name", productnameinventory.Text);
                command.Parameters.AddWithValue("@pieces", piecestxtboxCART.Text);

                command.ExecuteScalar();

            }

            PopulateShoppingCart();
            PopulateProductList();
            Calculation();

        }

        private void searchinventorybutton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Inventory WHERE Name LIKE '%' + @name + '%'";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                connection.Open();

                command.Parameters.AddWithValue("@name", productnameinventory.Text);

                DataTable searchdata = new DataTable();
                adapter.Fill(searchdata);

                productlistdatagrid.DataSource = searchdata;

                command.ExecuteScalar();

            }
        }

        private void discountcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (discountcombobox.SelectedItem == "STUDENT" || discountcombobox.SelectedItem == "SENIOR CITIZEN" || discountcombobox.SelectedItem == "PWD")
            {
                discounttextbox.Text = "20%";
            }
            else
            {
                discounttextbox.Text = "0%";
            }


            Calculation();
        }

        private void salesreportbutton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textboxforcashiername_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeuser_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Logout now?",
                      "Logout", MessageBoxButtons.YesNo);
            switch (log)
            {
                case DialogResult.Yes:
                    this.Hide();
                    loginform login = new loginform();
                    login.ShowDialog();
                    break;
                case DialogResult.No:
                    break;
            }

         
        }
    }
}
