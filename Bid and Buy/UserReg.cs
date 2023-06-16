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
    public partial class SellerReg : Form
    {
        public SellerReg()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM; PASSWORD=valli;";
            // change YOUR_ORACLE_DB, YOUR_USERNAME, and YOUR_PASSWORD with your own values

            OracleConnection conn = new OracleConnection(connString);
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn.Open();

                
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO seller(seller_id, password, email_id, lname,fname, address, pincode, phone_no)"+  
                             "VALUES(:seller_id, :password, :email, :lname,:fname, :address, :pincode, :phone)";

                // get input from text boxes
                int seller_id = int.Parse(textBox2.Text);
                string password = textBox9.Text;
                string email = textBox7.Text;
                string fname = textBox3.Text;
                string lname = textBox4.Text;
                string address = textBox5.Text;
                int pincode = int.Parse(textBox6.Text);
                string phone = textBox8.Text;

                

                // add parameters to the SQL statement
                cmd.Parameters.Add("seller_id", OracleDbType.Int32).Value = seller_id;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                cmd.Parameters.Add("lname", OracleDbType.Varchar2).Value = lname;
                cmd.Parameters.Add("fname", OracleDbType.Varchar2).Value = fname;
                cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                cmd.Parameters.Add("pincode", OracleDbType.Int32).Value = pincode;
                cmd.Parameters.Add("phone", OracleDbType.Varchar2).Value = phone;


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Dispose();
                this.Hide();
                SellerLogin frm = new SellerLogin();
                frm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        

        
    }
}
