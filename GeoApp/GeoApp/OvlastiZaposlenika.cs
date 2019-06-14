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
            using (var db = new Entities())
            {
                var zaposleni = from z in db.Korisnik                               
                                select z;

                dgvZaposlenici.DataSource = zaposleni.ToList();
                dgvZaposlenici.Columns[9].Visible = false;
                dgvZaposlenici.Columns[11].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
                dgvZaposlenici.Columns[13].Visible = false;
                dgvZaposlenici.Columns[14].Visible = false;
            }

            dgvZaposlenici.Columns[0].HeaderText = "ID korisnika";
            dgvZaposlenici.Columns[1].HeaderText = "ID uloge";
            dgvZaposlenici.Columns[7].HeaderText = "Broj telefona";
            dgvZaposlenici.Columns[8].HeaderText = "Korisničko ime";
    
        }


        public void PrikaziZaposlene()
        {
            using (var db = new Entities())
            {
                var zaposleni = from z in db.Korisnik
                                where z.UlogaID_uloge == 3
                                select z;

                dgvZaposlenici.DataSource = zaposleni.ToList();
                dgvZaposlenici.Columns[9].Visible = false;
                dgvZaposlenici.Columns[11].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
                dgvZaposlenici.Columns[13].Visible = false;
                dgvZaposlenici.Columns[14].Visible = false;
            
            }
        
        }

        private void OvlastiZaposlenika_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void btnPrikaziZaposlene_Click(object sender, EventArgs e)
        {      
            if (clicked==false)
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
            Ovlasti ovlast = dgvZaposlenici.CurrentRow.DataBoundItem as Ovlasti;
            
            if(ovlast.ID_ovlasti == OvlastInfo.IDOvlasti)
            {
                cbBezOvlasti.Checked= true;
            }
            else
            {

            }
        }
    }
}
