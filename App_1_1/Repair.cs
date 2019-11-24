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
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Inspection f2 = new Inspection();
            Repair f1 = new Repair();
            f2.Show();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f2 = new Menu();
            Repair f1 = new Repair();
            f2.Show();
            f1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Repair f2 = new Repair();
            Details f1 = new Details();
            f1.Show();
            f2.Close();
        }
    }
}
