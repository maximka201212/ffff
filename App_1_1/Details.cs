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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Pay f2 = new Pay();
            Details f1 = new Details();
            f2.Show();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f2 = new Menu();
            Details f1 = new Details();
            f2.Show();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f2 = new Form1();
            Details f1 = new Details();
            f2.Show();
            f1.Close();
        }
    }
}
