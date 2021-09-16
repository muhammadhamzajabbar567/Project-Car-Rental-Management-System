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
    public partial class Form7 : Form
    {
       
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form3 Openform = new Form3();
            Openform.Show();
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
          
            CAR ob = new CAR();

            ob.reg = int.Parse(textBox1.Text);
            ob.model = textBox2.Text;
            ob.comp = textBox3.Text;
            ob.capci = int.Parse(textBox4.Text);

            MessageBox.Show("Car Reg no is:" + ob.reg + "\nCar Model is :" + ob.model + "\nCar Company is" + ob.comp + "\nCar Capcity is :" + ob.capci);
            ob.AddCar();       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAR obj = new CAR();
            obj.reg = int.Parse(textBox1.Text);
            obj.RemoveCar();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            CAR ob = new CAR();
            ob.BookCar();
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-FNAGGFI\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CARDATA", sqlcon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;


            }

            
        }

       
    }
}
