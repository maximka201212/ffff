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
    public partial class Change_login : Form
    {
        public Change_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Change_success f3 = new Change_success();
            Change_login f1 = new Change_login();
            f3.Show();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Settings f3 = new Settings();
            Change_login f1 = new Change_login();
            f3.Show();
            f1.Close();
        }
    }
}
