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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            lblUser.Text = string.Format("{0} {1}", Program.Ime, Program.Prezime);
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba formOsoba = new Osoba();

            formOsoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
