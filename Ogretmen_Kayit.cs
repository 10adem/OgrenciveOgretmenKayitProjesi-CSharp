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
    public partial class Ogretmen_Kayit : Form
    {
        public Ogretmen_Kayit()
        {
            InitializeComponent();
        }

        baglanti_sql connect = new baglanti_sql();

        private void btnKayıtEt_Click(object sender, EventArgs e)
        {
            SqlCommand kayit = new SqlCommand("insert into tbl_ogretmenler (ogrtno, ogrtad, ogrtsoyad, ogrtbrans, ogrtyas) values (@ogrtno, @ogrtad, @ogrtsoyad, @ogrtbrans, @ogrtyas)", connect.connect());
            kayit.Parameters.AddWithValue("@ogrtno", txtOgrtNo.Text);
            kayit.Parameters.AddWithValue("@ogrtad", txtAd.Text);
            kayit.Parameters.AddWithValue("@ogrtsoyad", txtSoyad.Text);
            kayit.Parameters.AddWithValue("@ogrtbrans", cbBrans.Text);
            kayit.Parameters.AddWithValue("@ogrtyas", txtYas.Text);
            kayit.ExecuteNonQuery();
            connect.connect().Close();
            MessageBox.Show("Öğretmen eklendi.");

            txtOgrtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbBrans.Text = "";
            txtYas.Text = "";

            Giris_Sayfasi giris = new Giris_Sayfasi();
            giris.Show();
            this.Hide();
        }

        private void Ogretmen_Kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris_Sayfasi syf = new Giris_Sayfasi();
            syf.Show();
        }
    }
}
