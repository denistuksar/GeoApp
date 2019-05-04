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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.MdiParent = this;
            prijava.Show();

        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.MdiParent = this;
            prijava.Show();
        }
    }
}
