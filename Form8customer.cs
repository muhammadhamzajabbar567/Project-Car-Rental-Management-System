using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 Openform = new Form3();
            Openform.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer ob = new customer();
            ob.name=textBox1.Text;
            ob.cnic=int.Parse(textBox2.Text);
            ob.phoneno=int.Parse(textBox3.Text);
            ob.liscenseno=int.Parse(textBox4.Text);
            MessageBox.Show("Your Name is :" + ob.name + "\n Your Cnic is:" + ob.cnic + "\n Your Phone Number is:" + ob.phoneno + "\n Your Liscense number is : " + ob.liscenseno);
            ob.AddCustomer();       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer ob = new customer();
            ob.name = textBox1.Text;
            ob.RemoveCustomer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer ob = new customer();
            ob.AssignCar();
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-FNAGGFI\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CUSTOMERDATA", sqlcon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;


            }
        }
    }
}
