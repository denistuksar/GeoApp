﻿using System;
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
    public partial class OdobravanjeNarudzbe : Form
    {
        public OdobravanjeNarudzbe()
        {
            InitializeComponent();
        }

        private void OdobravanjeNarudzbe_Load(object sender, EventArgs e)
        {
            PrikaziNarudzbe();
            PrikaziOdobrene();
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Dohvaća listu svih artikla iz kolekcije artikla u kontekstu, te ih prikazuje
        /// u DataGridViewu.
        /// </summary>
        private void PrikaziNarudzbe()
        {
            List<Narudzba> narudzba;
            using (var db = new Entities())
            {
                var query = from n in db.Narudzba
                            where n.Status == null
                            select n;
                narudzba = query.ToList();
            }
            dgvNarudzbe.DataSource = narudzba;
            dgvNarudzbe.Columns[4].Visible = false;
            dgvNarudzbe.Columns[5].Visible = false;
            dgvNarudzbe.Columns[6].Visible = false;
            dgvNarudzbe.Columns[7].Visible = false;
        }

        private void PrikaziOdobrene()
        {
            List<Narudzba> narudzba;
            using (var db = new Entities())
            {
                var query = from n in db.Narudzba
                            where n.Status == true
                            select n;
                narudzba = query.ToList();
            }
            dgvOdobrene.DataSource = narudzba;
            dgvOdobrene.Columns[4].Visible = false;
            dgvOdobrene.Columns[5].Visible = false;
            dgvOdobrene.Columns[6].Visible = false;
            dgvOdobrene.Columns[7].Visible = false;
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbe.Rows.Count != 0)
            {
                Narudzba selektiranaNarudzba = dgvNarudzbe.CurrentRow.DataBoundItem as Narudzba;
                if (selektiranaNarudzba != null)
                {
                    using (var db = new Entities())
                    {
                        db.Narudzba.Attach(selektiranaNarudzba); //registriramo prosljeđenu narudžbu 
                        selektiranaNarudzba.Status = true;
                        db.SaveChanges();   //Spremamo promjene u bazu.
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite narudžbu koju želite odobriti");
                }
                PrikaziNarudzbe();
                PrikaziOdobrene();
            }   
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbe.CurrentRow != null)
            {
                Narudzba selektiranaNarudzba = dgvNarudzbe.CurrentRow.DataBoundItem as Narudzba;
                if (selektiranaNarudzba != null)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite odbaciti narudžbu?", "Upozorenje!",
       MessageBoxButtons.YesNo) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new Entities())
                        {
                            List<Stavke_narudzbe> lista = db.Stavke_narudzbe.Where(x => x.NarudzbaID_narudzbe == selektiranaNarudzba.ID_narudzbe).ToList();
                            db.Stavke_narudzbe.RemoveRange(lista);   //Brišemo narudzbu iz kolekcije
                            db.SaveChanges();    //Spremamo promjene u bazu.
                            db.Narudzba.Attach(selektiranaNarudzba);
                            db.Narudzba.Remove(selektiranaNarudzba);
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite narudžbu koji želite izbrisati");
                }
                PrikaziNarudzbe();
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if(dgvNarudzbe.Rows.Count != 0)
            {
                Narudzba selektiranaNarudzba = dgvNarudzbe.CurrentRow.DataBoundItem as Narudzba;
                if (selektiranaNarudzba != null)
                {
                    DetaljiNarudzbe detaljiNarudzbe = new DetaljiNarudzbe(selektiranaNarudzba.ID_narudzbe);
                    detaljiNarudzbe.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odaberite narudžbu za koju želite prikazati detalje");
                }
            }     
        }

        private void OdobravanjeNarudzbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.ShowDialog();
            this.Close();
        }
    }
}