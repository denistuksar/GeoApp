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
            using (var db = new Entities())
            {
                var korIme = from k in db.Korisnik
                             select k.Korisnicko_ime;

                var oib = from k in db.Korisnik
                             select k.OIB;

                var email = from k in db.Korisnik
                            select k.Email;

                if (txtKorIme.Text != "")
                {                   
                    if (korIme.ToString() != txtKorIme.Text)
                    {
                        if (oib.ToString() != txtOib.Text && IsValidOIB(txtOib.Text))
                        {

                            if (email.ToString() != txtEmail.Text && IsValidEmail(txtEmail.Text))
                            {
                                var korisnik = new Korisnik
                                {
                                    Ime = txtIme.Text,
                                    Prezime = txtPrezime.Text,
                                    OIB = txtOib.Text,
                                    Adresa = txtAdresa.Text,
                                    Email = txtEmail.Text,
                                    Broj_telefona = txtTelefon.Text,
                                    Korisnicko_ime = txtKorIme.Text,
                                    Lozinka = Encoding.UTF8.GetBytes(txtLozinka.Text),
                                };
                                db.Korisnik.Add(korisnik);
                                db.SaveChanges();
                                MessageBox.Show("Uspješna registracija");
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
                }

                else
                {
                    MessageBox.Show("Neuspješna registracija");
                }
            }
            this.Close();
        }

    private void natrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.Show();
            this.Close();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
           
        }

        private void Registracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.ShowDialog();
            this.Close();
        }


        public bool IsValidOIB(string oib)
        {
            return Regex.IsMatch(oib, @"^[0-9]{11}$");
        }

        private void txtOib_TextChanged(object sender, EventArgs e)
        {                           
            using (var db = new Entities())
            {
                var oib = from k in db.Korisnik
                          select k.OIB;
               popisOIB = oib.ToList();                          
            }

            if (IsValidOIB(txtOib.Text))
            {
                lbOIB.ForeColor = Color.Green;
                foreach (var item in popisOIB)
                {
                    if (item == txtOib.Text)
                    {
                        lbOIB.ForeColor = Color.Red;
                        lbOIB.Text = "OIB već postoji";
                        break;
                    }
                    else if (txtOib.Text == "")
                    {
                        lbOIB.Text = "";
                    }
                    else
                    {
                        lbOIB.ForeColor = Color.Green;
                        lbOIB.Text = "OIB ne postoji";
                    }
                }
            }
            else if (txtOib.Text == "")
            {
                lbOIB.Text = "";
            }
            else
            {
                lbOIB.ForeColor = Color.Red;
                lbOIB.Text = "OIB nije pravilan";
            }
        }

        private void txtKorIme_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var korisnickoIme = from k in db.Korisnik
                          select k.Korisnicko_ime;

                popisKorisnika = korisnickoIme.ToList();
            }
            foreach (var item in popisKorisnika)
            {
                if (item == txtKorIme.Text)
                {
                    lbKorisnickoIme.ForeColor = Color.Red;
                    lbKorisnickoIme.Text = "Korisnik već postoji";
                    break;
                }
                else if (txtKorIme.Text == "")
                {
                    lbKorisnickoIme.Text = "";
                }
                else
                {
                    lbKorisnickoIme.ForeColor = Color.Green;
                    lbKorisnickoIme.Text = " Slobodno korisničko ime";
                }
            }
        }

        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var email = from k in db.Korisnik
                                    select k.Email;

                popisEmaila = email.ToList();
            }

            if (IsValidEmail(txtEmail.Text))
            {
                lbEmail.ForeColor = Color.Green;
                foreach (var item in popisEmaila)
                {
                    if (item == txtEmail.Text)
                    {
                        lbEmail.ForeColor = Color.Red;
                        lbEmail.Text ="e-mail već postoji";
                        break;
                    }
                    else if (txtEmail.Text == "")
                    {
                        lbEmail.Text = "";
                    }
                    else
                    {
                        lbEmail.ForeColor = Color.Green;
                        lbEmail.Text = " Slobodan e-mail";
                    }
                }
            }
            else
            {
                lbEmail.ForeColor = Color.Red;
                lbEmail.Text = " nepravilno napisan mail";
            }
        }
    }
}
