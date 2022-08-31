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
    public partial class Login : Form

    {
        public Login()
        {
            InitializeComponent();

        } 
    
        private void Login_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            if (Veritabani.BaglantiDurum())
            {
                pictureBox1.Image = Image.FromFile(@"C:\Temp\AKİS\202523011\Akis\images\yesiltik.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Temp\AKİS\202523011\Akis\images\kirmizicarpi.png");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Veritabani.LoginKontrol(textBox1.Text, textBox2.Text))
            {
                Veritabani.KomutYolla("update tbl_login set girisTarihi='" + dateTimePicker1.Value + "' where kullanici='" + textBox1.Text + "' ");
                if (textBox1.Text == "admin" && textBox2.Text == "password")
                {
                    Admin a = new Admin();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    Anasayfa a = new Anasayfa();
                    this.Hide();
                    Veritabani.kullanicimSession = textBox1.Text;
                    a.Show();
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı...");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
