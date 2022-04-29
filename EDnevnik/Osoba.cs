using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Osoba : Form
    {
        SqlConnection conn;

        DataTable osobe;

        int aktivniIndeks;

        public Osoba()
        {
            InitializeComponent();
            aktivniIndeks = 0;
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.AppSettings["dbConnString"]);

            PokupiOsobe();

            if (osobe.Rows.Count != 0)
            {
                PrikaziOsobu();
                return;
            }

            MessageBox.Show("Nema nikakvih podataka u bazi.");
            foreach (var ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    var btn = (Button)ctrl;
                    btn.Enabled = false;
                }
            }

        }

        private void PokupiOsobe()
        {
            osobe = new DataTable();
            var adapter = new SqlDataAdapter("select * from osoba;", conn);
            adapter.Fill(osobe);
        }

        private void PrikaziOsobu()
        {
            var osoba = osobe.Rows[aktivniIndeks];

            tbId.Text = osoba["id"].ToString();
            tbIme.Text = osoba["ime"].ToString();
            tbPrezime.Text = osoba["prezime"].ToString();
            tbAdresa.Text = osoba["adresa"].ToString();
            tbJmbg.Text = osoba["jmbg"].ToString();
            tbEmail.Text = osoba["email"].ToString();
            tbLozinka.Text = osoba["pass"].ToString();
            tbUloga.Text = osoba["uloga"].ToString();
        }

        private void btnLevo_Click(object sender, EventArgs e)
        {
            // PokupiOsobe();
            aktivniIndeks = aktivniIndeks == 0 ? aktivniIndeks : aktivniIndeks - 1;
            PrikaziOsobu();
        }

        private void btnSkrozLevo_Click(object sender, EventArgs e)
        {
            // PokupiOsobe();
            aktivniIndeks = 0;
            PrikaziOsobu();
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            // PokupiOsobe();
            aktivniIndeks = aktivniIndeks == osobe.Rows.Count - 1 ? aktivniIndeks : aktivniIndeks + 1;
            PrikaziOsobu();
        }

        private void btnSkrozDesno_Click(object sender, EventArgs e)
        {
            // PokupiOsobe();
            aktivniIndeks = osobe.Rows.Count - 1;
            PrikaziOsobu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    var tb = (TextBox)ctrl;
                    if (tb.Text.Length == 0)
                    {
                        MessageBox.Show("Ne sme biti praznih polja.");
                        return;
                    }
                }
            }

            var ime = tbIme.Text;
            var prezime = tbPrezime.Text;
            var adresa = tbAdresa.Text;
            var jmbg = tbJmbg.Text;
            var email = tbEmail.Text;
            var lozinka = tbLozinka.Text;
            var uloga = Convert.ToInt32(tbUloga.Text);

            var commandText = string.Format(
                "insert into Osoba(ime, prezime, adresa, jmbg, email, pass, uloga) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6});",
                ime, prezime, adresa, jmbg, email, lozinka, uloga);

            var command = new SqlCommand(commandText);
            command.Connection = conn;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            PokupiOsobe();
            btnSkrozDesno.PerformClick();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    var tb = (TextBox)ctrl;
                    if (tb.Text.Length == 0)
                    {
                        MessageBox.Show("Ne sme biti praznih polja.");
                        return;
                    }
                }
            }

            var id = Convert.ToInt32(tbId.Text);
            var ime = tbIme.Text;
            var prezime = tbPrezime.Text;
            var adresa = tbAdresa.Text;
            var jmbg = tbJmbg.Text;
            var email = tbEmail.Text;
            var lozinka = tbLozinka.Text;
            var uloga = Convert.ToInt32(tbUloga.Text);

            var commandText = string.Format(
                "update Osoba set ime = '{0}', prezime = '{1}', adresa = '{2}', jmbg = '{3}', email = '{4}', pass = '{5}', uloga = '{6}' where id = '{7}';",
                ime, prezime, adresa, jmbg, email, lozinka, uloga, id);

            var command = new SqlCommand(commandText);
            command.Connection = conn;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            PokupiOsobe();
            PrikaziOsobu();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(tbId.Text);

            var commandText = string.Format("delete from Osoba where id = {0}", id);

            var command = new SqlCommand(commandText);
            command.Connection = conn;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            PokupiOsobe();

            if (aktivniIndeks > 0)
                --aktivniIndeks;

            PrikaziOsobu();
        }
    }
}
