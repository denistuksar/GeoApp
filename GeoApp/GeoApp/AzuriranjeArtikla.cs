using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace GeoApp
{
    public partial class AzuriranjeArtikla : Form
    {
        public AzuriranjeArtikla()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem promjene selektiranog retka u tablici.
        /// </summary>
        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            uiNazivArtikla.Text = uiPrikazArtikala.CurrentRow.Cells[1].Value.ToString();
            uiOpisArtikla.Text = uiPrikazArtikala.CurrentRow.Cells[2].Value.ToString();
            uiProizvodacArtikla.Text = uiPrikazArtikala.CurrentRow.Cells[3].Value.ToString();
            uiCijenaArtikla.Text = uiPrikazArtikala.CurrentRow.Cells[4].Value.ToString();
            uiSerijskiBrojArtikla.Text = uiPrikazArtikala.CurrentRow.Cells[5].Value.ToString();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za ažuriranje artikla.
        /// </summary>
        private void gumbAzuriraj_Click(object sender, EventArgs e)
        {
            Artikl selektiraniArtikl = uiPrikazArtikala.CurrentRow.DataBoundItem as Artikl;
            if (selektiraniArtikl != null)
            {
                try
                {
                    if (uiNazivArtikla.Text != "" && uiOpisArtikla.Text != "" && uiProizvodacArtikla.Text != "" && uiCijenaArtikla.Text != "" && uiSerijskiBrojArtikla.Text != "")
                    {
                        using (var db = new Entities1())
                        {
                        db.Artikl.Attach(selektiraniArtikl); //registriramo prosljeđeni tim. 
                        selektiraniArtikl.Naziv = uiNazivArtikla.Text;
                        selektiraniArtikl.Opis = uiOpisArtikla.Text;
                        selektiraniArtikl.Proizvodac = uiProizvodacArtikla.Text;
                        selektiraniArtikl.Cijena = decimal.Parse(uiCijenaArtikla.Text);
                        selektiraniArtikl.Serijski_broj = uiSerijskiBrojArtikla.Text;
                        db.SaveChanges();   //Spremamo promjene u bazu.
                        }
                        MessageBox.Show("Artikl ažuriran.");
                    }
                    else
                    {
                        MessageBox.Show("Ispunite sva polja");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Neispravan unos.");
                }
            }
            else
            {
                MessageBox.Show("Odaberite artikl koji želite ažurirati");
            }
            PrikaziArtikle();
        }

        /// <summary>
        /// Dohvaća listu svih artikla iz kolekcije artikla u kontekstu, te ih prikazuje
        /// u DataGridViewu.
        /// </summary>
        private void PrikaziArtikle()
        {
            List<Artikl> artikli;
            using (var db = new Entities1())
            {
                artikli = db.Artikl.ToList();
            }
            uiPrikazArtikala.DataSource = artikli;
            uiPrikazArtikala.Columns[0].HeaderText = "ID artikla";
            uiPrikazArtikala.Columns[3].HeaderText = "Proizvođač";
            uiPrikazArtikala.Columns[5].HeaderText = "Serijski broj";
            uiPrikazArtikala.Columns[6].Visible = false;
        }
  
        private void AzuriranjeArtikla_Load(object sender, EventArgs e)
        {
            helpAzuriranjeArtikla.HelpNamespace = Environment.CurrentDirectory + "/help/azuriranjeArtikla.html";
            PrikaziArtikle();
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za brisanje artikla.
        /// </summary>
        private void gumbIzbrisi_Click(object sender, EventArgs e)
        {
            if (uiPrikazArtikala.CurrentRow != null)
            {
                Artikl selektiraniArtikl = uiPrikazArtikala.CurrentRow.DataBoundItem as Artikl;
                if (selektiraniArtikl != null)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite izbrisati artikl?", "Upozorenje!",
       MessageBoxButtons.YesNo) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            using (var db = new Entities1())
                            {
                                //Registriramo artikl.
                                db.Artikl.Attach(selektiraniArtikl);
                                db.Artikl.Remove(selektiraniArtikl);   //Brišemo artikl iz kolekcije
                                db.SaveChanges();    //Spremamo promjene u bazu.
                            }
                        }
                        catch (Exception)
                        {

                            if (MessageBox.Show("Artikl se nalazi u nekim narudžbama. Jeste li sigurni da ga želite izbrisati?", "Upozorenje!",
               MessageBoxButtons.YesNo) ==
                                System.Windows.Forms.DialogResult.Yes)
                            {
                                using (var db = new Entities1())
                                {
                                    var query = from n in db.Stavke_narudzbe
                                                where n.ArtiklID_artikla == selektiraniArtikl.ID_artikla
                                                select n.NarudzbaID_narudzbe;
                                    db.Stavke_narudzbe.RemoveRange(db.Stavke_narudzbe.Where(x => x.ArtiklID_artikla == selektiraniArtikl.ID_artikla));
                                    
                                    foreach (var item in query)
                                    {
                                        db.Stavke_narudzbe.RemoveRange(db.Stavke_narudzbe.Where(x => x.NarudzbaID_narudzbe == item));
                                        db.Narudzba.RemoveRange(db.Narudzba.Where(x => x.ID_narudzbe == item));
                                    }
                                    db.Artikl.Attach(selektiraniArtikl);
                                    db.Artikl.Remove(selektiraniArtikl);
                                    db.SaveChanges();
                                }  
                            }
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite artikl koji želite izbrisati");
                }
                PrikaziArtikle();
            }
        }

        private void AzuriranjeArtikla_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Pocetna unos = new Pocetna();
            unos.ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Entities1())
            {
                var query = from a in db.Artikl
                            where a.Naziv.Contains(uiSearch.Text)
                            select a;
                uiPrikazArtikala.DataSource = query.ToList();
            }
            uiPrikazArtikala.Columns[0].HeaderText = "ID artikla";
            uiPrikazArtikala.Columns[3].HeaderText = "Proizvođač";
            uiPrikazArtikala.Columns[5].HeaderText = "Serijski broj";
            uiPrikazArtikala.Columns[6].Visible = false;
        }
    }
}
