using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace GeoApp
{
    public partial class Narucivanje : Form
    {
        decimal suma;
        public Narucivanje()
        {
            InitializeComponent();
            using (var db = new Entities1())
            {
                var a = new Narudzba
                {
                    KorisnikID_korisnika = LoginInfo.IDKorisnika,
                    Datum = DateTime.Now.Date,
                    Vrijeme = DateTime.Now.TimeOfDay
                };
                db.Narudzba.Add(a);
                db.SaveChanges();
                NarudzbaInfo.IDNarudzbe = a.ID_narudzbe;
            }
        }

        /// <summary>
        /// Dohvaća listu svih artikla iz kolekcije artikla u kontekstu, te ih prikazuje
        /// u DataGridViewu.
        /// </summary>
        private void PrikaziArtikle()
        {
            List<Artikl> artikli;
            using (var db = new Entities1())
            {
                artikli = db.Artikl.ToList();
            }
            dgvArtikli.DataSource = artikli;
            dgvArtikli.Columns[0].HeaderText = "ID artikla";
            dgvArtikli.Columns[2].Width = 200;
            dgvArtikli.Columns[3].HeaderText = "Proizvođač";
            dgvArtikli.Columns[5].HeaderText = "Serijski broj";
            dgvArtikli.Columns[6].Visible = false;
        }

        private void PrikaziKosaricu()
        {
            List<Artikl> narudzba;
            using (var db = new Entities1())
            {
                var query = (from a in db.Artikl
                             join n in db.Stavke_narudzbe on a.ID_artikla equals n.ArtiklID_artikla
                             where n.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe
                             select new
                             {
                                 a.ID_artikla,
                                 a.Naziv,
                                 a.Opis,
                                 a.Proizvodac,
                                 a.Serijski_broj,
                                 a.Cijena,
                                 n.Kolicina
                             }).ToList();
                dgvKosarica.DataSource = query;
                var query2 = from a in db.Artikl
                              join n in db.Stavke_narudzbe on a.ID_artikla equals n.ArtiklID_artikla
                              where n.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe
                              select a;
                narudzba = query2.ToList();
                dgvKosarica.Columns[0].HeaderText = "ID artikla";
                dgvKosarica.Columns[3].HeaderText = "Proizvođač";
                dgvKosarica.Columns[4].HeaderText = "Serijski broj";
                dgvKosarica.Columns[6].HeaderText = "Količina";
            }
        }

        private void Narucivanje_Load(object sender, EventArgs e)
        {
            helpNarucivanje.HelpNamespace = Environment.CurrentDirectory + "/help/narucivanje.html";
            PrikaziArtikle();
            this.MaximizeBox = false;
            txtKolicina.Text = "1";       
        }

        private void Narucivanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var db = new Entities1())
            {
                List<Stavke_narudzbe> lista = db.Stavke_narudzbe.Where(x => x.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe).ToList();
                if (lista.Count != 0)
                {
                    db.Stavke_narudzbe.RemoveRange(lista);   //Brišemo narudzbu iz kolekcije
                    db.SaveChanges();    //Spremamo promjene u bazu.
                }
                try
                {
                    Narudzba narudzba = db.Narudzba.Where(x => x.ID_narudzbe == NarudzbaInfo.IDNarudzbe).Single<Narudzba>();
                    db.Narudzba.Remove(narudzba);
                    db.SaveChanges();
                }
                catch
                {
                }    
            }
        this.Hide();
        new Pocetna().ShowDialog();
        this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                using (var db = new Entities1())
                {
                    int kolicina = int.Parse(txtKolicina.Text);
                    var s = new Stavke_narudzbe
                    {
                        NarudzbaID_narudzbe = NarudzbaInfo.IDNarudzbe,
                        ArtiklID_artikla = selektiraniArtikl.ID_artikla,
                        Kolicina = kolicina
                    };
                    db.Stavke_narudzbe.Add(s);
                    db.SaveChanges();
                    suma = Convert.ToDecimal((from a in db.Stavke_narudzbe
                                 where a.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe
                                 select a).Sum(b => b.Kolicina * b.Artikl.Cijena));
                    lblCijena.Text = suma.ToString();
                    lblCijena.Text += " HRK";
                }
                PrikaziKosaricu();
            }
            catch(FormatException)
            {

                MessageBox.Show("Neispravan unos količine.");
            }
            
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var selektiraniArtikl = (int)dgvKosarica.CurrentRow.Cells[0].Value;
                if (dgvKosarica.Rows.Count != 0)
                {
                    using (var db = new Entities1())
                    {
                        List<Stavke_narudzbe> lista = db.Stavke_narudzbe.Where(x => x.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe && x.ArtiklID_artikla == selektiraniArtikl).ToList();
                        db.Stavke_narudzbe.RemoveRange(lista);   //Brišemo narudzbu iz kolekcije
                        db.SaveChanges();
                        suma = Convert.ToDecimal((from a in db.Stavke_narudzbe
                                                  where a.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe
                                                  select a).Sum(b => b.Kolicina * b.Artikl.Cijena));
                        lblCijena.Text = suma.ToString();
                        lblCijena.Text += " HRK";
                    }
                    PrikaziKosaricu();
                }
                else
                {
                    lblCijena.Text = "0";
                    lblCijena.Text += " HRK";
                    PrikaziKosaricu();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Odaberite artikl koji želite izbrisati.");
            }
            
            
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            if (dgvKosarica.Rows.Count != 0)
            {
                if (MessageBox.Show("Da li ste sigurni da želite naručiti artikle?", "Upozorenje!",
                      MessageBoxButtons.YesNo) ==
                                       System.Windows.Forms.DialogResult.Yes)
                {       
                    MessageBox.Show("Narudžba uspješna");
                    this.Hide();
                    Pocetna pocetna = new Pocetna();
                    pocetna.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Odaberite artikle koje želite naručiti");
            }
         }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Entities1())
            {
                var query = from a in db.Artikl
                            where a.Naziv.Contains(txtSearch.Text)
                            select a;
                dgvArtikli.DataSource = query.ToList();
            }
            dgvArtikli.Columns[0].HeaderText = "ID artikla";
            dgvArtikli.Columns[2].Width = 200;
            dgvArtikli.Columns[3].HeaderText = "Proizvođač";
            dgvArtikli.Columns[5].HeaderText = "Serijski broj";
            dgvArtikli.Columns[6].Visible = false;
        }

        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            nazivArtikla.Text = dgvArtikli.CurrentRow.Cells[1].Value.ToString();
            opisArtikla.Text = dgvArtikli.CurrentRow.Cells[2].Value.ToString();
            proizvodacArtikla.Text = dgvArtikli.CurrentRow.Cells[3].Value.ToString();
            cijenaArtikla.Text = dgvArtikli.CurrentRow.Cells[4].Value.ToString();
            serijskiBrojArtikla.Text = dgvArtikli.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.ShowDialog();
        }
    }
}
