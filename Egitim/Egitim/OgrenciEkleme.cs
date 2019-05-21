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
    public partial class OgrenciEkleme : Form
    {
        private List<Ogrenci> ogrenciler;
        Ogrenci yeniogrenciler = new Ogrenci();
        public OgrenciEkleme()
        {
            InitializeComponent();
        }

        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_yeniKayıt_Click(object sender, EventArgs e)
        {
            yeniogrenciler.Ad = txt_yeniogrAd.Text;
            yeniogrenciler.Soyad = txt_yeniogrSoyad.Text;
            yeniogrenciler.Email = txt_yeniogrEmail.Text;
            yeniogrenciler.Telefon = txt_yeniogrTel.Text;
            ogrenciler.Add(yeniogrenciler);
            this.Close();
        }

    }
}
