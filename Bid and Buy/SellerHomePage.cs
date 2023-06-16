using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidandBuy
{
    public partial class SellerHomePage : Form
    {
        int id;
        public SellerHomePage(int x)
        {
            this.id = x;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear(); // Clear any existing controls in the panel
            SellerInfo frm1 = new SellerInfo(id);// Create a new instance of the Form2 class
            frm1.TopLevel = false;
            // Set the TopLevel property of the form to false
            frm1.AutoSize = true;
            frm1.FormBorderStyle = FormBorderStyle.None; // Set the FormBorderStyle property of the form to None
            frm1.Dock = DockStyle.Fill; // Set the Dock property of the form to Fill
            panel3.Controls.Add(frm1); // Add the form to the panel
            frm1.Show();
                    
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing controls in the panel
            sellerhistory frm1 = new sellerhistory(id);// Create a new instance of the Form2 class
            frm1.TopLevel = false;
            // Set the TopLevel property of the form to false
            frm1.AutoSize = true;
            frm1.FormBorderStyle = FormBorderStyle.None; // Set the FormBorderStyle property of the form to None
            frm1.Dock = DockStyle.Fill; // Set the Dock property of the form to Fill
            panel3.Controls.Add(frm1); // Add the form to the panel
            frm1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing controls in the panel
            SellerItemSell frm1 = new SellerItemSell();// Create a new instance of the Form2 class
            frm1.TopLevel = false;
            // Set the TopLevel property of the form to false
            frm1.AutoSize = true;
            frm1.FormBorderStyle = FormBorderStyle.None; // Set the FormBorderStyle property of the form to None
            frm1.Dock = DockStyle.Fill; // Set the Dock property of the form to Fill
            panel3.Controls.Add(frm1); // Add the form to the panel
            frm1.Show();
        }

    }
}
