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
    public partial class Ogretmen_Sayfasi : Form
    {
        public Ogretmen_Sayfasi()
        {
            InitializeComponent();
        }

        baglanti_sql connect = new baglanti_sql();

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DataTable dat = new DataTable();
            SqlDataAdapter dpt = new SqlDataAdapter("select * from tbl_ogretmenler", connect.connect());
            dpt.Fill(dat);
            Ogretmenler.DataSource = dat;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from tbl_ogretmenler where ogrtno = @ogrtno", connect.connect());
            kmt.Parameters.AddWithValue("@ogrtno", txtOgrtNo.Text);
            kmt.ExecuteNonQuery();
            connect.connect().Close();
            MessageBox.Show("Öğretmen silindi.");

            txtOgrtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbBrans.Text = "";
            txtYas.Text = "";

            DataTable dat = new DataTable();
            SqlDataAdapter dpt = new SqlDataAdapter("select * from tbl_ogretmenler", connect.connect());
            dpt.Fill(dat);
            Ogretmenler.DataSource = dat;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Ogretmen_Girisi don = new Ogretmen_Girisi();
            don.Show();
            this.Hide();
        }

        private void Ogretmenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = Ogretmenler.SelectedCells[0].RowIndex;
            txtOgrtNo.Text = Ogretmenler.Rows[choose].Cells[1].Value.ToString();
            txtAd.Text = Ogretmenler.Rows[choose].Cells[2].Value.ToString();
            txtSoyad.Text = Ogretmenler.Rows[choose].Cells[3].Value.ToString();
            cbBrans.Text = Ogretmenler.Rows[choose].Cells[4].Value.ToString();
            txtYas.Text = Ogretmenler.Rows[choose].Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update tbl_ogretmenler set ogrtno = @ogrtno, ogrtad = @ogrtad, ogrtsoyad = @ogrtsoyad, ogrtbrans = @ogrtbrans, ogrtyas = @ogrtyas where ogrtno = @ogrtno", connect.connect());
            kmt.Parameters.AddWithValue("@ogrtno", txtOgrtNo.Text);
            kmt.Parameters.AddWithValue("@ogrtad", txtAd.Text);
            kmt.Parameters.AddWithValue("@ogrtsoyad", txtSoyad.Text);
            kmt.Parameters.AddWithValue("@ogrtbrans", cbBrans.Text);
            kmt.Parameters.AddWithValue("@ogrtyas", txtYas.Text);
            kmt.ExecuteNonQuery();
            connect.connect().Close();
            MessageBox.Show("Öğretmen güncellendi.");

            txtOgrtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbBrans.Text = "";
            txtYas.Text = "";

            DataTable dat = new DataTable();
            SqlDataAdapter dpt = new SqlDataAdapter("select * from tbl_ogretmenler", connect.connect());
            dpt.Fill(dat);
            Ogretmenler.DataSource = dat;
        }
    }
}
