using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class AzurirajKorisnika : Form
    {
        Korisnik odabraniKorisnik;
        public AzurirajKorisnika(Korisnik korisnik)
        {
            InitializeComponent();
            odabraniKorisnik = korisnik;
        }

        public void PopuniBoxeve()
        {
            using (var db = new Entities1())
            {
                db.Korisnik.Attach(odabraniKorisnik);
                uiUnosImena.Text = odabraniKorisnik.Ime;
                uiUnosPrezimena.Text = odabraniKorisnik.Prezime;
                uiUnosOIB.Text = odabraniKorisnik.OIB;
                uiUnosAdrese.Text = odabraniKorisnik.Adresa;
                uiUnosEmaila.Text = odabraniKorisnik.Email;
                uiUnosTelefona.Text = odabraniKorisnik.Broj_telefona;
                uiUnosKorisnickogImena.Text = odabraniKorisnik.Korisnicko_ime;
                uiUnosLozinke.Text = Encoding.UTF8.GetString(odabraniKorisnik.Kriptirana_Lozinka);
                db.SaveChanges();
            }
        }

        private void AzurirajKorisnika_Load(object sender, EventArgs e)
        {
            helpAzuriranjeKorisnika.HelpNamespace = Environment.CurrentDirectory + "/help/azuriranjeKorisnika.html";

            PopuniBoxeve();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities1())
            {
                db.Korisnik.Attach(odabraniKorisnik);
                odabraniKorisnik.Ime = uiUnosImena.Text;
                odabraniKorisnik.Prezime = uiUnosPrezimena.Text;
                odabraniKorisnik.OIB = uiUnosOIB.Text;
                odabraniKorisnik.Adresa = uiUnosAdrese.Text;
                odabraniKorisnik.Email = uiUnosEmaila.Text;
                odabraniKorisnik.Broj_telefona = uiUnosTelefona.Text;
                odabraniKorisnik.Korisnicko_ime = uiUnosKorisnickogImena.Text;
                odabraniKorisnik.Kriptirana_Lozinka = Encoding.UTF8.GetBytes(uiUnosLozinke.Text);
                odabraniKorisnik.Lozinka = uiUnosLozinke.Text;
                db.SaveChanges();
            }
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika?", "Upozorenje!",
       MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new Entities1())
                {
                    db.Korisnik.Attach(odabraniKorisnik);

                    if (odabraniKorisnik.Narudzba.Count == 0)
                    {
                        db.Korisnik.Remove(odabraniKorisnik);
                        db.SaveChanges();
                    }
                    else
                    {
                        if (MessageBox.Show("Nije moguće obrisati korisnika koji sadrži narudžbe, želite " +
                            "li vidjeti korisnikove narudžbe", "Upozorenje!", MessageBoxButtons.YesNo)
                            == System.Windows.Forms.DialogResult.Yes)
                        {
                            OdobravanjeNarudzbe odobravanjeNarudzbe = new OdobravanjeNarudzbe(odabraniKorisnik);
                            odobravanjeNarudzbe.ShowDialog();

                        }

                        this.Close();
                    }

                }
            }


            this.Close();
        }

        private void AzurirajKorisnika_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

            this.Close();
        }
    }
}
