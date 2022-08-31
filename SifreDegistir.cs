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

namespace AKIS
{
    public partial class SifreDegistir : Form
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        public static string sqlcon = @"Data Source=LAPTOP-NCDFA6OH\SQLEXPRESS;Initial Catalog=202325011;Integrated Security=True";
        int sonuc = 0;
        public SifreDegistir()
        {
            InitializeComponent();
        }
        public void captchOlustur() 
        {
            Random r = new Random();
            int ilk = r.Next(0, 50);
            int iki = r.Next(0, 50);
            sonuc = ilk + iki;
            label_captcha.Text = ilk.ToString() + " + " + iki.ToString() + " = ";
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            captchOlustur();
        }
        public void eskiSifre()
        {
            label_hata.Text = " ";
            string sorgu ="select * from tbl_login where kullanici=@user and sifre=@pass";
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", Veritabani.kullanicimSession);
            cmd.Parameters.AddWithValue("@pass",Veritabani.Md5Sifre(textBox_eSifre.Text));
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                string sql = "update tbl_login  set sifre='"+Veritabani.Md5Sifre(textBox_ySifre.Text)+ "' where kullanici=@user";
                Veritabani.KomutYolla(sql);
            }
            else 
            {
                label_hata.Text = "Eski şifrenizi hatalı girdiniz!";    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_captcha.Text == sonuc.ToString()) 
            {
                if (textBox_ySifre.Text == textBox_ySifreT.Text) 
                {
                    eskiSifre();
                    this.Close();
                }
                else
                {
                    label_hata.Text = "Yeni şifreniz ve tekrarı aynı değil!";
                }
            }
            else
            {
                label_hata.Text = "Captcha hatalı!";
                captchOlustur();

            }
            textBox_eSifre.Clear();
            textBox_ySifre.Clear();
            textBox_ySifreT.Clear();
            textBox_captcha.Clear();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
