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
    public partial class SellerInfo : Form
    {
        int id;
        public SellerInfo(int x)
        {
            this.id = x;
            InitializeComponent();
        }

        private void SellerInfo_Load(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM;PASSWORD =valli;"))
            {
                // Create a new OracleCommand object with a parameterized query
                string query = "SELECT * FROM seller WHERE seller_id = :seller_id";
                OracleCommand command = new OracleCommand(query, connection);

                // Create a new parameter object for the item_id parameter
                OracleParameter parameter = new OracleParameter(":seller_id", OracleDbType.Int32);

                // Set the parameter value to the value of the TextBox
                parameter.Value = id;

                // Add the parameter to the command object
                command.Parameters.Add(parameter);

                // Create a new OracleDataAdapter object with the command object
                OracleDataAdapter adapter = new OracleDataAdapter(command);

                // Create a new DataTable object
                DataTable auctionTable = new DataTable();

                // Fill the DataTable with data from the adapter
                adapter.Fill(auctionTable);

                // Set the DataSource property of the DataGridView to the DataTable
                dataGridView1.DataSource = auctionTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
