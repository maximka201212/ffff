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
    public partial class Change_E_mail : Form
    {
        public Change_E_mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Change_E_mail f3 = new Change_E_mail();
            Change_success f1 = new Change_success();
            f1.Show();
            f3.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Change_E_mail f3 = new Change_E_mail();
            Settings f1 = new Settings();
            f1.Show();
            f3.Close();
        }
    }
}
