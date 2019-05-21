using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitim
{
    public partial class OgrenciDuzenle : Form
    {
        public Anasayfa anasayfa;

        public OgrenciDuzenle()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            txt_ogrAd.Text = ogrenci.Ad;
            txt_ogrSoyad.Text = ogrenci.Soyad;
            txt_ogrEmail.Text = ogrenci.Email;
            txt_ogrTel.Text = ogrenci.Telefon;
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
