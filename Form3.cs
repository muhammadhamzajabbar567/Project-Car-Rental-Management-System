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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

  
        private void button3_Click(object sender, EventArgs e)
        {
            Form9 Openform = new Form9();
            Openform.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 Openform = new Form7();
            Openform.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 Openform = new Form8();
            Openform.Show();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 Openform = new Form6();
            Openform.Show();
            Close();
        }
    }
}
