using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Оплата : Form
    {
        public Оплата()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Hide();
                Оплата f5 = new Оплата();
                Успіх f2 = new Успіх();
                f2.Show();
                f5.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Hide();
                Form1 f1 = new Form1();
                Меню f3 = new Меню();
                f1.Show();
                f3.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



