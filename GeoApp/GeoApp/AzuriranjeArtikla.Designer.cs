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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.serijskiBrojArtikla = new System.Windows.Forms.TextBox();
            this.cijenaArtikla = new System.Windows.Forms.TextBox();
            this.proizvodacArtikla = new System.Windows.Forms.TextBox();
            this.opisArtikla = new System.Windows.Forms.TextBox();
            this.nazivArtikla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gumbAzuriraj = new System.Windows.Forms.Button();
            this.gumbIzbrisi = new System.Windows.Forms.Button();
            this.helpAzuriranjeArtikla = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.dgvArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtikli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArtikli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtikli.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArtikli.Location = new System.Drawing.Point(12, 277);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikli.RowHeadersVisible = false;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(609, 195);
            this.dgvArtikli.TabIndex = 18;
            this.dgvArtikli.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // serijskiBrojArtikla
            // 
            this.serijskiBrojArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serijskiBrojArtikla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serijskiBrojArtikla.Location = new System.Drawing.Point(330, 88);
            this.serijskiBrojArtikla.Name = "serijskiBrojArtikla";
            this.serijskiBrojArtikla.Size = new System.Drawing.Size(225, 21);
            this.serijskiBrojArtikla.TabIndex = 36;
            // 
            // cijenaArtikla
            // 
            this.cijenaArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cijenaArtikla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cijenaArtikla.Location = new System.Drawing.Point(330, 42);
            this.cijenaArtikla.Name = "cijenaArtikla";
            this.cijenaArtikla.Size = new System.Drawing.Size(225, 21);
            this.cijenaArtikla.TabIndex = 35;
            // 
            // proizvodacArtikla
            // 
            this.proizvodacArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.proizvodacArtikla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proizvodacArtikla.Location = new System.Drawing.Point(84, 228);
            this.proizvodacArtikla.Name = "proizvodacArtikla";
            this.proizvodacArtikla.Size = new System.Drawing.Size(225, 21);
            this.proizvodacArtikla.TabIndex = 34;
            // 
            // opisArtikla
            // 
            this.opisArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.opisArtikla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisArtikla.Location = new System.Drawing.Point(84, 84);
            this.opisArtikla.Multiline = true;
            this.opisArtikla.Name = "opisArtikla";
            this.opisArtikla.Size = new System.Drawing.Size(225, 111);
            this.opisArtikla.TabIndex = 33;
            // 
            // nazivArtikla
            // 
            this.nazivArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nazivArtikla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivArtikla.Location = new System.Drawing.Point(84, 42);
            this.nazivArtikla.Name = "nazivArtikla";
            this.nazivArtikla.Size = new System.Drawing.Size(225, 21);
            this.nazivArtikla.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(326, 65);
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
            this.label4.Location = new System.Drawing.Point(326, 19);
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
            this.label2.Location = new System.Drawing.Point(80, 205);
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
            this.label5.Location = new System.Drawing.Point(80, 19);
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
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Opis:";
            // 
            // gumbAzuriraj
            // 
            this.gumbAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gumbAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.gumbAzuriraj.FlatAppearance.BorderSize = 0;
            this.gumbAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumbAzuriraj.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbAzuriraj.ForeColor = System.Drawing.Color.White;
            this.gumbAzuriraj.Location = new System.Drawing.Point(330, 126);
            this.gumbAzuriraj.Name = "gumbAzuriraj";
            this.gumbAzuriraj.Size = new System.Drawing.Size(225, 27);
            this.gumbAzuriraj.TabIndex = 37;
            this.gumbAzuriraj.Text = "Ažuriraj";
            this.gumbAzuriraj.UseVisualStyleBackColor = false;
            this.gumbAzuriraj.Click += new System.EventHandler(this.gumbAzuriraj_Click);
            // 
            // gumbIzbrisi
            // 
            this.gumbIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gumbIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(175)))), ((int)(((byte)(134)))));
            this.gumbIzbrisi.FlatAppearance.BorderSize = 0;
            this.gumbIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumbIzbrisi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbIzbrisi.ForeColor = System.Drawing.Color.White;
            this.gumbIzbrisi.Location = new System.Drawing.Point(330, 168);
            this.gumbIzbrisi.Name = "gumbIzbrisi";
            this.gumbIzbrisi.Size = new System.Drawing.Size(225, 27);
            this.gumbIzbrisi.TabIndex = 38;
            this.gumbIzbrisi.Text = "Izbriši";
            this.gumbIzbrisi.UseVisualStyleBackColor = false;
            this.gumbIzbrisi.Click += new System.EventHandler(this.gumbIzbrisi_Click);
            // 
            // helpAzuriranjeArtikla
            // 
            this.helpAzuriranjeArtikla.HelpNamespace = "";
            // 
            // AzuriranjeArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(633, 486);
            this.Controls.Add(this.gumbIzbrisi);
            this.Controls.Add(this.gumbAzuriraj);
            this.Controls.Add(this.serijskiBrojArtikla);
            this.Controls.Add(this.cijenaArtikla);
            this.Controls.Add(this.proizvodacArtikla);
            this.Controls.Add(this.opisArtikla);
            this.Controls.Add(this.nazivArtikla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArtikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AzuriranjeArtikla";
            this.helpAzuriranjeArtikla.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje artikla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AzuriranjeArtikla_FormClosed);
            this.Load += new System.EventHandler(this.AzuriranjeArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TextBox serijskiBrojArtikla;
        private System.Windows.Forms.TextBox cijenaArtikla;
        private System.Windows.Forms.TextBox proizvodacArtikla;
        private System.Windows.Forms.TextBox opisArtikla;
        private System.Windows.Forms.TextBox nazivArtikla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbAzuriraj;
        private System.Windows.Forms.Button gumbIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskibrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpAzuriranjeArtikla;
    }
}