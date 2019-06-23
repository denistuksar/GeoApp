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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new Entities1())
            {
                var query = from o in context.Artikl
                            select o;
                List<Artikl> allOrders = query.ToList();
                ArtiklBindingSource.DataSource = allOrders;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
