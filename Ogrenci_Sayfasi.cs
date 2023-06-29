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

namespace OkulSistemi
{
    public partial class Ogrenci_Sayfasi : Form
    {
        public Ogrenci_Sayfasi()
        {
            InitializeComponent();
        }

        baglanti_sql connect = new baglanti_sql();

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            SqlDataAdapter dtp = new SqlDataAdapter("select * from tbl_ogrenciler", connect.connect());
            dtp.Fill(data);
            Ogrenciler.DataSource = data;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update tbl_ogrenciler set ogrno = @ogrno, ograd = @ograd, ogrsoyad = @ogrsoyad, ogrbolum = @ogrbolum, ogryas = @ogryas where ogrno = @ogrno", connect.connect());
            kmt.Parameters.AddWithValue("@ogrno", txtOgrNo.Text);
            kmt.Parameters.AddWithValue("@ograd", txtAd.Text);
            kmt.Parameters.AddWithValue("@ogrsoyad", txtSoyad.Text);
            kmt.Parameters.AddWithValue("@ogrbolum", cbBolum.Text);
            kmt.Parameters.AddWithValue("@ogryas", txtYas.Text);
            kmt.ExecuteNonQuery();
            connect.connect().Close();
            MessageBox.Show("Öğrenci güncellendi.");

            txtOgrNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbBolum.Text = "";
            txtYas.Text = "";

            DataTable data = new DataTable();
            SqlDataAdapter dtp = new SqlDataAdapter("select * from tbl_ogrenciler", connect.connect());
            dtp.Fill(data);
            Ogrenciler.DataSource = data;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from tbl_ogrenciler where ogrno = @ogrno", connect.connect());
            kmt.Parameters.AddWithValue("@ogrno", txtOgrNo.Text);
            kmt.ExecuteNonQuery();
            connect.connect().Close();
            MessageBox.Show("Öğrenci silindi.");

            txtOgrNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbBolum.Text = "";
            txtYas.Text = "";

            DataTable data = new DataTable();
            SqlDataAdapter dtp = new SqlDataAdapter("select * from tbl_ogrenciler", connect.connect());
            dtp.Fill(data);
            Ogrenciler.DataSource = data;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Ogrenci_Girisi gir = new Ogrenci_Girisi();
            gir.Show();
            this.Hide();
        }

        private void Ogrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chs = Ogrenciler.SelectedCells[0].RowIndex;
            txtOgrNo.Text = Ogrenciler.Rows[chs].Cells[1].Value.ToString();
            txtAd.Text = Ogrenciler.Rows[chs].Cells[2].Value.ToString();
            txtSoyad.Text = Ogrenciler.Rows[chs].Cells[3].Value.ToString();
            cbBolum.Text = Ogrenciler.Rows[chs].Cells[4].Value.ToString();
            txtYas.Text = Ogrenciler.Rows[chs].Cells[5].Value.ToString();
        }
    }
}
