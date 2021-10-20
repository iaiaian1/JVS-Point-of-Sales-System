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
    public partial class Form2 : Form
    {
        SqlConnection connection;
        string connectionstring;
 

        public Form2()
        {
            InitializeComponent();

            connectionstring = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.DatabaseConnectionString"].ConnectionString;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet17.Stockout' table. You can move, or remove it, as needed.
            this.stockoutTableAdapter6.Fill(this.databaseDataSet17.Stockout);
            // TODO: This line of code loads data into the 'databaseDataSet2.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.databaseDataSet2.Inventory);

        }

        private void PopulateInventory() 
        {
            string query = "SELECT * FROM Inventory";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable inventory = new DataTable();
                adapter.Fill(inventory);

                dataGridView1.DataSource = inventory;

            }

        }

        private void PopulateStocksInOut() 
        {
            string query = "SELECT * FROM Stockout";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable stockout = new DataTable();
                adapter.Fill(stockout);

                dataGridView2.DataSource = stockout;

            }


        }
        private void TheStockIn()
        {

            string query = "INSERT INTO Stockout (Name, Pieces, Stockin, StockinTime) VALUES (@name, @quantity ,@quantity, getdate())";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@name", productnametxtbox.Text);
                command.Parameters.AddWithValue("@quantity", piecestxtbox.Text);



                command.ExecuteScalar();
            }

        }


        private void addproduct_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Inventory VALUES (@name, @price, @pieces)";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection)) 
            {
                connection.Open();
                
                command.Parameters.AddWithValue("@name", productnametxtbox.Text);
                command.Parameters.AddWithValue("@price", pricetxtbox.Text);
                command.Parameters.AddWithValue("@pieces", piecestxtbox.Text);

                command.ExecuteScalar();

            }
            //Microsoft.VisualBasic.Interaction.InputBox("Question?", "Title", "Default Text");

            PopulateInventory();
            TheStockIn();
            PopulateStocksInOut();

        }

        private void productnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockupdate() 
        {
            string query = "INSERT INTO Stockout (Name, Pieces, StockinTime) VALUES (@name, @pieces, getdate())";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@name", productnametxtbox.Text);
                command.Parameters.AddWithValue("@pieces", piecestxtbox.Text);

                command.ExecuteScalar();

            }


        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Inventory SET Name = @name, Price = @price, Pieces = @pieces WHERE Id = @id";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", productidtxtbox.Text);
                command.Parameters.AddWithValue("@name", productnametxtbox.Text);
                command.Parameters.AddWithValue("@price", pricetxtbox.Text);
                command.Parameters.AddWithValue("@pieces", piecestxtbox.Text);

                command.ExecuteScalar();

            }

            PopulateInventory();
            stockupdate();
            PopulateStocksInOut();

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Inventory WHERE Name LIKE '%' + @name + '%'";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                connection.Open();

                command.Parameters.AddWithValue("@name", productnametxtbox.Text);

                DataTable searchdata = new DataTable();
                adapter.Fill(searchdata);

                dataGridView1.DataSource = searchdata;

                command.ExecuteScalar();

            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockDELETE() 
        {
            string query = "INSERT INTO Stockout (Name, Pieces, Stockout, StockoutTime) VALUES ((SELECT Name FROM Inventory WHERE Id = @id), (SELECT Pieces FROM Inventory WHERE Id = @id), (SELECT Pieces FROM Inventory WHERE Id = @id), getdate())";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", productidtxtbox.Text);
                command.Parameters.AddWithValue("@name", productnametxtbox.Text);
                command.Parameters.AddWithValue("@quantity", piecestxtbox.Text);

                command.ExecuteScalar();

            }


        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            StockDELETE();

            string query = "DELETE FROM Inventory WHERE Id = @id";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", productidtxtbox.Text);

                command.ExecuteScalar();

            }

            PopulateInventory();
            PopulateStocksInOut();
         
        }


        

    }
}
