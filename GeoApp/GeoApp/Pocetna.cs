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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            txtKorime.Text = LoginInfo.Korime;
            txtUloga.Text = LoginInfo.Uloga;
        }

        private void unosUredaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosArtikla unos = new UnosArtikla();
            unos.ShowDialog();
            this.Close();
        }

        private void azuriranjeUredaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            AzuriranjeArtikla azuriranje = new AzuriranjeArtikla();
            azuriranje.ShowDialog();
            this.Close();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

            helpPocetna.HelpNamespace = Environment.CurrentDirectory + "/help/pocetna.html";

            this.MaximizeBox = false;
            if (LoginInfo.Uloga=="Kupac")
            {
                unosUredaja.Visible = false;
                azuriranjeUredaja.Visible = false;
                btnOdobravanje.Visible = false;
                btnOvlasti.Visible = false;
                btnServis.Location = new Point(73, 146);
                this.Size = new Size(384,260);
            }
            else if (LoginInfo.Uloga == "Zaposlenik")
            {
                btnOvlasti.Visible = false;
                btnServis.Location = new Point(73, 324);
                this.Size = new Size(384, 423);
                
            }
        }

        private void Pocetna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.ShowDialog();
            this.Close();
        }

        private void btnNarucivanje_Click(object sender, EventArgs e)
        {
            this.Hide();
            Narucivanje narucivanje = new Narucivanje();
            narucivanje.ShowDialog();
            this.Close();
        }

        private void btnOdobravanje_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdobravanjeNarudzbe odobravanje = new OdobravanjeNarudzbe();
            odobravanje.ShowDialog();
            this.Close();
        }

        private void btnOvlasti_Click(object sender, EventArgs e)
        {
            this.Hide();
            OvlastiZaposlenika ovlastiZaposlenika = new OvlastiZaposlenika();
            ovlastiZaposlenika.ShowDialog();
            this.Close();
        }
    }
}
