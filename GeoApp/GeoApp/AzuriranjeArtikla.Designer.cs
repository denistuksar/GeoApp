namespace GeoApp
{
    partial class AzuriranjeArtikla
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
            this.uiPrikazArtikala = new System.Windows.Forms.DataGridView();
            this.uiSerijskiBrojArtikla = new System.Windows.Forms.TextBox();
            this.uiCijenaArtikla = new System.Windows.Forms.TextBox();
            this.uiProizvodacArtikla = new System.Windows.Forms.TextBox();
            this.uiOpisArtikla = new System.Windows.Forms.TextBox();
            this.uiNazivArtikla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiAzurirajArtikl = new System.Windows.Forms.Button();
            this.uiIzbrisiArtikl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uiSearch = new System.Windows.Forms.TextBox();
            this.helpAzuriranjeArtikla = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazArtikala)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPrikazArtikala
            // 
            this.uiPrikazArtikala.AllowUserToAddRows = false;
            this.uiPrikazArtikala.AllowUserToDeleteRows = false;
            this.uiPrikazArtikala.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.uiPrikazArtikala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazArtikala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiPrikazArtikala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiPrikazArtikala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uiPrikazArtikala.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiPrikazArtikala.DefaultCellStyle = dataGridViewCellStyle2;
            this.uiPrikazArtikala.EnableHeadersVisualStyles = false;
            this.uiPrikazArtikala.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiPrikazArtikala.Location = new System.Drawing.Point(12, 366);
            this.uiPrikazArtikala.Name = "uiPrikazArtikala";
            this.uiPrikazArtikala.ReadOnly = true;
            this.uiPrikazArtikala.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiPrikazArtikala.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.uiPrikazArtikala.RowHeadersVisible = false;
            this.uiPrikazArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazArtikala.Size = new System.Drawing.Size(608, 195);
            this.uiPrikazArtikala.TabIndex = 18;
            this.uiPrikazArtikala.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // uiSerijskiBrojArtikla
            // 
            this.uiSerijskiBrojArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiSerijskiBrojArtikla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSerijskiBrojArtikla.Location = new System.Drawing.Point(326, 112);
            this.uiSerijskiBrojArtikla.Multiline = true;
            this.uiSerijskiBrojArtikla.Name = "uiSerijskiBrojArtikla";
            this.uiSerijskiBrojArtikla.Size = new System.Drawing.Size(294, 35);
            this.uiSerijskiBrojArtikla.TabIndex = 36;
            // 
            // uiCijenaArtikla
            // 
            this.uiCijenaArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiCijenaArtikla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCijenaArtikla.Location = new System.Drawing.Point(326, 38);
            this.uiCijenaArtikla.Multiline = true;
            this.uiCijenaArtikla.Name = "uiCijenaArtikla";
            this.uiCijenaArtikla.Size = new System.Drawing.Size(294, 35);
            this.uiCijenaArtikla.TabIndex = 35;
            // 
            // uiProizvodacArtikla
            // 
            this.uiProizvodacArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiProizvodacArtikla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiProizvodacArtikla.Location = new System.Drawing.Point(12, 318);
            this.uiProizvodacArtikla.Multiline = true;
            this.uiProizvodacArtikla.Name = "uiProizvodacArtikla";
            this.uiProizvodacArtikla.Size = new System.Drawing.Size(294, 35);
            this.uiProizvodacArtikla.TabIndex = 34;
            // 
            // uiOpisArtikla
            // 
            this.uiOpisArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiOpisArtikla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOpisArtikla.Location = new System.Drawing.Point(12, 112);
            this.uiOpisArtikla.Multiline = true;
            this.uiOpisArtikla.Name = "uiOpisArtikla";
            this.uiOpisArtikla.Size = new System.Drawing.Size(294, 172);
            this.uiOpisArtikla.TabIndex = 33;
            // 
            // uiNazivArtikla
            // 
            this.uiNazivArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiNazivArtikla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNazivArtikla.Location = new System.Drawing.Point(12, 38);
            this.uiNazivArtikla.Multiline = true;
            this.uiNazivArtikla.Name = "uiNazivArtikla";
            this.uiNazivArtikla.Size = new System.Drawing.Size(294, 35);
            this.uiNazivArtikla.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(322, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Serijski broj:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cijena:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Proizvođač:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Opis:";
            // 
            // uiAzurirajArtikl
            // 
            this.uiAzurirajArtikl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiAzurirajArtikl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiAzurirajArtikl.FlatAppearance.BorderSize = 0;
            this.uiAzurirajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiAzurirajArtikl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiAzurirajArtikl.ForeColor = System.Drawing.Color.White;
            this.uiAzurirajArtikl.Location = new System.Drawing.Point(326, 167);
            this.uiAzurirajArtikl.Name = "uiAzurirajArtikl";
            this.uiAzurirajArtikl.Size = new System.Drawing.Size(294, 35);
            this.uiAzurirajArtikl.TabIndex = 37;
            this.uiAzurirajArtikl.Text = "Ažuriraj";
            this.uiAzurirajArtikl.UseVisualStyleBackColor = false;
            this.uiAzurirajArtikl.Click += new System.EventHandler(this.gumbAzuriraj_Click);
            // 
            // uiIzbrisiArtikl
            // 
            this.uiIzbrisiArtikl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiIzbrisiArtikl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiIzbrisiArtikl.FlatAppearance.BorderSize = 0;
            this.uiIzbrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiIzbrisiArtikl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiIzbrisiArtikl.ForeColor = System.Drawing.Color.White;
            this.uiIzbrisiArtikl.Location = new System.Drawing.Point(326, 214);
            this.uiIzbrisiArtikl.Name = "uiIzbrisiArtikl";
            this.uiIzbrisiArtikl.Size = new System.Drawing.Size(294, 35);
            this.uiIzbrisiArtikl.TabIndex = 38;
            this.uiIzbrisiArtikl.Text = "Izbriši";
            this.uiIzbrisiArtikl.UseVisualStyleBackColor = false;
            this.uiIzbrisiArtikl.Click += new System.EventHandler(this.gumbIzbrisi_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(322, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pretraži:";
            // 
            // uiSearch
            // 
            this.uiSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSearch.Location = new System.Drawing.Point(326, 318);
            this.uiSearch.Multiline = true;
            this.uiSearch.Name = "uiSearch";
            this.uiSearch.Size = new System.Drawing.Size(294, 35);
            this.uiSearch.TabIndex = 40;
            this.uiSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // AzuriranjeArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(633, 577);
            this.Controls.Add(this.uiSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiIzbrisiArtikl);
            this.Controls.Add(this.uiAzurirajArtikl);
            this.Controls.Add(this.uiSerijskiBrojArtikla);
            this.Controls.Add(this.uiCijenaArtikla);
            this.Controls.Add(this.uiProizvodacArtikla);
            this.Controls.Add(this.uiOpisArtikla);
            this.Controls.Add(this.uiNazivArtikla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiPrikazArtikala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AzuriranjeArtikla";
            this.helpAzuriranjeArtikla.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje artikla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AzuriranjeArtikla_FormClosed);
            this.Load += new System.EventHandler(this.AzuriranjeArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazArtikala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView uiPrikazArtikala;
        private System.Windows.Forms.TextBox uiSerijskiBrojArtikla;
        private System.Windows.Forms.TextBox uiCijenaArtikla;
        private System.Windows.Forms.TextBox uiProizvodacArtikla;
        private System.Windows.Forms.TextBox uiOpisArtikla;
        private System.Windows.Forms.TextBox uiNazivArtikla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiAzurirajArtikl;
        private System.Windows.Forms.Button uiIzbrisiArtikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskibrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiSearch;
        private System.Windows.Forms.HelpProvider helpAzuriranjeArtikla;
    }
}