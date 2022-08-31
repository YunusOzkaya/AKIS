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
    public partial class PersonelYazdirSayfa : Form
    {
        public PersonelYazdirSayfa()
        {
            InitializeComponent();
        }
        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;

        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(Veritabani.sqlcon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            PersonelListe1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = PersonelListe1;
            con.Close();

        }
        private void PersonelYazdir_Load(object sender, EventArgs e)
        {
            RaporDoldur("select * from tbl_personel");
        }

        private void PersonelListe1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
