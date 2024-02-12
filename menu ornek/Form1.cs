using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenciekle ogrenciekle = new Ogrenciekle();
            ogrenciekle.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitapekle kitapekle = new Kitapekle();
            kitapekle.ShowDialog();
        }

        private void kitapTeslimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitapteslim kitapteslim = new Kitapteslim();
            kitapteslim.ShowDialog();
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Yellow;
        }

        private void arkaPlanAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görünüm Ayarlarına Tıklandı");
        }
    }
}
