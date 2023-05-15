using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace StreamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\jsonFile.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtId.Text);
                emp.EmpName = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtEmpSalary.Clear();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBserializeWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\binaryFile.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtId.Text);
                emp.EmpName = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtEmpSalary.Clear();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBserializeRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\binaryFile.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                txtEmpId.Text = emp.EmpId.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSalary.Text = emp.Salary.ToString();

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\xmlFile.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtId.Text);
                emp.EmpName = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                xmlSerializer.Serialize(fs, emp);
                fs.Close();
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtEmpSalary.Clear();
                MessageBox.Show("Done");
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
                FileStream fs = new FileStream(@"D:\TestDirectory1\xmlFile.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                emp = (Employee)xmlSerializer.Deserialize(fs);
                txtId.Text = emp.EmpId.ToString();
                txtName.Text = emp.EmpName;
                txtSalary.Text = emp.Salary.ToString();

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\soapFile.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtId.Text);
                emp.EmpName = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtEmpSalary.Clear();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\soapFile.soap", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                txtId.Text = emp.EmpId.ToString();
                txtName.Text = emp.EmpName;
                txtSalary.Text = emp.Salary.ToString();

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestDirectory1\jsonFile.json", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                emp = JsonSerializer.Deserialize<Employee>(fs);
                txtEmpId.Text = emp.EmpId.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSalary.Text = emp.Salary.ToString();

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

