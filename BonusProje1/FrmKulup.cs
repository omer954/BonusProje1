using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PV3GPLC;Initial Catalog=BonusOkul;Integrated Security=True");

        public void liste()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kulupler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Tbl_Kulupler (KulupAd) values (@p1)", connection);
            cmd.Parameters.AddWithValue("@p1", TxtKulupAd.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kulüp Listeye Eklendi !!!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKulupID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete From Tbl_Kulupler Where KulupId=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", TxtKulupID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kulüp Silme İşlemi Gerçekleşti");
            liste();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Kulupler set KulupAd=@p1 where KulupId=@p2", connection);
            cmd.Parameters.AddWithValue("@p1",TxtKulupAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtKulupID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kulüp Güncelleme İşlemi Gerçekleşti");
            liste();
        }

      
    }
}
