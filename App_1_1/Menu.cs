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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Passenger_cars f1 = new Passenger_cars();
            f1.Show();
            f3.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Bus f1 = new Bus();
            f1.Show();
            f3.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Electric_cars f1 = new Electric_cars();
            f1.Show();
            f3.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Settings f1 = new Settings();
            f1.Show();
            f3.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f3 = new Menu();
            Form1 f1 = new Form1();
            f1.Show();
            f3.Close();
        }
    }
}
