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
            nazivArtikla.Text = dgvArtikli.CurrentRow.Cells[1].Value.ToString();
            opisArtikla.Text = dgvArtikli.CurrentRow.Cells[2].Value.ToString();
            proizvodacArtikla.Text = dgvArtikli.CurrentRow.Cells[3].Value.ToString();
            cijenaArtikla.Text = dgvArtikli.CurrentRow.Cells[4].Value.ToString();
            serijskiBrojArtikla.Text = dgvArtikli.CurrentRow.Cells[5].Value.ToString();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za ažuriranje artikla.
        /// </summary>
        private void gumbAzuriraj_Click(object sender, EventArgs e)
        {
            Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
            if (selektiraniArtikl != null)
            {
                using (var db = new Entities1())
                {
                    db.Artikl.Attach(selektiraniArtikl); //registriramo prosljeđeni tim. 
                    selektiraniArtikl.Naziv = nazivArtikla.Text;
                    selektiraniArtikl.Opis = opisArtikla.Text;
                    selektiraniArtikl.Proizvodac = proizvodacArtikla.Text;
                    selektiraniArtikl.Cijena = decimal.Parse(cijenaArtikla.Text);
                    selektiraniArtikl.Serijski_broj = serijskiBrojArtikla.Text;
                    db.SaveChanges();   //Spremamo promjene u bazu.
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
            dgvArtikli.DataSource = artikli;
            dgvArtikli.Columns[0].HeaderText = "ID artikla";
            dgvArtikli.Columns[3].HeaderText = "Proizvođač";
            dgvArtikli.Columns[5].HeaderText = "Serijski broj";
            dgvArtikli.Columns[6].Visible = false;
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
            if (dgvArtikli.CurrentRow != null)
            {
                Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                if (selektiraniArtikl != null)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite izbrisati artikl?", "Upozorenje!",
       MessageBoxButtons.YesNo) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new Entities1())
                        {
                            //Registriramo artikl.
                            db.Artikl.Attach(selektiraniArtikl);
                            db.Artikl.Remove(selektiraniArtikl);   //Brišemo artikl iz kolekcije
                            db.SaveChanges();    //Spremamo promjene u bazu.
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
                            where a.Naziv.Contains(txtSearch.Text)
                            select a;
                dgvArtikli.DataSource = query.ToList();
            }
            dgvArtikli.Columns[0].HeaderText = "ID artikla";
            dgvArtikli.Columns[3].HeaderText = "Proizvođač";
            dgvArtikli.Columns[5].HeaderText = "Serijski broj";
            dgvArtikli.Columns[6].Visible = false;
        }
    }
}
