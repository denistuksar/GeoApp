using System;
using System.Data;
using System.Linq;
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
            using (var db = new Entities())
            {
                var query = from k in db.Korisnik
                            where k.Korisnicko_ime == korisnickoIme.Text && k.Lozinka == lozinka.Text
                            select k;
                if (query.SingleOrDefault() != null)
                {
                    var query2 = from k in db.Korisnik
                                 where k.Korisnicko_ime == korisnickoIme.Text
                                 select k.Uloga.Naziv;
                    var uloga = query2.FirstOrDefault<string>();
                    var query3 = from k in db.Korisnik
                                 where k.Korisnicko_ime == korisnickoIme.Text
                                 select k.ID_korisnika; ;
                    var id = query3.FirstOrDefault<int>();
                    LoginInfo.IDKorisnika = id;
                    LoginInfo.Uloga = uloga.ToString();
                    LoginInfo.Korime = korisnickoIme.Text;
                    
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
            this.MaximizeBox = false;
        }

        private void Prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
