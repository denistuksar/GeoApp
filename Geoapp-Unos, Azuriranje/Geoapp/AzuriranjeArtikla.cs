using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Geoapp
{
    public partial class AzuriranjeArtikla : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        SqlCommand cmd;
        private string con = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=19038_DB;Persist Security Info=True;User ID=19038_User;Password=xPTd7irG";
        int ID = 0;

        public AzuriranjeArtikla()
        {
            InitializeComponent();
        }

        private void AzuriranjeArtikla_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AzuriranjeArtikla_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void AzuriranjeArtikla_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Pocetna unos = new Pocetna();
            unos.ShowDialog();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(211, 211, 211);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void gumbAzuriraj_Click(object sender, EventArgs e)
        {
            if (nazivArtikla.Text != "" && opisArtikla.Text != "" && proizvodacArtikla.Text != "" && cijenaArtikla.Text != "" && serijskiBrojArtikla.Text != "")
            {
                SqlConnection konekcija = new SqlConnection(con);
                konekcija.Open();
                cmd = new SqlCommand("update Artikl set Naziv=@naziv,Opis=@opis,Proizvodac=@proizvodac,Cijena=@cijena,Serijski_broj=@serijski where ID_artikla=@id", konekcija);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@naziv", nazivArtikla.Text);
                cmd.Parameters.AddWithValue("@opis", opisArtikla.Text);
                cmd.Parameters.AddWithValue("@proizvodac", proizvodacArtikla.Text);
                cmd.Parameters.AddWithValue("@cijena", cijenaArtikla.Text);
                cmd.Parameters.AddWithValue("@serijski", serijskiBrojArtikla.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Artikl uspješno ažuriran");
                konekcija.Close();
                ClearData();
                this.artiklTableAdapter.Fill(this._19038_DBDataSet.Artikl);
            }
            else
            {
                MessageBox.Show("Odaberite artikl koji želite ažurirati");
            }
        }

        private void AzuriranjeArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19038_DBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this._19038_DBDataSet.Artikl);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            nazivArtikla.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            opisArtikla.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            proizvodacArtikla.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cijenaArtikla.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            serijskiBrojArtikla.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void gumbIzbrisi_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlConnection konekcija = new SqlConnection(con);
                konekcija.Open();
                cmd = new SqlCommand("delete Artikl where ID_artikla=@id", konekcija);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Artikl uspješno izbrisan!");
                ClearData();
                this.artiklTableAdapter.Fill(this._19038_DBDataSet.Artikl);
            }
            else
            {
                MessageBox.Show("Odaberite artikl koji želite izbrisati");
            }
        }

        private void ClearData()
        {
            nazivArtikla.Text = "";
            opisArtikla.Text = "";
            proizvodacArtikla.Text = "";
            cijenaArtikla.Text = "";
            serijskiBrojArtikla.Text = "";
            ID = 0;
        }
    }
}
