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
    public partial class Login : Form
    {
        SqlConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.AppSettings["dbConnString"]);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = tbEmail.Text;
            var lozinka = tbLozinka.Text;

            if (email.Length == 0)
            {
                MessageBox.Show("Morate uneti email");
                return;
            }

            if (lozinka.Length == 0)
            {
                MessageBox.Show("Morate uneti lozinku");
                return;
            }

            var command = new SqlCommand(string.Format("select * from Osoba where email = '{0}';", email), conn);

            var adapter = new SqlDataAdapter(command);

            var osoba = new DataTable();
            adapter.Fill(osoba);

            if (osoba.Rows.Count != 1)
            {
                MessageBox.Show("Nepoznat email");
                return;
            }

            if (osoba.Rows[0]["pass"].ToString() != lozinka)
            {
                MessageBox.Show("Uneta lozinka nije dobra.");
                return;
            }

            Program.Uloga = (int)osoba.Rows[0]["uloga"];
            Program.Ime = osoba.Rows[0]["ime"].ToString();
            Program.Prezime = osoba.Rows[0]["prezime"].ToString();

            Hide();
            new Glavna2().Show();
        }
    }
}
