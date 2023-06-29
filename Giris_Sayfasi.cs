using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class Giris_Sayfasi : Form
    {
        public Giris_Sayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci_Kayit kayit = new Ogrenci_Kayit();
            kayit.Show();
            this.Hide();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            Ogrenci_Girisi giris = new Ogrenci_Girisi();
            giris.Show();
            this.Hide();
        }

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            Ogretmen_Girisi ogrtgiris = new Ogretmen_Girisi();
            ogrtgiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretmen_Kayit kayit2 = new Ogretmen_Kayit();
            kayit2.Show();
            this.Hide();
        }
    }
}
