using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Sifarnik : Form
    {
        string imeTabele;

        SqlDataAdapter adapter;
        DataTable tabela;

        public Sifarnik(string tabela)
        {
            imeTabele = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(
                string.Format("select * from {0};", imeTabele),
                ConfigurationManager.AppSettings["dbConnString"]);

            tabela = new DataTable();
            adapter.Fill(tabela);

            dataGridView.DataSource = tabela;
            dataGridView.Columns["id"].ReadOnly = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var menjano = tabela.GetChanges();
            if (menjano == null)
            {
                Close();
                return;
            }

            adapter.UpdateCommand = new SqlCommandBuilder(adapter)
                .GetUpdateCommand();

            adapter.Update(menjano);
            Close();
        }
    }
}
