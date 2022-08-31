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
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }
        string sql="";
        private void PersonelListele_Load(object sender, EventArgs e)
        {
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                sql = "select * from tbl_personel where unvan like '%" + textBox3.Text + "%'";
                Veritabani.personelGridDoldur(dataGridView1, "tbl_personel", sql);
            }
            else if (radioButton2.Checked)
            {
                sql = "select * from tbl_personel where SicilNo like '%" + textBox3.Text + "%'";
                Veritabani.personelGridDoldur(dataGridView1, "tbl_personel", sql);
            }
            else if (radioButton3.Checked)
            {
                sql = "select * from tbl_personel where isim like '%" + textBox3.Text + "%'";
                Veritabani.personelGridDoldur(dataGridView1, "tbl_personel", sql);
            }
            else if (radioButton4.Checked)
            {
                sql = "select * from tbl_personel where soyisim like '%" + textBox3.Text + "%'";
                Veritabani.personelGridDoldur(dataGridView1, "tbl_personel", sql);
            }
        }
    
        private void button1_Click_2(object sender, EventArgs e)
        {
            PersonelYazdirSayfa a = new PersonelYazdirSayfa();
            a.Show();
            this.Close();
        }
    }
}
