using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Slip ob = new Slip();
            ob.RentalRegistryNumber = int.Parse(textBox4.Text);
            ob.Amount = int.Parse(textBox3.Text);
            ob.GenerateBill();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 Openform = new Form3();
            Openform.Show();
            Close();
        }
    }
}
