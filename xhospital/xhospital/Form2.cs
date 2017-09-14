using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xhospital
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Qeydiyyat Ugurla Basa Catdi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox5.Items.Add(textBox1.Text);
            comboBox7.Items.Add(textBox2.Text);
        }
    }
}
