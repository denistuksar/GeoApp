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
    public partial class Narucivanje : Form
    {

        public Narucivanje()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dohvaća listu svih artikla iz kolekcije artikla u kontekstu, te ih prikazuje
        /// u DataGridViewu.
        /// </summary>
        private void PrikaziArtikle()
        {
            List<Artikl> artikli;
            using (var db = new Entities())
            {
                artikli = db.Artikl.ToList();
            }
            dgvArtikli.DataSource = artikli;
            dgvArtikli.Columns[6].Visible = false;
        }



        private void Narucivanje_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
            this.MaximizeBox = false;
            txtKolicina.Text = "1";
            
        }

        private void Narucivanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Pocetna().ShowDialog();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
            this.dgvKosarica.Rows.Add(selektiraniArtikl.ID_artikla, selektiraniArtikl.Naziv, selektiraniArtikl.Opis, selektiraniArtikl.Proizvodac, selektiraniArtikl.Cijena, selektiraniArtikl.Serijski_broj, txtKolicina.Text);
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.dgvKosarica.Rows.Remove(dgvKosarica.CurrentRow);
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            if (dgvKosarica.Rows.Count != 0)
            {
                if (MessageBox.Show("Da li ste sigurni da želite naručiti artikle?", "Upozorenje!",
                      MessageBoxButtons.YesNo) ==
                                       System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        var a = new Narudzba
                        {
                            KorisnikID_korisnika = LoginInfo.IDKorisnika,
                            Datum = DateTime.Now.Date,
                            Vrijeme = DateTime.Now.TimeOfDay  
                        };
                        db.Narudzba.Add(a);
                        db.SaveChanges();
                        var query = from n in db.Narudzba
                                    where n.KorisnikID_korisnika == LoginInfo.IDKorisnika
                                    select n.ID_narudzbe;
                        var idNaruzbe = query.FirstOrDefault<int>();
                        foreach (DataGridViewRow row in dgvKosarica.Rows)
                        {
                            var id =row.Cells[0].Value.ToString();
                            var kol = row.Cells[6].Value.ToString();
                            int idArtikla = int.Parse(id);
                            int kolicina = int.Parse(kol);
                            var s = new Stavke_narudzbe
                            {
                                NarudzbaID_narudzbe = idNaruzbe,
                                ArtiklID_artikla = idArtikla,
                                Kolicina = kolicina,
                            };
                            db.Stavke_narudzbe.Add(s);
                            db.SaveChanges();
                        } 
                    }

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
    }
}
