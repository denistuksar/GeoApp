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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnAzurirajZaposlenika = new System.Windows.Forms.Button();
            this.btnPrikaziZaposlene = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbNarudzba = new System.Windows.Forms.CheckBox();
            this.cbBezOvlasti = new System.Windows.Forms.CheckBox();
            this.cbCRUD = new System.Windows.Forms.CheckBox();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.helpOvlasti = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
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
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.dgvZaposlenici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvZaposlenici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvZaposlenici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposlenici.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenici.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposlenici.EnableHeadersVisualStyles = false;
            this.dgvZaposlenici.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvZaposlenici.Location = new System.Drawing.Point(16, 84);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZaposlenici.RowHeadersVisible = false;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(690, 216);
            this.dgvZaposlenici.TabIndex = 20;
            this.dgvZaposlenici.SelectionChanged += new System.EventHandler(this.dgvZaposlenici_SelectionChanged);
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.btnDodajZaposlenika.FlatAppearance.BorderSize = 0;
            this.btnDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZaposlenika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(139, 16);
            this.btnDodajZaposlenika.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(148, 32);
            this.btnDodajZaposlenika.TabIndex = 35;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnAzurirajZaposlenika
            // 
            this.btnAzurirajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.btnAzurirajZaposlenika.FlatAppearance.BorderSize = 0;
            this.btnAzurirajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajZaposlenika.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajZaposlenika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAzurirajZaposlenika.Location = new System.Drawing.Point(310, 16);
            this.btnAzurirajZaposlenika.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAzurirajZaposlenika.Name = "btnAzurirajZaposlenika";
            this.btnAzurirajZaposlenika.Size = new System.Drawing.Size(208, 32);
            this.btnAzurirajZaposlenika.TabIndex = 36;
            this.btnAzurirajZaposlenika.Text = "Ažuriraj/Izbriši zaposlenika";
            this.btnAzurirajZaposlenika.UseVisualStyleBackColor = false;
            this.btnAzurirajZaposlenika.Click += new System.EventHandler(this.btnAzurirajZaposlenika_Click);
            // 
            // btnPrikaziZaposlene
            // 
            this.btnPrikaziZaposlene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.btnPrikaziZaposlene.FlatAppearance.BorderSize = 0;
            this.btnPrikaziZaposlene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziZaposlene.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziZaposlene.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrikaziZaposlene.Location = new System.Drawing.Point(544, 16);
            this.btnPrikaziZaposlene.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnPrikaziZaposlene.Name = "btnPrikaziZaposlene";
            this.btnPrikaziZaposlene.Size = new System.Drawing.Size(150, 32);
            this.btnPrikaziZaposlene.TabIndex = 37;
            this.btnPrikaziZaposlene.Text = "Prikaži zaposlenike";
            this.btnPrikaziZaposlene.UseVisualStyleBackColor = false;
            this.btnPrikaziZaposlene.Click += new System.EventHandler(this.btnPrikaziZaposlene_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.cbAdmin.Location = new System.Drawing.Point(55, 330);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(183, 25);
            this.cbAdmin.TabIndex = 42;
            this.cbAdmin.Text = "Ovlasti administratora";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // cbNarudzba
            // 
            this.cbNarudzba.AutoSize = true;
            this.cbNarudzba.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbNarudzba.ForeColor = System.Drawing.SystemColors.Control;
            this.cbNarudzba.Location = new System.Drawing.Point(298, 330);
            this.cbNarudzba.Name = "cbNarudzba";
            this.cbNarudzba.Size = new System.Drawing.Size(233, 25);
            this.cbNarudzba.TabIndex = 43;
            this.cbNarudzba.Text = "Ovlast odobravanja narudžbe";
            this.cbNarudzba.UseVisualStyleBackColor = true;
            // 
            // cbBezOvlasti
            // 
            this.cbBezOvlasti.AutoSize = true;
            this.cbBezOvlasti.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbBezOvlasti.ForeColor = System.Drawing.SystemColors.Control;
            this.cbBezOvlasti.Location = new System.Drawing.Point(298, 372);
            this.cbBezOvlasti.Name = "cbBezOvlasti";
            this.cbBezOvlasti.Size = new System.Drawing.Size(120, 25);
            this.cbBezOvlasti.TabIndex = 44;
            this.cbBezOvlasti.Text = "Nema ovlasti";
            this.cbBezOvlasti.UseVisualStyleBackColor = true;
            // 
            // cbCRUD
            // 
            this.cbCRUD.AutoSize = true;
            this.cbCRUD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCRUD.ForeColor = System.Drawing.SystemColors.Control;
            this.cbCRUD.Location = new System.Drawing.Point(55, 372);
            this.cbCRUD.Name = "cbCRUD";
            this.cbCRUD.Size = new System.Drawing.Size(166, 25);
            this.cbCRUD.TabIndex = 45;
            this.cbCRUD.Text = "CRUD nad artiklima";
            this.cbCRUD.UseVisualStyleBackColor = true;
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.btnPotvrda.FlatAppearance.BorderSize = 0;
            this.btnPotvrda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPotvrda.Location = new System.Drawing.Point(474, 365);
            this.btnPotvrda.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(148, 32);
            this.btnPotvrda.TabIndex = 46;
            this.btnPotvrda.Text = "Promijeni Ovlast";
            this.btnPotvrda.UseVisualStyleBackColor = false;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // helpOvlasti
            // 
            this.helpOvlasti.HelpNamespace = "C:\\Users\\NiksY\\Documents\\r19038\\GeoApp\\GeoApp\\help\\ovlasti.html";
            // 
            // OvlastiZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(732, 431);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.cbCRUD);
            this.Controls.Add(this.cbBezOvlasti);
            this.Controls.Add(this.cbNarudzba);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.btnPrikaziZaposlene);
            this.Controls.Add(this.btnAzurirajZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OvlastiZaposlenika";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpOvlasti.SetShowHelp(this, true);
            this.Text = "Ovlasti Zaposlenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OvlastiZaposlenika_FormClosed);
            this.Load += new System.EventHandler(this.OvlastiZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnAzurirajZaposlenika;
        private System.Windows.Forms.Button btnPrikaziZaposlene;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.CheckBox cbNarudzba;
        private System.Windows.Forms.CheckBox cbBezOvlasti;
        private System.Windows.Forms.CheckBox cbCRUD;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.HelpProvider helpOvlasti;
    }
}