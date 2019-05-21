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
    public partial class DersleriListele : Form
    {
        private List<Ders> dersler;
        public DersleriListele()
        {
            InitializeComponent();
        }

        private void DersleriListele_Load(object sender, EventArgs e)
        {
            dersler = new List<Ders>();
            dersler.Add(new Ders() { DersId = "1", DersAdi = "Matematik"});
            dersler.Add(new Ders() { DersId = "2", DersAdi = "Fizik" });
            dersler.Add(new Ders() { DersId = "3", DersAdi = "Türkçe" });
            dersler.Add(new Ders() { DersId = "4", DersAdi = "Biyoloji" });
            grd_Ders.DataSource = dersler;
        }
    }
}
