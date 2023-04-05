using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {  
                FileStream fs = new FileStream(@"D:\product20demos\proBinary.dat", FileMode.Create, FileAccess.Write);
                Product pro = new Product();
                pro.Id = Convert.ToInt32(txtProductId.Text);
                pro.Name = txtProductName.Text;
                pro.Price = Convert.ToInt32(txtProductPrice.Text);
                pro.Size = txtProductSize.Text;
                pro.Price = Convert.ToInt32(txtProductPrice.Text);

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, pro);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\product20demos\proBinary.dat", FileMode.Open, FileAccess.Read);
                Product pro = new Product();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                pro = (Product)binaryFormatter.Deserialize(fs);
                txtProductId.Text =pro.Id.ToString();
                txtProductName.Text = pro.Name;
                txtProductPrice.Text = pro.Price.ToString();
                txtProductSize.Text = pro.Size;
                txtProductQuantity.Text = pro.Quantity.ToString();

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
