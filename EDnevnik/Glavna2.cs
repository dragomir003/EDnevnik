using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e) => new Raspodela().Show();

        private void oceneToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Nema jos");

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Nema jos");

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e) => new Osoba().Show();

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e) => new Sifarnik("smer").Show();

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e) => new Sifarnik("skolska_godina").Show();

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e) => new Sifarnik("predmet").Show();
    }
}
