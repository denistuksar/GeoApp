﻿using System;
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

        public Narucivanje()
        {
            InitializeComponent();
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
            using (var db = new Entities())
            {
                artikli = db.Artikl.ToList();
            }
            dgvArtikli.DataSource = artikli;
            dgvArtikli.Columns[6].Visible = false;
        }

        private void PrikaziKosaricu()
        {
            List<Artikl> narudzba;
            using (var db = new Entities())
            {
                var query = from a in db.Artikl
                            join n in db.Stavke_narudzbe on a.ID_artikla equals n.ArtiklID_artikla
                            where n.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe
                            select a;
                narudzba = query.ToList();
                dgvKosarica.DataSource = narudzba;
                dgvKosarica.Columns[6].Visible = false;
            }
        }

        private void Narucivanje_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
            this.MaximizeBox = false;
            txtKolicina.Text = "1";       
        }

        private void Narucivanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var db = new Entities())
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
            Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
            using (var db = new Entities())
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
            }
            PrikaziKosaricu();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Artikl selektiraniArtikl = dgvKosarica.CurrentRow.DataBoundItem as Artikl;
            if (dgvKosarica.Rows.Count != 0)
            {
                using (var db = new Entities())
                {
                    List<Stavke_narudzbe> lista = db.Stavke_narudzbe.Where(x => x.NarudzbaID_narudzbe == NarudzbaInfo.IDNarudzbe && x.ArtiklID_artikla==selektiraniArtikl.ID_artikla).ToList();
                    db.Stavke_narudzbe.RemoveRange(lista);   //Brišemo narudzbu iz kolekcije
                    db.SaveChanges();
                }
                PrikaziKosaricu();
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
    }
}