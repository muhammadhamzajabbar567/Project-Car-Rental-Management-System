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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 Openform = new Form6();
            Openform.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Openform = new Form1();
            Close();
            
        }
    }
}
