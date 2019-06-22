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
            using (var db = new GeoApp())
            {
                var zaposleni = from z in db.Korisnik
                                select z;

                dgvZaposlenici.DataSource = zaposleni.ToList();
                dgvZaposlenici.Columns[10].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
                dgvZaposlenici.Columns[13].Visible = false;
                dgvZaposlenici.Columns[14].Visible = false;
                dgvZaposlenici.Columns[15].Visible = false;
            }

            dgvZaposlenici.Columns[0].HeaderText = "ID korisnika";
            dgvZaposlenici.Columns[1].HeaderText = "ID ovlasti";
            dgvZaposlenici.Columns[2].HeaderText = "ID uloge";
            dgvZaposlenici.Columns[7].HeaderText = "Broj telefona";
            dgvZaposlenici.Columns[8].HeaderText = "Korisničko ime";

        }


        public void PrikaziZaposlene()
        {
            using (var db = new GeoApp())
            {
                var zaposleni = from z in db.Korisnik
                                where z.UlogaID_uloge == 3
                                select z;

                dgvZaposlenici.DataSource = zaposleni.ToList();
                dgvZaposlenici.Columns[10].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
                dgvZaposlenici.Columns[13].Visible = false;
                dgvZaposlenici.Columns[14].Visible = false;
                dgvZaposlenici.Columns[15].Visible = false;
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
            Korisnik korisnik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            AzurirajKorisnika azurirajKorisnika = new AzurirajKorisnika(korisnik);
            azurirajKorisnika.ShowDialog();
            PrikaziKorisnike();
        }

        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            Korisnik zaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;

            switch (zaposlenik.OvlastiID_ovlast)
            {
                case 1:
                    cbAdmin.Checked = true;
                    cbNarudzba.Checked = false;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = false;
                    break;
                case 2:
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = true;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = false;
                    break;
                case 3:
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = true;
                    cbCRUD.Checked = true;
                    cbBezOvlasti.Checked = false;
                    break;
                case 4:
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = false;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = true;
                    break;

                default:
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = false;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = false;
                    break;
            }

        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            Korisnik zaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;

            using (var db = new GeoApp())
            {
                db.Korisnik.Attach(zaposlenik);

                if (cbAdmin.Checked)
                {
                    cbAdmin.Checked = true;
                    cbNarudzba.Checked = false;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = false;
                    zaposlenik.OvlastiID_ovlast = 1;
                }
                else if (cbNarudzba.Checked)
                {
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = true;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = false;
                    zaposlenik.OvlastiID_ovlast = 2;
                }
                else if (cbCRUD.Checked)
                {
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = true;
                    cbCRUD.Checked = true;
                    cbBezOvlasti.Checked = false;
                    zaposlenik.OvlastiID_ovlast = 3;
                }
                else if (cbBezOvlasti.Checked)
                {
                    cbAdmin.Checked = false;
                    cbNarudzba.Checked = false;
                    cbCRUD.Checked = false;
                    cbBezOvlasti.Checked = true;
                    zaposlenik.OvlastiID_ovlast = 4;
                }
                db.SaveChanges();

            }
            PrikaziKorisnike();

        }

        private void OvlastiZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Pocetna().ShowDialog();
            this.Close();
        }
    }
}
