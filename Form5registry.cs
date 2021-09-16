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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 Openform = new Form3();
            Openform.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Openform = new Form4();
            Openform.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            REGIRY ob = new REGIRY();
            ob.from = textBox1.Text;
            ob.till = textBox2.Text;
            ob.model = textBox3.Text;
            ob.registerno = int.Parse(textBox4.Text);
            ob.cnic = int.Parse(textBox5.Text);
            ob.lino = int.Parse(textBox6.Text);
            ob.rrno = int.Parse(textBox7.Text);
            ob.name = textBox8.Text;
        
            MessageBox.Show("FROM:" + ob.from + "\nTILL is :" + ob.till + "\nMODELNAME" + ob.model + "\nREGISTERNUMBER :" + ob.registerno +"\n CUSTOMER NAME  :"+ob.name+ "\nCUSTOMERCNIC :" + ob.CUSTOMERCNIC + "\nLICENSENUUMBER :" + ob.lino + "\nRENTALREGITRATIONNUMVBER:" + ob.rrno);
            ob.AddRegistry();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            REGIRY ob = new REGIRY();
            ob.registerno = int.Parse(textBox4.Text);
            ob.RemoveRegistry();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-FNAGGFI\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM REGISTRYDATA", sqlcon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
            }
        }


    }
}
