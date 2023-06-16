using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BidandBuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cONTACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin2 frm = new AdminLogin2();
            frm.Show();
        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyerLogin frm = new BuyerLogin();
            frm.Show();
        }

        private void uSERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SellerReg frm = new SellerReg();
            frm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerLogin frm = new SellerLogin();
            frm.Show();
            
        }

        private void bUYERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyerReg frm = new BuyerReg();
            frm.Show();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

       

        
    }
}
