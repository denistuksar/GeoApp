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
            using (var db = new GeoEntities())
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
                                if (LoginInfo.Uloga == "Administrator")
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
                                        Kriptirana_Lozinka = Encoding.UTF8.GetBytes(txtLozinka.Text),
                                        Lozinka = txtLozinka.Text,
                                        UlogaID_uloge = 3,            
                                        OvlastiID_ovlast = 4                                       
                                    };
                                    OvlastInfo.IDOvlasti = 4;

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
                                        Ime = txtIme.Text,
                                        Prezime = txtPrezime.Text,
                                        OIB = txtOib.Text,
                                        Adresa = txtAdresa.Text,
                                        Email = txtEmail.Text,
                                        Broj_telefona = txtTelefon.Text,
                                        Korisnicko_ime = txtKorIme.Text,
                                        Kriptirana_Lozinka = Encoding.UTF8.GetBytes(txtLozinka.Text),
                                        Lozinka = txtLozinka.Text,
                                        UlogaID_uloge = 2,
                                        OvlastiID_ovlast = 4
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
            using (var db = new GeoEntities())
            {
                var oib = from k in db.Korisnik
                          select k.OIB;
                popisOIB = oib.ToList();
            }

            if (IsValidOIB(txtOib.Text))
            {
                txtOib.BackColor = Color.FromArgb(82, 193, 119);
                txtOib.ForeColor = Color.White;
                foreach (var item in popisOIB)
                {
                    if (item == txtOib.Text)
                    {
                        txtOib.BackColor = Color.FromArgb(243, 92, 99);
                        txtOib.ForeColor = Color.White;
                        break;
                    }
                    else if (txtOib.Text == "")
                    {
                        txtOib.BackColor = Color.FromArgb(243, 92, 99);
                        txtOib.ForeColor = Color.White;
                    }

                }
            }
            else if (txtOib.Text == "")
            {
                txtOib.BackColor = Color.FromArgb(243, 92, 99);
                txtOib.ForeColor = Color.White;
            }
            else
            {
                txtOib.BackColor = Color.FromArgb(243, 92, 99);
                txtOib.ForeColor = Color.White;
            }
        }

        private void txtKorIme_TextChanged(object sender, EventArgs e)
        {
            using (var db = new GeoEntities())
            {
                var korisnickoIme = from k in db.Korisnik
                                    select k.Korisnicko_ime;

                popisKorisnika = korisnickoIme.ToList();
            }
            foreach (var item in popisKorisnika)
            {
                if (item == txtKorIme.Text)
                {
                    txtKorIme.BackColor = Color.FromArgb(243, 92, 99);
                    txtKorIme.ForeColor = Color.White;
                    break;
                }
                else if (txtKorIme.Text == "")
                {
                    txtKorIme.BackColor = Color.FromArgb(243, 92, 99);
                    txtKorIme.ForeColor = Color.White;
                }
                else
                {
                    txtKorIme.BackColor = Color.FromArgb(82, 193, 119);
                    txtKorIme.ForeColor = Color.White;
                }
            }
        }

        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            using (var db = new GeoEntities())
            {
                var email = from k in db.Korisnik
                            select k.Email;

                popisEmaila = email.ToList();
            }

            if (IsValidEmail(txtEmail.Text))
            {
                txtEmail.BackColor = Color.FromArgb(82, 193, 119);
                txtEmail.ForeColor = Color.White;
                foreach (var item in popisEmaila)
                {
                    if (item == txtEmail.Text)
                    {
                        txtEmail.BackColor = Color.FromArgb(243, 92, 99);
                        txtEmail.ForeColor = Color.White;
                        break;
                    }
                    else if (txtEmail.Text == "")
                    {
                        txtEmail.BackColor = Color.FromArgb(243, 92, 99);
                        txtEmail.ForeColor = Color.White;
                    }
                    else
                    {
                        txtEmail.BackColor = Color.FromArgb(82, 193, 119);
                        txtEmail.ForeColor = Color.White;
                    }
                }
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.BackColor = Color.FromArgb(243, 92, 99);
                txtEmail.ForeColor = Color.White;
            }
            else
            {
                txtEmail.BackColor = Color.FromArgb(243, 92, 99);
                txtEmail.ForeColor = Color.White;
            }
        }

        private void txtPonovi_TextChanged(object sender, EventArgs e)
        {
            if (txtPonovi.Text == "")
            {
                txtPonovi.BackColor = Color.FromArgb(243, 92, 99);
                txtPonovi.ForeColor = Color.White;
            }

            else if (txtLozinka.Text == txtPonovi.Text)
            {
                txtPonovi.BackColor = Color.FromArgb(82, 193, 119);
                txtPonovi.ForeColor = Color.White;
            }
          

            else
            {
                txtPonovi.BackColor = Color.FromArgb(243,92,99);
                txtPonovi.ForeColor = Color.White;
            }
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            if (txtPonovi.Text == "")
            {
                txtPonovi.BackColor = Color.White;
            }

            else if (txtLozinka.Text == txtPonovi.Text)
            {
                txtPonovi.BackColor = Color.FromArgb(82, 193, 119);
                txtPonovi.ForeColor = Color.White;
            }


            else
            {
                txtPonovi.BackColor = Color.FromArgb(243, 92, 99);
                txtPonovi.ForeColor = Color.White;
            }
        }
    }

}
