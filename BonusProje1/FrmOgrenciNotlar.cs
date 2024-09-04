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

namespace BonusProje1
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection connection=new SqlConnection(@"Data Source=DESKTOP-PV3GPLC;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select DersAdi,Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum From Tbl_Notlar Inner Join Tbl_Dersler On Tbl_Notlar.DersId = Tbl_Dersler.DersId where OgrId=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", numara);
            //this.Text=numara.ToString();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
