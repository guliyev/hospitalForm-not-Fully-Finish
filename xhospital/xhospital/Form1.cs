using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace xhospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var baglanticumlesi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\p102\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection bagla = new SqlConnection(baglanticumlesi);
            bagla.Open();
            var sqlEmr = "select * from Login";
            SqlCommand cmd = new SqlCommand(sqlEmr, bagla);
            cmd.ExecuteNonQuery();
            var adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);

            var istifadeciAdi = textBox1.Text;
            var istifadeciParol = textBox2.Text;

            if (istifadeciAdi == "admin" && istifadeciParol == "admin")
            {
                Form2 yeniform = new Form2();
                this.Hide();
                yeniform.Show();
            }
            else

            {
                MessageBox.Show("reujgtpuo");
            }
           
            
        }
    }
}
