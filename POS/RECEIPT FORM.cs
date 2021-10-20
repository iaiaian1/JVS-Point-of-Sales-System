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
    public partial class RECEIPT_FORM : Form
    {
        SqlConnection connection;
        string connectionstring;

        public RECEIPT_FORM(string cashforreceipt)
        {
            InitializeComponent();
            connectionstring = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            string cashforcalculation = cashforreceipt;

            cashkush.Text = cashforcalculation;


            //START
            string query = "SELECT TOP 1 Total FROM SalesReport2 ORDER BY id DESC";
            double totalcost = 0;

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalcost = reader.GetInt32(0);
                    }
                }
                connection.Close();

            }

            textBox1.Text = totalcost.ToString();
            double thecash = double.Parse(cashforcalculation);

            double change = thecash - totalcost;
            textBox2.Text = change.ToString();


            //discount type
            string query2 = "SELECT TOP 1 Discount FROM SalesReport2 ORDER BY id DESC";;

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query2, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                string discounttype = (string)command.ExecuteScalar();

                textBox3.Text = discounttype.ToString();

            }

            //SUBTOTAL
            string query3 = "SELECT TOP 1 Subtotal FROM SalesReport2 ORDER BY id DESC";
            double subtotal = 0;

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query3, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalcost = reader.GetInt32(0);
                    }
                }
                connection.Close();

            }
            textBox4.Text = totalcost.ToString();



            //ORDER ID
            string query4 = "SELECT TOP 1 Id FROM SalesReport2 ORDER BY id DESC";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query4, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                int orderID = (int)command.ExecuteScalar();

                textboxfororderID.Text = orderID.ToString();



            }


        }

        private void RECEIPT_FORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet8.ShoppingCart' table. You can move, or remove it, as needed.
            this.shoppingCartTableAdapter.Fill(this.databaseDataSet8.ShoppingCart);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
