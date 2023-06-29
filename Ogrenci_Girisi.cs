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
    public partial class Ogrenci_Girisi : Form
    {
        public Ogrenci_Girisi()
        {
            InitializeComponent();
        }

        baglanti_sql connect = new baglanti_sql();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from tbl_ogrenciler where ogrno = @ogrno", connect.connect());
            kmt.Parameters.AddWithValue("@ogrno", txtOgrNo.Text);
            SqlDataReader dtr = kmt.ExecuteReader();
            if (dtr.Read())
            {
                Ogrenci_Sayfasi sayfa = new Ogrenci_Sayfasi();
                sayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı öğrenci numarası girdiniz.");
            }
            connect.connect().Close();
        }

        private void Ogrenci_Girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris_Sayfasi giris = new Giris_Sayfasi();
            giris.Show();
        }
    }
}
