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
    public partial class Inspection : Form
    {
        public Inspection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Details f2 = new Details();
            Inspection f1 = new Inspection();
            f2.Show();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Details f2 = new Details();
            Inspection f1 = new Inspection();
            f2.Show();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Details f2 = new Details();
            Inspection f1 = new Inspection();
            f2.Show();
            f1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Details f2 = new Details();
            Inspection f1 = new Inspection();
            f2.Show();
            f1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f2 = new Menu();
            Inspection f1 = new Inspection();
            f2.Show();
            f1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f2 = new Form1();
            Inspection f1 = new Inspection();
            f2.Show();
            f1.Close();
        }

        private void Inspection_Load(object sender, EventArgs e)
        {

        }
    }
}
