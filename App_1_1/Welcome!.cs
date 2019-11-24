using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Form1 f1 = new Form1();
            f3.Show();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Registration f3 = new Registration();
            Form1 f1 = new Form1();
            f3.Show();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
