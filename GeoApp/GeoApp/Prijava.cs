using System;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace GeoApp
{
    public partial class Prijava : Form
    {

        public Prijava()
        {
            InitializeComponent();
        }


        private void prijava2_Click(object sender, EventArgs e)
        {
            using (var db = new Entities1())
            {
                byte[] lozinka = Encoding.UTF8.GetBytes(txtLozinka.Text);

                var query = from k in db.Korisnik
                            where k.Korisnicko_ime == txtKorisnickoIme.Text && k.Kriptirana_Lozinka == lozinka
                            select k;

                if (query.SingleOrDefault() != null)
                {
                    var query2 = from k in db.Korisnik
                                 where k.Korisnicko_ime == txtKorisnickoIme.Text
                                 select k.Uloga.Naziv;

                    var uloga = query2.FirstOrDefault<string>();

                    var query3 = from k in db.Korisnik
                                 where k.Korisnicko_ime == txtKorisnickoIme.Text
                                 select k.ID_korisnika;

                    var id = query3.FirstOrDefault<int>();

                    LoginInfo.IDKorisnika = id;
                    LoginInfo.Uloga = uloga.ToString();
                    LoginInfo.Korime = txtKorisnickoIme.Text;
                  

                    this.Hide();
                    Pocetna pocetna = new Pocetna();
                    pocetna.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka");
                }
            }
        }

        private void registriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
            this.Close();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            helpPrijava.HelpNamespace = System.AppDomain.CurrentDomain.BaseDirectory + "help/prijava.html";

            this.MaximizeBox = false;
        }

        private void Prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }
    }
}
