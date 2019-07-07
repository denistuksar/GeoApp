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
                if (uiNazivArtikla.Text != "" && uiOpisArtikla.Text != "" && uiProizvodacArtikla.Text != "" && uiCijenaArtikla.Text != "" && uiSerijskiBrojArtikla.Text != "")
                {
                    using (var db = new Entities1())
                    {
                        Artikl artikl = new Artikl
                        {
                            Naziv = uiNazivArtikla.Text,
                            Opis = uiOpisArtikla.Text,
                            Proizvodac = uiProizvodacArtikla.Text,
                            Cijena = decimal.Parse(uiCijenaArtikla.Text),
                            Serijski_broj = uiSerijskiBrojArtikla.Text
                        };
                        db.Artikl.Add(artikl);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Aktikl unesen");
                    uiNazivArtikla.Clear();
                    uiOpisArtikla.Clear();
                    uiProizvodacArtikla.Clear();
                    uiCijenaArtikla.Clear();
                    uiSerijskiBrojArtikla.Clear();
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
            helpUnosArtikla.HelpNamespace = Environment.CurrentDirectory + "/help/unosArtikla.html";   
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
