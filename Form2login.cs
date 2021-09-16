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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User ob = new User();
            ob.Username = textBox1.Text;
            ob.password = textBox2.Text;

            ob.LogIn();

            Form3 Openform = new Form3();
            Openform.Show();
            Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
