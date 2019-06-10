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
            this.prijava2 = new System.Windows.Forms.Button();
            this.registriraj = new System.Windows.Forms.Button();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijava2
            // 
            this.prijava2.AutoSize = true;
            this.prijava2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.prijava2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prijava2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prijava2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.prijava2.FlatAppearance.BorderSize = 0;
            this.prijava2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijava2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijava2.Location = new System.Drawing.Point(226, 179);
            this.prijava2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.prijava2.Name = "prijava2";
            this.prijava2.Size = new System.Drawing.Size(175, 43);
            this.prijava2.TabIndex = 11;
            this.prijava2.Text = "Prijavi se";
            this.prijava2.UseVisualStyleBackColor = false;
            this.prijava2.Click += new System.EventHandler(this.prijava2_Click);
            // 
            // registriraj
            // 
            this.registriraj.AutoSize = true;
            this.registriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.registriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registriraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registriraj.FlatAppearance.BorderSize = 0;
            this.registriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registriraj.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registriraj.Location = new System.Drawing.Point(27, 179);
            this.registriraj.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.registriraj.Name = "registriraj";
            this.registriraj.Size = new System.Drawing.Size(175, 43);
            this.registriraj.TabIndex = 10;
            this.registriraj.Text = "Registriraj se";
            this.registriraj.UseVisualStyleBackColor = false;
            this.registriraj.Click += new System.EventHandler(this.registriraj_Click);
            // 
            // lozinka
            // 
            this.lozinka.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinka.Location = new System.Drawing.Point(173, 112);
            this.lozinka.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(228, 33);
            this.lozinka.TabIndex = 9;
            this.lozinka.UseSystemPasswordChar = true;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoIme.Location = new System.Drawing.Point(173, 50);
            this.korisnickoIme.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(228, 33);
            this.korisnickoIme.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 120);
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
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisničko Ime:";
            // 
            // Prijava
            // 
            this.AcceptButton = this.prijava2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(443, 265);
            this.Controls.Add(this.prijava2);
            this.Controls.Add(this.registriraj);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(459, 304);
            this.MinimumSize = new System.Drawing.Size(459, 304);
            this.Name = "Prijava";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prijava_FormClosed);
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijava2;
        private System.Windows.Forms.Button registriraj;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}