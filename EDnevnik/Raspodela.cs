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
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        Dictionary<string, TabelaCombo> tabele;

        int aktivniIndeks = 0;

        public Raspodela()
        {
            InitializeComponent();
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            tabele = new Dictionary<string, TabelaCombo>();

            tabele.Add("godina", new TabelaCombo(null, cmbGodina));
            tabele.Add("nastavnik", new TabelaCombo(null, cmbNastavnik));
            tabele.Add("predmet", new TabelaCombo(null, cmbPredmet));
            tabele.Add("odeljenje", new TabelaCombo(null, cmbOdeljenje));

            UcitajRaspodelu();
            ComboFill();
        }

        private void UcitajRaspodelu()
        {
            var adapter = new SqlDataAdapter("select * from raspodela;",
                ConfigurationManager.AppSettings["dbConnString"]);
            raspodela = new DataTable();
            adapter.Fill(raspodela);


            tabele["godina"].tabela = GetTable("select * from skolska_godina;");
            tabele["nastavnik"].tabela = GetTable("select id, ime + ' ' + prezime as naziv from osoba where uloga = 2;");
            tabele["predmet"].tabela = GetTable("select id, naziv from predmet");
            tabele["odeljenje"].tabela = GetTable("select id, str(razred) + '/' + indeks as naziv from odeljenje;");
        }

        class TabelaCombo
        {
            public DataTable tabela;
            public ComboBox combo;

            public TabelaCombo(DataTable _tabela, ComboBox _combo)
            {
                tabela = _tabela;
                combo = _combo;
            }
        }

        private void ComboFill()
        {
            foreach (var kvp in tabele)
            {
                var combo = kvp.Value.combo;
                var table = kvp.Value.tabela;
                var fk = string.Format("{0}_id", kvp.Key);

                combo.DataSource = table;
                combo.ValueMember = "id";
                combo.DisplayMember = "naziv";
                combo.SelectedValue = raspodela.Rows[aktivniIndeks][fk] is null ? -1 : raspodela.Rows[aktivniIndeks][fk];
            }
            tbId.Text = raspodela.Rows[aktivniIndeks]["id"] is null ? "" : raspodela.Rows[aktivniIndeks]["id"].ToString();
        }

        private DataTable GetTable(string komanda)
        {
            var rez = new DataTable();
            new SqlDataAdapter(
                komanda,
                ConfigurationManager.AppSettings["dbConnString"]
            ).Fill(rez);
            return rez;
        }

        private void btnSkrozLevo_Click(object sender, EventArgs e)
        {
            aktivniIndeks = 0;
            ComboFill();
        }

        private void btnLevo_Click(object sender, EventArgs e)
        {
            aktivniIndeks = aktivniIndeks == 0 ? aktivniIndeks : aktivniIndeks - 1;
            ComboFill();
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            aktivniIndeks = aktivniIndeks == raspodela.Rows.Count - 1 ? aktivniIndeks : aktivniIndeks + 1;
            ComboFill();
        }

        private void btnSkrozDesno_Click(object sender, EventArgs e)
        {
            aktivniIndeks = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is ComboBox)
                {
                    var combo = (ComboBox)ctrl;
                    if (combo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ne sme biti praznih polja.");
                        return;
                    }
                }
            }

            var godina = cmbGodina.SelectedValue;
            var nastavnik = cmbNastavnik.SelectedValue;
            var predmet = cmbPredmet.SelectedValue;
            var odeljenje = cmbOdeljenje.SelectedValue;

            var naredbaText = string.Format("insert into raspodela(godina_id, nastavnik_id, predmet_id, odeljenje_id) values ({0}, {1}, {2}, {3});", godina, nastavnik, predmet, odeljenje);

            var naredba = new SqlCommand(naredbaText, new SqlConnection(ConfigurationManager.AppSettings["dbConnString"]));

            naredba.Connection.Open();
            naredba.ExecuteNonQuery();
            naredba.Connection.Close();

            UcitajRaspodelu();

            btnSkrozDesno.PerformClick();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is ComboBox)
                {
                    var combo = (ComboBox)ctrl;
                    if (combo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ne sme biti praznih polja.");
                        return;
                    }
                }
            }

            var id = Convert.ToInt32(tbId.Text);

            var godina = cmbGodina.SelectedValue;
            var nastavnik = cmbNastavnik.SelectedValue;
            var predmet = cmbPredmet.SelectedValue;
            var odeljenje = cmbOdeljenje.SelectedValue;

            var naredbaText = $"update Raspodela set godina_id = '{godina}', predmet_id = '{predmet}', nastavnik_id = '{nastavnik}', odeljenje_id = '{odeljenje}' where id = {id};";

            var naredba = new SqlCommand(naredbaText, new SqlConnection(ConfigurationManager.AppSettings["dbConnString"]));

            naredba.Connection.Open();
            naredba.ExecuteNonQuery();
            naredba.Connection.Close();

            UcitajRaspodelu();

            ComboFill();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(tbId.Text);

            var naredbaText = $"delete from raspodela where id = {id};";

            var naredba = new SqlCommand(naredbaText, new SqlConnection(ConfigurationManager.AppSettings["dbConnString"]));

            naredba.Connection.Open();
            naredba.ExecuteNonQuery();
            naredba.Connection.Close();

            UcitajRaspodelu();

            btnLevo.PerformClick();

        }
    }
}
