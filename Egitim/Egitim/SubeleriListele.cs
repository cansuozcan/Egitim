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
    public partial class SubeleriListele : Form
    {
        private List<Sube> subeler;
        public SubeleriListele()
        {
            InitializeComponent();
        }

        private void SubeleriListele_Load(object sender, EventArgs e)
        {
            subeler = new List<Sube>();
            subeler.Add(new Sube() { Adres = "Mecidiyekoy" });
            subeler.Add(new Sube() { Adres = "Umraniye" });
            subeler.Add(new Sube() { Adres = "Bakırkoy" });
            subeler.Add(new Sube() { Adres = "Kadikoy" });
            grd_Sube.DataSource = subeler;
        }
    }
}
