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
using System.Diagnostics;
using System.IO;

namespace BidandBuy
{
    public partial class SellerItemSell : Form
    {
        int x;
        public SellerItemSell()
        {
            
            InitializeComponent();
        }

        private void SellerItemSell_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = textBox4.Text;
                byte[] imageBytes = File.ReadAllBytes(ImagePath);

                using (OracleConnection connection = new OracleConnection("DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM; PASSWORD= valli;"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a Oracle command to insert the image data into the database
                    OracleCommand command = new OracleCommand("INSERT INTO images (image_id,image_data) VALUES (:ID,:ImageData)", connection);

                    // Add the image data as a parameter to the command
                    OracleParameter parameter2 = new OracleParameter(":ID", OracleDbType.Int32);
                    parameter2.Value = int.Parse(textBox8.Text);
                    command.Parameters.Add(parameter2);
                    OracleParameter parameter = new OracleParameter(":ImageData", OracleDbType.Blob);
                    parameter.Value = imageBytes;
                    command.Parameters.Add(parameter);




                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                var frame = st.GetFrame(0);
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error:" + ex.Message + " at line: " + line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM; PASSWORD = valli;"))
            {
                // Open the connection
                connection.Open();

                // Start a new transaction


                try
                {



                    // Insert the item data into the Items table
                    OracleCommand itemCommand = new OracleCommand("INSERT INTO items (item_no,title, description ,image_id,starting_bid,seller_id,cat_id) VALUES (:ID,:ItemTitle, :ItemDesc, :ImageId,:startBid,:seller,:catid)", connection);
                    itemCommand.Parameters.Add(":ID", OracleDbType.Int32).Value = int.Parse(textBox7.Text);
                    itemCommand.Parameters.Add(":ItemTitle", OracleDbType.Varchar2).Value = textBox1.Text;
                    itemCommand.Parameters.Add(":ItemDesc", OracleDbType.Varchar2).Value = textBox2.Text;
                    itemCommand.Parameters.Add(":ImageId", OracleDbType.Int32).Value = int.Parse(textBox8.Text);
                    itemCommand.Parameters.Add(":startBid", OracleDbType.Int32).Value = int.Parse(textBox3.Text);

                    itemCommand.Parameters.Add(":seller", OracleDbType.Int32).Value = int.Parse(textBox6.Text);
                    itemCommand.Parameters.Add(":catid", OracleDbType.Int32).Value = int.Parse(textBox5.Text);
                    itemCommand.ExecuteNonQuery();

                    // Commit the transaction


                    MessageBox.Show("Item and image data uploaded successfully. The auction results will be available shortly.");
                }
                catch (Exception ex)
                {
                    var st = new StackTrace(ex, true);
                    var frame = st.GetFrame(0);
                    var line = frame.GetFileLineNumber();
                    MessageBox.Show("Error:" + ex.Message + " at line: " + line);
                }
                finally
                {
                    this.Hide();
                    Seller_Results frm = new Seller_Results();
                    frm.Show();
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
