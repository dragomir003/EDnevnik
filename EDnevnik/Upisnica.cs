using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EDnevnik
{
    public partial class Upisnica : Form
    {
        Dictionary<string, ComboBox> komboTabele = new Dictionary<string, ComboBox>();

        public Upisnica()
        {
            InitializeComponent();
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {
            komboTabele.Add("skolska_godina", cmbGodina);
            komboTabele.Add("odeljenje", cmbOdeljenje);
            komboTabele.Add("osoba", cmbUcenik);

            FillCombo(new KeyValuePair<string, ComboBox>("skolska_godina", komboTabele["skolska_godina"]));

            cmbUcenik.Enabled = false;
            tbUpisnicaId.Enabled = false;
        }

        private DataTable CreateTable(string komanda)
        {
            var rez = new DataTable();
            var adapter = new SqlDataAdapter(komanda, ConfigurationManager.AppSettings["dbConnString"]);
            adapter.Fill(rez);
            return rez;
        }

        private void FillCombo(KeyValuePair<string, ComboBox> kvp)
        {
            Func<string, string> poljeNaziv = (tabela) =>
            {
                switch (tabela)
                {
                    case "odeljenje":
                        return "str(razred) + '/' + indeks";
                    case "osoba":
                        return "ime + ' ' + prezime";
                    default:
                        return "naziv";
                }
            };

            var podaci = CreateTable($"select id, {poljeNaziv(kvp.Key)} as naziv from {kvp.Key};");

            kvp.Value.DataSource = podaci;
            kvp.Value.ValueMember = "id";
            kvp.Value.DisplayMember = "naziv";
            kvp.Value.SelectedValue = 2;
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbGodina.IsHandleCreated || !cmbGodina.Focused)
                return;

            FillCombo(new KeyValuePair<string, ComboBox>("odeljenje", komboTabele["odeljenje"]));
            cmbOdeljenje.SelectedIndex = -1;
            cmbUcenik.SelectedIndex = -1;
            cmbUcenik.Enabled = false;
            
        }

        private void cmbOdeljenje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbOdeljenje.IsHandleCreated || !cmbOdeljenje.Focused)
                return;

            FillCombo(new KeyValuePair<string, ComboBox>("osoba", komboTabele["osoba"]));
            cmbOdeljenje.SelectedIndex = -1;
            cmbUcenik.SelectedIndex = -1;
            cmbUcenik.Enabled = true;
            FillGrid();
        }

        private void FillGrid()
        {
            var komanda = $@"select
                                upisnica.id as id,
                                ime + ' ' + prezime as naziv,
                                osoba.id as ucenik
                             from upisnica
                             join osoba on upisnica.osoba_id = osoba.id
                             where odeljenje_id = {cmbOdeljenje.SelectedValue};";

            MessageBox.Show(komanda);
            dataGridView.DataSource = CreateTable(komanda);

            dataGridView.AllowUserToAddRows = false;
        }
    }
}
