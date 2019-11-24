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
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pay f3 = new Pay();
            Success f1 = new Success();
            f1.Show();
            f3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Pay f1 = new Pay();
            f3.Show();
            f1.Close();
        }
    }
}
