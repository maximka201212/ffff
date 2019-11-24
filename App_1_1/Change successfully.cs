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
    public partial class Change_success : Form
    {
        public Change_success()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Change_success f1 = new Change_success();
            Settings f2 = new Settings();
            f1.Close();
            f2.Show();
        }
    }
}
