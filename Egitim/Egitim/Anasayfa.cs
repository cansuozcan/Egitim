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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListele frm = new OgrenciListele();
            frm.Show();
        }

        private void dersleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersleriListele frm = new DersleriListele();

            frm.Show();
        }

        private void şubeleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubeleriListele frm = new SubeleriListele();
            frm.Show();
        }

        private void ögrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkleme ogrekle = new OgrenciEkleme();
            ogrekle.Show();
        }
    }
}
