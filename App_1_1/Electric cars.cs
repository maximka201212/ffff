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
    public partial class Electric_cars : Form
    {
        public Electric_cars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Repair f2 = new Repair();
            Electric_cars f1 = new Electric_cars();
            f2.Show();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Inspection f2 = new Inspection();
            Electric_cars f1 = new Electric_cars();
            f2.Show();
            f1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f2 = new Menu();
            Electric_cars f1 = new Electric_cars();
            f2.Show();
            f1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f2 = new Form1();
            Electric_cars f1 = new Electric_cars();
            f2.Show();
            f1.Close();
        }
    }
}
