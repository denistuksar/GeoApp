namespace GeoApp
{
    partial class Prijava
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
            this.uiPrijaviKorisnika = new System.Windows.Forms.Button();
            this.uiRegistrirajKorisnika = new System.Windows.Forms.Button();
            this.uiUnosLozinke = new System.Windows.Forms.TextBox();
            this.uiUnosKorisnickogImena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpPrijava = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // uiPrijaviKorisnika
            // 
            this.uiPrijaviKorisnika.AutoSize = true;
            this.uiPrijaviKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiPrijaviKorisnika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiPrijaviKorisnika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiPrijaviKorisnika.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.uiPrijaviKorisnika.FlatAppearance.BorderSize = 0;
            this.uiPrijaviKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPrijaviKorisnika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPrijaviKorisnika.Location = new System.Drawing.Point(233, 179);
            this.uiPrijaviKorisnika.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiPrijaviKorisnika.Name = "uiPrijaviKorisnika";
            this.uiPrijaviKorisnika.Size = new System.Drawing.Size(175, 43);
            this.uiPrijaviKorisnika.TabIndex = 11;
            this.uiPrijaviKorisnika.Text = "Prijavi se";
            this.uiPrijaviKorisnika.UseVisualStyleBackColor = false;
            this.uiPrijaviKorisnika.Click += new System.EventHandler(this.prijava2_Click);
            // 
            // uiRegistrirajKorisnika
            // 
            this.uiRegistrirajKorisnika.AutoSize = true;
            this.uiRegistrirajKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.uiRegistrirajKorisnika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiRegistrirajKorisnika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRegistrirajKorisnika.FlatAppearance.BorderSize = 0;
            this.uiRegistrirajKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiRegistrirajKorisnika.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRegistrirajKorisnika.Location = new System.Drawing.Point(34, 179);
            this.uiRegistrirajKorisnika.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiRegistrirajKorisnika.Name = "uiRegistrirajKorisnika";
            this.uiRegistrirajKorisnika.Size = new System.Drawing.Size(175, 43);
            this.uiRegistrirajKorisnika.TabIndex = 10;
            this.uiRegistrirajKorisnika.Text = "Registriraj se";
            this.uiRegistrirajKorisnika.UseVisualStyleBackColor = false;
            this.uiRegistrirajKorisnika.Click += new System.EventHandler(this.registriraj_Click);
            // 
            // uiUnosLozinke
            // 
            this.uiUnosLozinke.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosLozinke.Location = new System.Drawing.Point(180, 112);
            this.uiUnosLozinke.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiUnosLozinke.Name = "uiUnosLozinke";
            this.uiUnosLozinke.Size = new System.Drawing.Size(228, 33);
            this.uiUnosLozinke.TabIndex = 9;
            this.uiUnosLozinke.UseSystemPasswordChar = true;
            // 
            // uiUnosKorisnickogImena
            // 
            this.uiUnosKorisnickogImena.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosKorisnickogImena.Location = new System.Drawing.Point(180, 50);
            this.uiUnosKorisnickogImena.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uiUnosKorisnickogImena.Name = "uiUnosKorisnickogImena";
            this.uiUnosKorisnickogImena.Size = new System.Drawing.Size(228, 33);
            this.uiUnosKorisnickogImena.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisničko Ime:";
            // 
            // Prijava
            // 
            this.AcceptButton = this.uiPrijaviKorisnika;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(443, 265);
            this.Controls.Add(this.uiPrijaviKorisnika);
            this.Controls.Add(this.uiRegistrirajKorisnika);
            this.Controls.Add(this.uiUnosLozinke);
            this.Controls.Add(this.uiUnosKorisnickogImena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(459, 304);
            this.MinimumSize = new System.Drawing.Size(459, 304);
            this.Name = "Prijava";
            this.helpPrijava.SetShowHelp(this, true);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prijava_FormClosing);
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiPrijaviKorisnika;
        private System.Windows.Forms.Button uiRegistrirajKorisnika;
        private System.Windows.Forms.TextBox uiUnosLozinke;
        private System.Windows.Forms.TextBox uiUnosKorisnickogImena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpPrijava;
    }
}