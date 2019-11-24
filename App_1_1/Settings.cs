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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Change_login f2 = new Change_login();
            Settings f1 = new Settings();
            f2.Show();
            f1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Change_E_mail f2 = new Change_E_mail();
            Settings f1 = new Settings();
            f2.Show();
            f1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Change_password f2 = new Change_password();
            Settings f1 = new Settings();
            f2.Show();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Change_payment_info f2 = new Change_payment_info();
            Settings f1 = new Settings();
            f2.Show();
            f1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f2 = new Menu();
            Settings f1 = new Settings();
            f2.Show();
            f1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f2 = new Form1();
            Settings f1 = new Settings();
            f2.Show();
            f1.Close();
        }
    }
}
