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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WEEKLYRENTALREGISTRY w=new WEEKLYRENTALREGISTRY();
             int week = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(2500);
         ;

            MessageBox.Show(" YOUR WEEKLY CHARGE IS:"+w.mul(week,amount));
        
            MessageBox.Show("YOUR CUREENT DATE IS :"+DateTime.Today.ToString());
            MessageBox.Show("YOU WILL RESTORE US OUR CAR ON THIS WEEK"+dateTimePicker1.Value.ToString());

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MONTLYRENTALREGISTRY m = new MONTLYRENTALREGISTRY();
             int month = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(5000);
          

            MessageBox.Show("YOUR MONTLY CHARGE IS :"+m.mul(month,amount));
        
            MessageBox.Show("YOUR CUREENT DATE IS :" + DateTime.Today.Month.ToString());
            MessageBox.Show("YOU WILL RESTORE US OUR CAR ON THIS MONTH" + dateTimePicker1.Value.Month.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOURLYRENTALREGISTRY hr = new HOURLYRENTALREGISTRY();
            int hours = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(1700);
           

            MessageBox.Show("AMOUNT :"+hr.mul(hours,amount));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Openform = new Form5();
            Openform.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HOURLYRENTALREGISTRY hr = new HOURLYRENTALREGISTRY();
            int hours = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(1700);
            int discount = Convert.ToInt32(2);
            MessageBox.Show("YOU GET DISCOUNT OF 2% !!! :" + hr.mul(hours, amount,discount));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WEEKLYRENTALREGISTRY w = new WEEKLYRENTALREGISTRY();
            int week = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(2500);
            int discount = Convert.ToInt32(2);
            MessageBox.Show("YOU GET DISCOUNT OF 2% !!! :" + w.mul(week, amount, discount));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MONTLYRENTALREGISTRY m = new MONTLYRENTALREGISTRY();
             int month = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(5000);
           int discount = Convert.ToInt32(2);

            MessageBox.Show("YOUR MONTLY CHARGE IS :"+m.mul(month,amount,discount));
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 Openform = new Form3();
            Openform.Show();
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        
    }
}
