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
    public partial class OvlastiZaposlenika : Form
    {
        public OvlastiZaposlenika()
        {
            InitializeComponent();
        }

        private bool clicked = false;

        public void PrikaziKorisnike()
        {
            using (var db = new Entities1())
            {
                var zaposleni = from z in db.Korisnik
                                select z;

                uiPrikaziKorisnike.DataSource = zaposleni.ToList();
                uiPrikaziKorisnike.Columns[9].Visible = false;
                uiPrikaziKorisnike.Columns[11].Visible = false;
                uiPrikaziKorisnike.Columns[12].Visible = false;
                uiPrikaziKorisnike.Columns[13].Visible = false;
            
            }

            uiPrikaziKorisnike.Columns[0].HeaderText = "ID korisnika";
           
            uiPrikaziKorisnike.Columns[2].HeaderText = "Ime";
            uiPrikaziKorisnike.Columns[7].HeaderText = "Broj telefona";
            uiPrikaziKorisnike.Columns[8].HeaderText = "Korisničko ime";

        }


        public void PrikaziZaposlene()
        {
            using (var db = new Entities1())
            {
                var zaposleni = from z in db.Korisnik
                                where z.UlogaID_uloge == 3
                                select z;

                uiPrikaziKorisnike.DataSource = zaposleni.ToList();
                uiPrikaziKorisnike.Columns[9].Visible = false;
                uiPrikaziKorisnike.Columns[11].Visible = false;
                uiPrikaziKorisnike.Columns[12].Visible = false;
                uiPrikaziKorisnike.Columns[13].Visible = false;
            }

        }

        private void OvlastiZaposlenika_Load(object sender, EventArgs e)
        {
            helpOvlasti.HelpNamespace = Environment.CurrentDirectory + "/help/ovlasti.html";

            PrikaziKorisnike();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
            PrikaziKorisnike();
        }

        private void btnPrikaziZaposlene_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                PrikaziZaposlene();

                clicked = true;
            }
            else
            {
                PrikaziKorisnike();
                clicked = false;
            }
        }

        private void btnAzurirajZaposlenika_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = uiPrikaziKorisnike.CurrentRow.DataBoundItem as Korisnik;
            AzurirajKorisnika azurirajKorisnika = new AzurirajKorisnika(korisnik);
            azurirajKorisnika.ShowDialog();
            PrikaziKorisnike();
        }

        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            Korisnik zaposlenik = uiPrikaziKorisnike.CurrentRow.DataBoundItem as Korisnik;

            switch (zaposlenik.UlogaID_uloge)
            {
                case 1:
                    uiOdabraniAdministrator.Checked = true;
                    uiOdabraniZaposlenik.Checked = false;
                    uiOdabraniKupac.Checked = false;
               
                    break;
                case 2:
                    uiOdabraniAdministrator.Checked = false;
                    uiOdabraniZaposlenik.Checked = false;
                    uiOdabraniKupac.Checked = true;
                 
                    break;
                case 3:
                    uiOdabraniAdministrator.Checked = false;
                    uiOdabraniZaposlenik.Checked = true;
                    uiOdabraniKupac.Checked = false;                
                    break;
               

                default:
                    uiOdabraniAdministrator.Checked = false;
                    uiOdabraniZaposlenik.Checked = false;
                    uiOdabraniKupac.Checked = false;                   
                    break;
            }

        }

     

        private void OvlastiZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Pocetna().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik zaposlenik = uiPrikaziKorisnike.CurrentRow.DataBoundItem as Korisnik;

            using (var db = new Entities1())
            {
                db.Korisnik.Attach(zaposlenik);

                if (uiOdabraniAdministrator.Checked)
                {
                    uiOdabraniAdministrator.Checked = true;
                    uiOdabraniZaposlenik.Checked = false;
                    uiOdabraniKupac.Checked = false;
                    zaposlenik.UlogaID_uloge = 1;
                }
                else if (uiOdabraniZaposlenik.Checked)
                {
                    uiOdabraniAdministrator.Checked = false;
                    uiOdabraniZaposlenik.Checked = true;
                    uiOdabraniKupac.Checked = false;
                    zaposlenik.UlogaID_uloge = 3;
                }
                else if (uiOdabraniKupac.Checked)
                {
                    uiOdabraniAdministrator.Checked = false;
                    uiOdabraniZaposlenik.Checked = false;
                    uiOdabraniKupac.Checked = true;
                    zaposlenik.UlogaID_uloge = 2;
                }

                db.SaveChanges();

            }
            MessageBox.Show("Uspješno promjenjena uloga korisnika");
            PrikaziKorisnike();
        }
    }
}
