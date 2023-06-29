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
    public partial class Ogretmen_Girisi : Form
    {
        public Ogretmen_Girisi()
        {
            InitializeComponent();
        }

        baglanti_sql connect = new baglanti_sql();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from tbl_ogretmenler where ogrtno = @ogrtno", connect.connect());
            kmt.Parameters.AddWithValue("@ogrtno", txtOgrtNo.Text);
            SqlDataReader dtr = kmt.ExecuteReader();
            if (dtr.Read())
            {
                Ogretmen_Sayfasi sayfa = new Ogretmen_Sayfasi();
                sayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı öğretmen numarası girdiniz.");
            }
            connect.connect().Close();
        }

        private void Ogretmen_Girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris_Sayfasi girissayfasi = new Giris_Sayfasi();
            girissayfasi.Show();
        }
    }
}
