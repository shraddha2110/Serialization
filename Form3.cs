using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;//Binary
using System.Runtime.Serialization.Formatters.Soap;//soap
using System.Xml.Serialization;//xml
using System.Text.Json;//json

namespace WindowsAppDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdBinary.dat", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtStudentRollno.Text);
                std.Name = txtStudentName.Text;
                std.Percentage = Convert.ToInt32(txtStudentPercentage.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, std);
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
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdBinary.dat", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                std = (Student)binaryFormatter.Deserialize(fs);
                txtStudentRollno.Text = std.Rollno.ToString();
                txtStudentName.Text = std.Name;
                txtStudentPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdxml.xml", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtStudentRollno.Text);
                std.Name = txtStudentName.Text;
                std.Percentage = Convert.ToInt32(txtStudentPercentage.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                xmlSerializer.Serialize(fs, std);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdxml.xml", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                std = (Student)xmlSerializer.Deserialize(fs);
                txtStudentRollno.Text = std.Rollno.ToString();
                txtStudentName.Text = std.Name;
                txtStudentPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdBinary.dat", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtStudentRollno.Text);
                std.Name = txtStudentName.Text;
                std.Percentage = Convert.ToInt32(txtStudentPercentage.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, std);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdBinary.dat", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                std = (Student)soapFormatter.Deserialize(fs);
                txtStudentRollno.Text = std.Rollno.ToString();
                txtStudentName.Text = std.Name;
                txtStudentPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdBinary.dat", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Rollno = Convert.ToInt32(txtStudentRollno.Text);
                std.Name = txtStudentName.Text;
                std.Percentage = Convert.ToInt32(txtStudentPercentage.Text);
                JsonSerializer.Serialize<Student>(fs, std);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stdBinary.dat", FileMode.Open, FileAccess.Read);
                Student std = new Student();

                std = JsonSerializer.Deserialize<Student>(fs);
                txtStudentRollno.Text = std.Rollno.ToString();
                txtStudentName.Text = std.Name;
                txtStudentPercentage.Text = std.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
