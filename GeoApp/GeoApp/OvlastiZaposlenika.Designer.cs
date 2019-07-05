namespace GeoApp
{
    partial class OvlastiZaposlenika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.uiPrikaziKorisnike = new System.Windows.Forms.DataGridView();
            this.uiDodajZaposlenika = new System.Windows.Forms.Button();
            this.uiUDZaposlenika = new System.Windows.Forms.Button();
            this.uiPrikaziZaposlenike = new System.Windows.Forms.Button();
            this.uiPromjeniUlogu = new System.Windows.Forms.Button();
            this.helpOvlasti = new System.Windows.Forms.HelpProvider();
            this.uiOdabraniAdministrator = new System.Windows.Forms.RadioButton();
            this.uiOdabraniZaposlenik = new System.Windows.Forms.RadioButton();
            this.uiOdabraniKupac = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikaziKorisnike)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaposlenici:";
            // 
            // uiPrikaziKorisnike
            // 
            this.uiPrikaziKorisnike.AllowUserToAddRows = false;
            this.uiPrikaziKorisnike.AllowUserToDeleteRows = false;
            this.uiPrikaziKorisnike.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.uiPrikaziKorisnike.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikaziKorisnike.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiPrikaziKorisnike.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiPrikaziKorisnike.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uiPrikaziKorisnike.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiPrikaziKorisnike.DefaultCellStyle = dataGridViewCellStyle2;
            this.uiPrikaziKorisnike.EnableHeadersVisualStyles = false;
            this.uiPrikaziKorisnike.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiPrikaziKorisnike.Location = new System.Drawing.Point(16, 84);
            this.uiPrikaziKorisnike.Name = "uiPrikaziKorisnike";
            this.uiPrikaziKorisnike.ReadOnly = true;
            this.uiPrikaziKorisnike.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiPrikaziKorisnike.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.uiPrikaziKorisnike.RowHeadersVisible = false;
            this.uiPrikaziKorisnike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikaziKorisnike.Size = new System.Drawing.Size(690, 216);
            this.uiPrikaziKorisnike.TabIndex = 20;
            this.uiPrikaziKorisnike.SelectionChanged += new System.EventHandler(this.dgvZaposlenici_SelectionChanged);
            // 
            // uiDodajZaposlenika
            // 
            this.uiDodajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiDodajZaposlenika.FlatAppearance.BorderSize = 0;
            this.uiDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDodajZaposlenika.ForeColor = System.Drawing.SystemColors.Control;
            this.uiDodajZaposlenika.Location = new System.Drawing.Point(139, 16);
            this.uiDodajZaposlenika.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiDodajZaposlenika.Name = "uiDodajZaposlenika";
            this.uiDodajZaposlenika.Size = new System.Drawing.Size(148, 32);
            this.uiDodajZaposlenika.TabIndex = 35;
            this.uiDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.uiDodajZaposlenika.UseVisualStyleBackColor = false;
            this.uiDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // uiUDZaposlenika
            // 
            this.uiUDZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiUDZaposlenika.FlatAppearance.BorderSize = 0;
            this.uiUDZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiUDZaposlenika.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUDZaposlenika.ForeColor = System.Drawing.SystemColors.Control;
            this.uiUDZaposlenika.Location = new System.Drawing.Point(310, 16);
            this.uiUDZaposlenika.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiUDZaposlenika.Name = "uiUDZaposlenika";
            this.uiUDZaposlenika.Size = new System.Drawing.Size(208, 32);
            this.uiUDZaposlenika.TabIndex = 36;
            this.uiUDZaposlenika.Text = "Ažuriraj/Izbriši korisnika";
            this.uiUDZaposlenika.UseVisualStyleBackColor = false;
            this.uiUDZaposlenika.Click += new System.EventHandler(this.btnAzurirajZaposlenika_Click);
            // 
            // uiPrikaziZaposlenike
            // 
            this.uiPrikaziZaposlenike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiPrikaziZaposlenike.FlatAppearance.BorderSize = 0;
            this.uiPrikaziZaposlenike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPrikaziZaposlenike.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPrikaziZaposlenike.ForeColor = System.Drawing.SystemColors.Control;
            this.uiPrikaziZaposlenike.Location = new System.Drawing.Point(544, 16);
            this.uiPrikaziZaposlenike.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiPrikaziZaposlenike.Name = "uiPrikaziZaposlenike";
            this.uiPrikaziZaposlenike.Size = new System.Drawing.Size(150, 32);
            this.uiPrikaziZaposlenike.TabIndex = 37;
            this.uiPrikaziZaposlenike.Text = "Prikaži zaposlenike";
            this.uiPrikaziZaposlenike.UseVisualStyleBackColor = false;
            this.uiPrikaziZaposlenike.Click += new System.EventHandler(this.btnPrikaziZaposlene_Click);
            // 
            // uiPromjeniUlogu
            // 
            this.uiPromjeniUlogu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiPromjeniUlogu.FlatAppearance.BorderSize = 0;
            this.uiPromjeniUlogu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPromjeniUlogu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPromjeniUlogu.ForeColor = System.Drawing.SystemColors.Control;
            this.uiPromjeniUlogu.Location = new System.Drawing.Point(491, 325);
            this.uiPromjeniUlogu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiPromjeniUlogu.Name = "uiPromjeniUlogu";
            this.uiPromjeniUlogu.Size = new System.Drawing.Size(203, 32);
            this.uiPromjeniUlogu.TabIndex = 46;
            this.uiPromjeniUlogu.Text = "Promijeni ulogu";
            this.uiPromjeniUlogu.UseVisualStyleBackColor = false;
            this.uiPromjeniUlogu.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiOdabraniAdministrator
            // 
            this.uiOdabraniAdministrator.AutoSize = true;
            this.uiOdabraniAdministrator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uiOdabraniAdministrator.ForeColor = System.Drawing.SystemColors.Control;
            this.uiOdabraniAdministrator.Location = new System.Drawing.Point(35, 329);
            this.uiOdabraniAdministrator.Name = "uiOdabraniAdministrator";
            this.uiOdabraniAdministrator.Size = new System.Drawing.Size(124, 25);
            this.uiOdabraniAdministrator.TabIndex = 47;
            this.uiOdabraniAdministrator.TabStop = true;
            this.uiOdabraniAdministrator.Text = "Administrator";
            this.uiOdabraniAdministrator.UseVisualStyleBackColor = true;
            // 
            // uiOdabraniZaposlenik
            // 
            this.uiOdabraniZaposlenik.AutoSize = true;
            this.uiOdabraniZaposlenik.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uiOdabraniZaposlenik.ForeColor = System.Drawing.SystemColors.Control;
            this.uiOdabraniZaposlenik.Location = new System.Drawing.Point(201, 329);
            this.uiOdabraniZaposlenik.Name = "uiOdabraniZaposlenik";
            this.uiOdabraniZaposlenik.Size = new System.Drawing.Size(103, 25);
            this.uiOdabraniZaposlenik.TabIndex = 48;
            this.uiOdabraniZaposlenik.TabStop = true;
            this.uiOdabraniZaposlenik.Text = "Zaposlenik";
            this.uiOdabraniZaposlenik.UseVisualStyleBackColor = true;
            // 
            // uiOdabraniKupac
            // 
            this.uiOdabraniKupac.AutoSize = true;
            this.uiOdabraniKupac.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uiOdabraniKupac.ForeColor = System.Drawing.SystemColors.Control;
            this.uiOdabraniKupac.Location = new System.Drawing.Point(360, 329);
            this.uiOdabraniKupac.Name = "uiOdabraniKupac";
            this.uiOdabraniKupac.Size = new System.Drawing.Size(70, 25);
            this.uiOdabraniKupac.TabIndex = 49;
            this.uiOdabraniKupac.TabStop = true;
            this.uiOdabraniKupac.Text = "Kupac";
            this.uiOdabraniKupac.UseVisualStyleBackColor = true;
            // 
            // OvlastiZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(731, 386);
            this.Controls.Add(this.uiOdabraniKupac);
            this.Controls.Add(this.uiOdabraniZaposlenik);
            this.Controls.Add(this.uiOdabraniAdministrator);
            this.Controls.Add(this.uiPromjeniUlogu);
            this.Controls.Add(this.uiPrikaziZaposlenike);
            this.Controls.Add(this.uiUDZaposlenika);
            this.Controls.Add(this.uiDodajZaposlenika);
            this.Controls.Add(this.uiPrikaziKorisnike);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OvlastiZaposlenika";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpOvlasti.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje uloga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OvlastiZaposlenika_FormClosed);
            this.Load += new System.EventHandler(this.OvlastiZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikaziKorisnike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiPrikaziKorisnike;
        private System.Windows.Forms.Button uiDodajZaposlenika;
        private System.Windows.Forms.Button uiUDZaposlenika;
        private System.Windows.Forms.Button uiPrikaziZaposlenike;
        private System.Windows.Forms.Button uiPromjeniUlogu;
        private System.Windows.Forms.HelpProvider helpOvlasti;
        private System.Windows.Forms.RadioButton uiOdabraniAdministrator;
        private System.Windows.Forms.RadioButton uiOdabraniZaposlenik;
        private System.Windows.Forms.RadioButton uiOdabraniKupac;
    }
}