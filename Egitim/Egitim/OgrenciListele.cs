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
    public partial class OgrenciListele : Form
    {

        OgrenciDuzenle frmDuzenle = new OgrenciDuzenle();
        private List<Ogrenci> ogrenciler;
        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            
            ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci() { OgrenciId = "1",Ad = "Ayhan", Soyad = "Guney", Email = "a@a.com", Telefon = "34765435"  });
            ogrenciler.Add(new Ogrenci() { OgrenciId = "2", Ad = "Talha", Soyad = "Ucar", Email = "t@t.com", Telefon = "8374653478" });
            ogrenciler.Add(new Ogrenci() { OgrenciId = "3", Ad = "Serhan", Soyad = "Akuzum", Email = "s@s.com", Telefon = "3465736543" });
            ogrenciler.Add(new Ogrenci() { OgrenciId = "4", Ad = "Selin", Soyad = "Muntas", Email = "s@selin.com", Telefon = "8346587456" });
            grd_Ogrenci.DataSource = ogrenciler;


        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OgrenciDuzenle frmDuzenle = new OgrenciDuzenle();
            ogrenciler.Where(x => x.OgrenciId == grd_Ogrenci.SelectedRows[0].Cells[0].Value.ToString()).SingleOrDefault();

            frmDuzenle.Show();

        }
    }
}
