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
    public partial class BuyerHomePage : Form
    {
        public BuyerHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing controls in the panel
            BuyerInfo frm1 = new BuyerInfo(); // Create a new instance of the Form2 class
            frm1.TopLevel = false; // Set the TopLevel property of the form to false
            frm1.FormBorderStyle = FormBorderStyle.None; // Set the FormBorderStyle property of the form to None
            frm1.Dock = DockStyle.Fill; // Set the Dock property of the form to Fill
            panel3.Controls.Add(frm1); // Add the form to the panel
            frm1.Show(); // Show the form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing controls in the panel
            BuyerItems frm2= new BuyerItems(); // Create a new instance of the Form3 class
            frm2.TopLevel = false; // Set the TopLevel property of the form to false
            frm2.FormBorderStyle = FormBorderStyle.None; // Set the FormBorderStyle property of the form to None
            frm2.Dock = DockStyle.Fill; // Set the Dock property of the form to Fill
            panel3.Controls.Add(frm2); // Add the form to the panel
            frm2.Show(); // Show the form
        }

    }
}
