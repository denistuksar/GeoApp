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
    public partial class Prijava : Form
    {
        private string con = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=19038_DB;Persist Security Info=True;User ID=19038_User;Password=xPTd7irG";

        public Prijava()
        {
            InitializeComponent();
        }


        private void prijava2_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(con);
            konekcija.Open();
            if (konekcija.State == System.Data.ConnectionState.Open)
            {
                string prijava = "Select * from Korisnik Where Korisnicko_ime = '" + korisnickoIme.Text + "'and lozinka='" + lozinka.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(prijava, konekcija);
                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count == 1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Krivo korisničko ime ili lozinka");
                }
            }
        }

        private void registriraj_Click(object sender, EventArgs e)
        {
            this.Close();

            Registracija registracija = new Registracija();
            registracija.Show();
        }
    }
}
