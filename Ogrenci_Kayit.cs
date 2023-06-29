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
    public partial class Ogrenci_Kayit : Form
    {
        public Ogrenci_Kayit()
        {
            InitializeComponent();
        }

        baglanti_sql connect = new baglanti_sql();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kayit = new SqlCommand("insert into tbl_ogrenciler (ogrno, ograd, ogrsoyad, ogrbolum, ogryas) values (@ogrno, @ograd, @ogrsoyad, @ogrbolum, @ogryas)", connect.connect());
            kayit.Parameters.AddWithValue("@ogrno", txtOgrNo.Text);
            kayit.Parameters.AddWithValue("@ograd", txtAd.Text);
            kayit.Parameters.AddWithValue("@ogrsoyad", txtSoyad.Text);
            kayit.Parameters.AddWithValue("@ogrbolum", cbBolum.Text);
            kayit.Parameters.AddWithValue("@ogryas", txtYas.Text);
            kayit.ExecuteNonQuery();
            connect.connect().Close();
            MessageBox.Show("Öğrenci eklendi.");

            txtOgrNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbBolum.Text = "";
            txtYas.Text = "";

            Giris_Sayfasi giris = new Giris_Sayfasi();
            giris.Show();
            this.Hide();
        }

        private void Ogrenci_Kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris_Sayfasi grs = new Giris_Sayfasi();
            grs.Show();
        }
    }
}
