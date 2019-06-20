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
            try
            {
                if (nazivArtikla.Text != "" && opisArtikla.Text != "" && proizvodacArtikla.Text != "" && cijenaArtikla.Text != "" && serijskiBrojArtikla.Text != "")
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
                    MessageBox.Show("Aktikl unešen.");
                    nazivArtikla.Clear();
                    opisArtikla.Clear();
                    proizvodacArtikla.Clear();
                    cijenaArtikla.Clear();
                    serijskiBrojArtikla.Clear();
                }
                else
                {
                    MessageBox.Show("Ispunite sva polja");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Neispravan unos.");
            }
        }

        private void UnosArtikla_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void UnosArtikla_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Pocetna unos = new Pocetna();
            unos.ShowDialog();
            this.Close();
        }
    }
}
