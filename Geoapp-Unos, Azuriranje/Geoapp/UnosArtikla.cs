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
    public partial class UnosArtikla : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private string con = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=19038_DB;Persist Security Info=True;User ID=19038_User;Password=xPTd7irG";

        public UnosArtikla()
        {
            InitializeComponent();
        }

        private void UnosArtikla_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void UnosArtikla_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void UnosArtikla_MouseUp(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(con);
            konekcija.Open();
            if (konekcija.State == System.Data.ConnectionState.Open)
            {

                string dodajArtikl = "insert into Artikl(Naziv,Opis,Proizvodac,Cijena,Serijski_broj)values('" + nazivArtikla.Text + "','" + opisArtikla.Text + "','" + proizvodacArtikla.Text + "','" + cijenaArtikla.Text + "','" + serijskiBrojArtikla.Text + "')";


                if (nazivArtikla.Text == string.Empty || opisArtikla.Text == string.Empty || proizvodacArtikla.Text == string.Empty || cijenaArtikla.Text == string.Empty || serijskiBrojArtikla.Text == string.Empty)
                {
                    MessageBox.Show("Popunite prazno polje");
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(dodajArtikl, konekcija);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Artikl uspješno unesen");
                    this.Close();
                    Pocetna unos = new Pocetna();
                    unos.ShowDialog();
                }
            }
        }

        private void UnosArtikla_Load(object sender, EventArgs e)
        {

        }
    }
}
