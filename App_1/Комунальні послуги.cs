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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            {
                Hide();
                Оплата f5 = new Оплата();
                Form7 f7 = new Form7();
                f5.Show();
                f7.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Меню f3 = new Меню();
            Form7 f7 = new Form7();
            f3.Show();
            f7.Close();
        }

        private void listOfServices1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listOfServices1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicesDataSet);
            this.listOfServices1TableAdapter.Fill(this.servicesDataSet.ListOfServices1);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servicesDataSet.ListOfServices1". При необходимости она может быть перемещена или удалена.
            this.listOfServices1TableAdapter.Fill(this.servicesDataSet.ListOfServices1);

        }
    }
}
