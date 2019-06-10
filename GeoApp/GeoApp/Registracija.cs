using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class Registracija : Form
    {

        


        public Registracija()
        {
            InitializeComponent();
        }

        private void registriraj_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {

                if (txtKorime.Text!="")
                {
                    var korisnik = new Korisnik
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        OIB = txtOib.Text,
                        Adresa = txtAdresa.Text,
                        Email = txtEmail.Text,
                        Broj_telefona = txtTelefon.Text,
                        Korisnicko_ime = txtKorime.Text,
                        Lozinka = txtLozinka.Text,
                    };
                    db.Korisnik.Add(korisnik);
                    db.SaveChanges();
                    MessageBox.Show("Uspješna registracija");
                }

                else
                {
                    MessageBox.Show("Neuspješna registracija");
                }
            }
        }

    private void natrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.Show();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void Registracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.ShowDialog();
        }
    }
}
