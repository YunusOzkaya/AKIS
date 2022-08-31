using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKIS
{
    public partial class Admin_Kullanici : Form
    {
        public Admin_Kullanici()
        {
            InitializeComponent();
            Veritabani.GridDoldur(dataGridView1, "tbl_login");

        }

        private void Admin_Kullanici_Load(object sender, EventArgs e)
        {

        }
              

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Veritabani.kullaniciEkle(textBox1.Text, Veritabani.Md5Sifre(textBox2.Text), DateTime.Now);
            Veritabani.GridDoldur(dataGridView1, "tbl_login");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Veritabani.kullaniciGuncelle(textBox1.Text, textBox2.Text);
            Veritabani.GridDoldur(dataGridView1, "tbl_login");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Veritabani.kullaniciSil(textBox1.Text, textBox2.Text);
            Veritabani.GridDoldur(dataGridView1, "tbl_login");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
