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
            using (var db = new Entities())
            {
                db.Korisnik.Attach(odabraniKorisnik);
                txtIme.Text = odabraniKorisnik.Ime;
                txtPrezime.Text = odabraniKorisnik.Prezime;
                txtOib.Text = odabraniKorisnik.OIB;
                txtAdresa.Text = odabraniKorisnik.Adresa;
                txtEmail.Text = odabraniKorisnik.Email;
                txtTelefon.Text = odabraniKorisnik.Broj_telefona;
                txtKorIme.Text = odabraniKorisnik.Korisnicko_ime;
                txtLozinka.Text = Encoding.UTF8.GetString(odabraniKorisnik.Kriptirana_Lozinka);
                db.SaveChanges();
            }
        }

        private void AzurirajKorisnika_Load(object sender, EventArgs e)
        {
            PopuniBoxeve();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                db.Korisnik.Attach(odabraniKorisnik);
                odabraniKorisnik.Ime= txtIme.Text  ;
                odabraniKorisnik.Prezime = txtPrezime.Text;
                odabraniKorisnik.OIB=txtOib.Text;
                odabraniKorisnik.Adresa=txtAdresa.Text;
                odabraniKorisnik.Email= txtEmail.Text;
                odabraniKorisnik.Broj_telefona=txtTelefon.Text;
                odabraniKorisnik.Korisnicko_ime= txtKorIme.Text;
                odabraniKorisnik.Kriptirana_Lozinka=Encoding.UTF8.GetBytes(txtLozinka.Text);
                odabraniKorisnik.Lozinka = txtLozinka.Text;
                db.SaveChanges();
            }
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika?", "Upozorenje!",
       MessageBoxButtons.YesNo) ==
                        System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new Entities())
                {
                  
                    db.Korisnik.Attach(odabraniKorisnik);
                    db.Korisnik.Remove(odabraniKorisnik);  
                    db.SaveChanges();    
                }
            }
            

            this.Close();
        }
    }
}