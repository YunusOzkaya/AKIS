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
    public partial class RaporGoruntule : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;
        public RaporGoruntule()
        {
            InitializeComponent();
        }
        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(Veritabani.sqlcon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            LoginRaporu2.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = LoginRaporu2;
            con.Close();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void RaporGoruntule_Load(object sender, EventArgs e)
        {
            RaporDoldur("select * from tbl_login");
        }
    }
}
