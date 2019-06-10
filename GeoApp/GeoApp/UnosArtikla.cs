using System;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class UnosArtikla : Form
    {
        
        public UnosArtikla()
        {
            InitializeComponent();
        }
   
        /// <summary>
        /// Rukuje događajem klika na gumb unesi.
        /// </summary>
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                Artikl artikl = new Artikl
                {
                    Naziv = nazivArtikla.Text,
                    Opis = opisArtikla.Text,
                    Proizvodac = proizvodacArtikla.Text,
                    Cijena = decimal.Parse(cijenaArtikla.Text),
                    Serijski_broj = serijskiBrojArtikla.Text    
                };
                db.Artikl.Add(artikl); 
                db.SaveChanges();
            }
            Close();
            this.Hide();
            Pocetna unos = new Pocetna();
            unos.ShowDialog();
            this.Close();
        }

        private void UnosArtikla_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void UnosArtikla_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Pocetna unos = new Pocetna();
            this.Close();
        }
    }
}
