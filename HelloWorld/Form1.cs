using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = Cities.GetItemText(Cities.SelectedIndex);
            var city = Cities.GetItemText(Cities.SelectedItems);

            MessageBox.Show(index, city);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = namelabel.Text;
            var lastName = lastnameLabel.Text;
            var address = addresslabel.Text;
            var city = citylabel.Text;
            /*
                        var query = "INSERT INTO users (FirstName, LastName, Address, City) VALUES (@firstName, @lastName, @ddress, @city)";

                        var message = DatabaseConnection(query, firstName, lastName, address, city);

                        MessageBox.Show(message);*/
            string connectionString = @"Data Source=DESKTOP-RQJ7MVQ;Initial Catalog=HelloWorldDb; USER ID=sa; password=P@55w0rd";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = "INSERT INTO Tutotial (ID,Name) VALUES (@id,@name)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", 2);
                    command.Parameters.AddWithValue("@name", firstName);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    { MessageBox.Show("Error inserting data into Database!"); }
                    else
                    {
                        MessageBox.Show("Update successful");
                    }
                }
            }


        }

        private void btnConnectDatabase_Click(object sender, EventArgs e)
        {
            string connectionString;
            string queryString;

            connectionString = @"Data Source=DESKTOP-RQJ7MVQ;Initial Catalog=HelloWorldDb; USER ID=sa; password=P@55w0rd";
            queryString = "CREATE TABLE Tutotial(ID int, Name varchar(255))";

            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void getTables_Click(object sender, EventArgs e)
        {
            string connectionString;
            string queryString;

            connectionString = @"Data Source=DESKTOP-RQJ7MVQ;Initial Catalog=HelloWorldDb; USER ID=sa; password=P@55w0rd";
            queryString = "SELECT * FROM users";


            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter(queryString, connection);
                DataTable tuto = new DataTable();
                adpt.Fill(tuto);
                dataGridView1.DataSource = tuto;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
