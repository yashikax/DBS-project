using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace BidandBuy
{
    public partial class BuyerLogin : Form
    {
        
        public BuyerLogin()
        {
            InitializeComponent();
        }

       

        
        
            
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int username;
            if (!int.TryParse(textBox1.Text.Trim(), out username))
            {
                MessageBox.Show("Username must be an integer value.");
                return;
            }
            string password = textBox2.Text.Trim();
            string connectionString = "DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM; PASSWORD=valli";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the user's credentials are correct
                    string query = "SELECT COUNT(*) FROM buyer WHERE buyer_id = :username AND password = :password";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("username", OracleDbType.Int32, username, ParameterDirection.Input));
                        command.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2, password, ParameterDirection.Input));

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            BuyerHomePage frm2 = new BuyerHomePage();
                            frm2.Show();
                            // Open a new form or display the main application window
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
            }
        }

        private void BuyerLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
