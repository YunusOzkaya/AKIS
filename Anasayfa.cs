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
    public partial class Anasayfa : Form
    {


        public Anasayfa()
        {
            InitializeComponent();
        }



        private void excelEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personeliListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListele a = new PersonelListele();
            a.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            dateTimePicker3.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            dateTimePicker4.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
        }

        private void Anasayfa_Load_1(object sender, EventArgs e)
        {
            Veritabani.GridDoldur(dataGridView1, "tbl_personel");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Veritabani.personelEkle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, comboBox2.Text, dateTimePicker1.Value, textBox8.Text, dateTimePicker2.Value, textBox9.Text, comboBox1.Text, dateTimePicker3.Value, dateTimePicker4.Value);
            Veritabani.GridDoldur(dataGridView1, "tbl_personel");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veritabani.personelSil(textBox1.Text);
            Veritabani.GridDoldur(dataGridView1, "tbl_personel");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani.personelGuncelle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, comboBox2.Text, dateTimePicker1.Value, textBox8.Text, dateTimePicker2.Value, textBox9.Text, comboBox1.Text, dateTimePicker3.Value);
            Veritabani.GridDoldur(dataGridView1, "tbl_personel");
        }

        private void şifreDeğiştirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SifreDegistir a = new SifreDegistir();
            a.ShowDialog();
        }

        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListele a = new PersonelListele();
            a.Show();
            this.Close();
        }
    }
}
