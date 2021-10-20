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
    public partial class loginform : Form
    {
        SqlConnection connection;
        string connectionstring;

        public loginform()
        {
            InitializeComponent();

            connectionstring = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.DatabaseConnectionString"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void loginbutton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Accounts WHERE Name = @username and Password = @password";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@username", usernametxtbox.Text);
                command.Parameters.AddWithValue("@password", passwordtxtbox.Text);

                try
                {
                    connection.Open();

                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    int count = 0;

                    while (reader.Read()) 
                    {
                        count = count + 1;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("Logging in");

                        this.Hide();
                        frmMain main = new frmMain(usernametxtbox.Text);
                        main.ShowDialog();
                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("Duplicate");
                    }
                    else 
                    {
                        MessageBox.Show("Incorrect credentials");
                        connection.Close(); 
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
