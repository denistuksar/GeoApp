using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class Registracija : Form
    {
        List<string> popisOIB;
        List<string> popisKorisnika;
        List<string> popisEmaila;


        public Registracija()
        {
            InitializeComponent();

        }

        private void registriraj_Click(object sender, EventArgs e)
        {
            using (var db = new Entities1())
            {
                var korIme = from k in db.Korisnik
                             select k.Korisnicko_ime;

                var oib = from k in db.Korisnik
                          select k.OIB;

                var email = from k in db.Korisnik
                            select k.Email;

                if (uiUnosKorisnickogImena.Text != "")
                {
                    if (korIme.ToString() != uiUnosKorisnickogImena.Text)
                    {
                        if (oib.ToString() != uiUnosOIB.Text && IsValidOIB(uiUnosOIB.Text))
                        {
                            if (email.ToString() != uiUnosEmaila.Text && IsValidEmail(uiUnosEmaila.Text))
                            {
                                if (LoginInfo.Uloga == "Administrator")
                                {
                                    
                                    var korisnik = new Korisnik
                                    {
                                        Ime = uiUnosImena.Text,
                                        Prezime = uiUnosPrezimena.Text,
                                        OIB = uiUnosOIB.Text,
                                        Adresa = uiUnosAdrese.Text,
                                        Email = uiUnosEmaila.Text,
                                        Broj_telefona = uiUnosTelefona.Text,
                                        Korisnicko_ime = uiUnosKorisnickogImena.Text,
                                        Kriptirana_Lozinka = Encoding.UTF8.GetBytes(uiUnosLozinke.Text),
                                        Lozinka = uiUnosLozinke.Text,
                                        UlogaID_uloge = 3,
                                     
                                    };

                                  
                                    db.Korisnik.Add(korisnik);
                                    db.SaveChanges();
                                    MessageBox.Show("Uspješno dodan zaposlenik");

                                    this.Hide();
                                    OvlastiZaposlenika ovlastiZaposlenika = new OvlastiZaposlenika();
                                    ovlastiZaposlenika.ShowDialog();
                                    this.Close();

                                }
                                else
                                {
                                    var korisnik = new Korisnik
                                    {
                                        Ime = uiUnosImena.Text,
                                        Prezime = uiUnosPrezimena.Text,
                                        OIB = uiUnosOIB.Text,
                                        Adresa = uiUnosAdrese.Text,
                                        Email = uiUnosEmaila.Text,
                                        Broj_telefona = uiUnosTelefona.Text,
                                        Korisnicko_ime = uiUnosKorisnickogImena.Text,
                                        Kriptirana_Lozinka = Encoding.UTF8.GetBytes(uiUnosLozinke.Text),
                                        Lozinka = uiUnosLozinke.Text,
                                        UlogaID_uloge = 2,
                                      
                                    };
                                    db.Korisnik.Add(korisnik);
                                    db.SaveChanges();
                                    MessageBox.Show("Uspješna registracija");
                                }
                            }
                            else
                            {
                                MessageBox.Show("E-mail postoji! ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("OIB postoji! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Korisničko ime postoji! ");
                    }
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Neuspješna registracija");
                }
            }

        }

        private void natrag_Click(object sender, EventArgs e)
        {

            if (LoginInfo.IDKorisnika == 0)
            {
                this.Hide();
                Prijava prijava = new Prijava();
                prijava.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();

                this.Close();
            }
        }



        private void Registracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginInfo.IDKorisnika == 0)
            {
                this.Hide();
                Prijava prijava = new Prijava();
                prijava.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();

                this.Close();
            }

        }


        public bool IsValidOIB(string oib)
        {
            return Regex.IsMatch(oib, @"^[0-9]{11}$");
        }

        private void txtOib_TextChanged(object sender, EventArgs e)
        {
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
        }

        private void txtKorIme_TextChanged(object sender, EventArgs e)
        {
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
        }

        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
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
        }

        private void txtPonovi_TextChanged(object sender, EventArgs e)
        {
            if (uiUnosPonovljeneLozinke.Text == "")
            {
                uiUnosPonovljeneLozinke.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosPonovljeneLozinke.ForeColor = Color.White;
            }

            else if (uiUnosLozinke.Text == uiUnosPonovljeneLozinke.Text)
            {
                uiUnosPonovljeneLozinke.BackColor = Color.FromArgb(82, 193, 119);
                uiUnosPonovljeneLozinke.ForeColor = Color.White;
            }


            else
            {
                uiUnosPonovljeneLozinke.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosPonovljeneLozinke.ForeColor = Color.White;
            }
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            if (uiUnosPonovljeneLozinke.Text == "")
            {
                uiUnosPonovljeneLozinke.BackColor = Color.White;
            }

            else if (uiUnosLozinke.Text == uiUnosPonovljeneLozinke.Text)
            {
                uiUnosPonovljeneLozinke.BackColor = Color.FromArgb(82, 193, 119);
                uiUnosPonovljeneLozinke.ForeColor = Color.White;
            }


            else
            {
                uiUnosPonovljeneLozinke.BackColor = Color.FromArgb(243, 92, 99);
                uiUnosPonovljeneLozinke.ForeColor = Color.White;
            }
        }

     

        private void Registracija_Load_1(object sender, EventArgs e)
        {
            if (LoginInfo.Uloga == "Administrator")
            {
                uiRegistrirajKorisnika.Text = "Dodaj zaposlenika";
                this.Text = "Unos zaposlenika";

            }

            helpRegistracija.HelpNamespace = Environment.CurrentDirectory + "/help/registracija.html";
        }
    }

}
