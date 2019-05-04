using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class Registracija : Form
    {
        private string con = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=19038_DB;Persist Security Info=True;User ID=19038_User;Password=xPTd7irG"; Prijava prijava = new Prijava();


        public Registracija()
        {
            InitializeComponent();
        }

        private void registriraj_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(con);
            konekcija.Open();
            if (konekcija.State == System.Data.ConnectionState.Open)
            {
             

                string dodajKorisnik = "insert into Korisnik(Ime,Prezime,OIB,Adresa,Email,Broj_telefona,Korisnicko_ime,Lozinka)values('" + ime.Text + "','" + prezime.Text + "','" + oib.Text + "','" + adresa.Text + "','" + email.Text + "','" + brojTelefona.Text + "','" + korisnickoIme.Text + "','" + lozinka.Text + "')";
                SqlCommand cmd = new SqlCommand(dodajKorisnik, konekcija); 
                cmd.ExecuteNonQuery();

                MessageBox.Show("Uspješno ste se registrirali");
                this.Close();
                prijava.Show();
            }
        }

        private void natrag_Click(object sender, EventArgs e)
        {
            this.Close();


            prijava.Show();
        }
    }
}
