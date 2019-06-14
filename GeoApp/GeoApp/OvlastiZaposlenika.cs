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
    public partial class OvlastiZaposlenika : Form
    {
        public OvlastiZaposlenika()
        {
            InitializeComponent();
        }

        public void PrikaziZaposlene()
        {
            using (var db = new Entities())
            {
                var zaposleni = from z in db.Korisnik
                                where z.UlogaID_uloge == 3
                                select z;

                dgvZaposlenici.DataSource = zaposleni.ToList();
                dgvZaposlenici.Columns[9].Visible = false;
                dgvZaposlenici.Columns[11].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
                dgvZaposlenici.Columns[13].Visible = false;
                dgvZaposlenici.Columns[14].Visible = false;               
            }
        
        }

        private void OvlastiZaposlenika_Load(object sender, EventArgs e)
        {
            PrikaziZaposlene();
        }
    }
}
