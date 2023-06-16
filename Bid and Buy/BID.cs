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
using System.IO;


namespace BidandBuy
{
    public partial class BID_FORM : Form
    {

        int item_no;
        public BID_FORM()
        {
            
            
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string connectionString = "DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM;PASSWORD=valli;";
            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                connection.Open();

                int itemNo = int.Parse(textBox3.Text);
                int bidAmt = int.Parse(textBox2.Text);
                int buyerId = int.Parse(textBox1.Text);

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO bids (bid_id, bid_timestp, bid_amt, buyer_id, item_no) " +
                                      "SELECT COALESCE(MAX(bid_id), 0) + 1, SYSTIMESTAMP, :p_bid_amt, :p_buyer_id, :p_item_no " +
                                      "FROM bids " +
                                      "WHERE item_no = :p_item_no";

                command.Parameters.Add("p_item_no", OracleDbType.Int32).Value = itemNo;
                command.Parameters.Add("p_bid_amt", OracleDbType.Int32).Value = bidAmt;
                command.Parameters.Add("p_buyer_id", OracleDbType.Int32).Value = buyerId;

                int rowsInserted = command.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Bid added successfully!");
                }
                else
                {
                    MessageBox.Show("No rows were inserted.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            

        }

        private void BID_FORM_Load(object sender, EventArgs e)
        {

        }

        
    }
}
