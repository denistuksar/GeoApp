using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class DetaljiNarudzbe : Form
    {
        public DetaljiNarudzbe(int idNarudzbe)
        {
            InitializeComponent();
            using (var db = new Entities())
            {
                var query = (from a in db.Artikl
                             join n in db.Stavke_narudzbe on a.ID_artikla equals n.ArtiklID_artikla
                             where n.NarudzbaID_narudzbe == idNarudzbe
                             select new
                             {
                                 a.ID_artikla,
                                 a.Naziv,
                                 a.Opis,
                                 a.Proizvodac,
                                 a.Serijski_broj,
                                 a.Cijena,
                                 n.Kolicina
                             }).ToList();
                dgvDetalji.DataSource = query;

            }
        }

        private void DetaljiNarudzbe_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
