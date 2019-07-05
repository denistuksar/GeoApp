using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private bool korIme = false;
        private bool oib = false;
        private bool email = false;


        List<string> popisOIB;
        List<string> popisKorisnika;
        List<string> popisEmaila;

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

                var oibi = from k in db.Korisnik
                          select k.OIB;
                popisOIB = oibi.ToList();

                var korisnickoIme = from k in db.Korisnik
                                    select k.Korisnicko_ime;

                popisKorisnika = korisnickoIme.ToList();

                var emaili = from k in db.Korisnik
                            select k.Email;

                popisEmaila = emaili.ToList();

                db.Korisnik.Attach(odabraniKorisnik);

                foreach (var username in popisKorisnika)
                {
                    if (username != uiUnosKorisnickogImena.Text)
                    {
                        if (korIme != false)
                        {
                            odabraniKorisnik.Korisnicko_ime = uiUnosKorisnickogImena.Text;
                        }

                        else
                        {
                            MessageBox.Show("Korisničko ime postoji! ");
                           
                        }
                       
                    }
                    
                }

                foreach (var oibs in popisOIB)
                {
                    if (oibs != uiUnosOIB.Text)
                    {
                        if (oib != false)
                        {
                            odabraniKorisnik.OIB = uiUnosOIB.Text;

                        }
                        else
                        {
                            MessageBox.Show("OIB postoji! ");
                        }
                    }
                }

                    foreach (var emails in popisEmaila)
                    {
                          
                        if (emails != uiUnosEmaila.Text)
                        {
                            if (email != false)
                            {
                                odabraniKorisnik.Email = uiUnosEmaila.Text;
                            }
                            else
                            {
                             MessageBox.Show("E-mail postoji! ");
                            }
                        }
                    }
                     
              
                odabraniKorisnik.Ime = uiUnosImena.Text;
                odabraniKorisnik.Prezime = uiUnosPrezimena.Text;
                odabraniKorisnik.Adresa = uiUnosAdrese.Text;
                odabraniKorisnik.Broj_telefona = uiUnosTelefona.Text;
                odabraniKorisnik.Kriptirana_Lozinka = Encoding.UTF8.GetBytes(uiUnosLozinke.Text);
                odabraniKorisnik.Lozinka = uiUnosLozinke.Text;
                db.SaveChanges();
            }

            this.Close();
          
        }


        public bool IsValidOIB(string oib)
        {
            return Regex.IsMatch(oib, @"^[0-9]{11}$");
        }

        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
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
                        MessageBox.Show("Korisnik uspješno izbrisan!");

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

        private void uiUnosKorisnickogImena_TextChanged(object sender, EventArgs e)
        {
            korIme = false;
            using (var db = new Entities1())
            {
                var korisnickoIme = from k in db.Korisnik
                                    select k.Korisnicko_ime;

                popisKorisnika = korisnickoIme.ToList();
            }
            foreach (var item in popisKorisnika)
            {
                if (item == uiUnosKorisnickogImena.Text)
                {
                    uiUnosKorisnickogImena.BackColor = Color.FromArgb(243, 92, 99);
                    uiUnosKorisnickogImena.ForeColor = Color.White;
                    break;
                }
                else if (uiUnosKorisnickogImena.Text == "")
                {
                    uiUnosKorisnickogImena.BackColor = Color.FromArgb(243, 92, 99);
                    uiUnosKorisnickogImena.ForeColor = Color.White;
                }
                else
                {
                    uiUnosKorisnickogImena.BackColor = Color.FromArgb(82, 193, 119);
                    uiUnosKorisnickogImena.ForeColor = Color.White;
               
                }
            }
            korIme = true;
        }

        private void uiUnosEmaila_TextChanged(object sender, EventArgs e)
        {
            email = false;

            using (var db = new Entities1())
            {
                var email = from k in db.Korisnik
                            select k.Email;

                popisEmaila = email.ToList();
            }

            if (IsValidEmail(uiUnosEmaila.Text))
            {
                uiUnosEmaila.BackColor = Color.FromArgb(82, 193, 119);
                uiUnosEmaila.ForeColor = Color.White;
                foreach (var item in popisEmaila)
                {
                    if (item == uiUnosEmaila.Text)
                    {
                        uiUnosEmaila.BackColor = Color.FromArgb(243, 92, 99);
                        uiUnosEmaila.ForeColor = Color.White;
                        break;
                    }
                    else if (uiUnosEmaila.Text == "")
                    {
                        uiUnosEmaila.BackColor = Color.FromArgb(243, 92, 99);
                        uiUnosEmaila.ForeColor = Color.White;
                    }
                    else
                    {
                        uiUnosEmaila.BackColor = Color.FromArgb(82, 193, 119);
                        uiUnosEmaila.ForeColor = Color.White;
                    }
                }
            }
            else if (uiUnosEmaila.Text == "")
            {
                uiUnosEmaila.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosEmaila.ForeColor = Color.White;
            }
            else
            {
                uiUnosEmaila.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosEmaila.ForeColor = Color.White;
            }
            email = true;

        }

        private void uiUnosOIB_TextChanged(object sender, EventArgs e)
        {
            oib = false;
            using (var db = new Entities1())
            {
                var oib = from k in db.Korisnik
                          select k.OIB;
                popisOIB = oib.ToList();
            }

            if (IsValidOIB(uiUnosOIB.Text))
            {
                uiUnosOIB.BackColor = Color.FromArgb(82, 193, 119);
                uiUnosOIB.ForeColor = Color.White;
                foreach (var item in popisOIB)
                {
                    if (item == uiUnosOIB.Text)
                    {
                        uiUnosOIB.BackColor = Color.FromArgb(243, 92, 99);
                        uiUnosOIB.ForeColor = Color.White;
                        break;
                    }
                    else if (uiUnosOIB.Text == "")
                    {
                        uiUnosOIB.BackColor = Color.FromArgb(243, 92, 99);
                        uiUnosOIB.ForeColor = Color.White;
                    }

                }
            }
            else if (uiUnosOIB.Text == "")
            {
                uiUnosOIB.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosOIB.ForeColor = Color.White;
            }
            else
            {
                uiUnosOIB.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosOIB.ForeColor = Color.White;
            }
            oib = true;
        }
    }
}
