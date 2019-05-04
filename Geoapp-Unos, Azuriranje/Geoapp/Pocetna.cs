using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geoapp
{
    public partial class Pocetna : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(211, 211, 211);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void unosUredaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosArtikla unos = new UnosArtikla();
            unos.Show();
        }

        private void azuriranjeUredaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            AzuriranjeArtikla azuriranje = new AzuriranjeArtikla();
            azuriranje.Show();
        }
    }
}
