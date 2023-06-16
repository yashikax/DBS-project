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
    public partial class BuyerItems : Form
    {
        public BuyerItems()
        {
            
            try
            {
                string connectionString = "DATA SOURCE=LAPTOP-SU9TV0QJ:1521/xe;PERSIST SECURITY INFO=True;USER ID=SYSTEM;PASSWORD=valli;";
                OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();

                string query = "SELECT items.title, images.image_data,items.item_no FROM items INNER JOIN images ON items.image_id = images.image_id";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataReader reader = command.ExecuteReader();

                List<string> itemNames = new List<string>();
                List<Image> itemImages = new List<Image>();
                List<int> ids = new List<int>();


                while (reader.Read())
                {
                    itemNames.Add(reader.GetString(0));
                    byte[] imageData = (byte[])reader.GetValue(1);
                    if (imageData != null)
                    {
                        MemoryStream ms = new MemoryStream(imageData);
                        Image image = Image.FromStream(ms);
                        itemImages.Add(image);
                    }
                    else
                    {
                        itemImages.Add(null);
                    }
                    ids.Add(reader.GetInt32(2));
                }

                reader.Close();

                FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
                flowLayoutPanel1.Dock = DockStyle.Fill;
                flowLayoutPanel1.AutoSize = true;
                this.Controls.Add(flowLayoutPanel1);

                for (int i = 0; i < itemImages.Count; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 150;
                    pictureBox.Height = 150;
                    pictureBox.Image = itemImages[i];
                    pictureBox.Tag = ids[i];
                    int temp = ids[i];

                    Label label = new Label();
                    label.Text = itemNames[i];
                    label.TextAlign = ContentAlignment.MiddleCenter;

                    Button b = new Button();
                    b.Text = "BID";
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Anchor = AnchorStyles.Bottom;
                    b.Show();

                    Label label2 = new Label();
                    label2.Text = ids[i].ToString();
                    label.TextAlign = ContentAlignment.MiddleRight;

                    try
                    {
                        b.Click += (sender, e) =>
                        {
                            // Code to handle the button click event
                            BID_FORM frm3 = new BID_FORM();
                            frm3.Show();
                            
                        };
                    }
                    catch (System.Exception ex)
                    {
                        // Handle the exception by displaying an error message to the user
                        MessageBox.Show("An argument out of range exception occurred: " + ex.Message);
                    }

                    flowLayoutPanel1.Controls.Add(pictureBox);
                    flowLayoutPanel1.Controls.Add(label);
                    flowLayoutPanel1.Controls.Add(label2);
                    flowLayoutPanel1.Controls.Add(b);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            InitializeComponent();
        }

        private void BuyerItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
