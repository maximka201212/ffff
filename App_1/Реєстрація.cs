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
    public partial class Реєстрація : Form
    {
        public Реєстрація()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f3 = new Меню();
            Реєстрація f2 = new Реєстрація();
            f3.Show();
            f2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Реєстрація f2 = new Реєстрація();
            Form1 f1 = new Form1();
            f1.Show();
            f2.Close();
        }
    }
}
