namespace isplata_zarada
{
    partial class Form1
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
            this.lbZap = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSif = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRac = new System.Windows.Forms.TextBox();
            this.txtBrs = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVrs = new System.Windows.Forms.TextBox();
            this.lblUkup = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btnIsplati = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.lblIznso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbZap
            // 
            this.lbZap.FormattingEnabled = true;
            this.lbZap.Location = new System.Drawing.Point(23, 25);
            this.lbZap.Name = "lbZap";
            this.lbZap.Size = new System.Drawing.Size(241, 368);
            this.lbZap.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVrs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Ime);
            this.panel1.Controls.Add(this.Sifra);
            this.panel1.Controls.Add(this.txtBrs);
            this.panel1.Controls.Add(this.txtRac);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.txtSif);
            this.panel1.Location = new System.Drawing.Point(299, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 270);
            this.panel1.TabIndex = 1;
            // 
            // txtSif
            // 
            this.txtSif.Location = new System.Drawing.Point(40, 21);
            this.txtSif.Name = "txtSif";
            this.txtSif.Size = new System.Drawing.Size(100, 20);
            this.txtSif.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(40, 62);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRac
            // 
            this.txtRac.Location = new System.Drawing.Point(40, 102);
            this.txtRac.Name = "txtRac";
            this.txtRac.Size = new System.Drawing.Size(100, 20);
            this.txtRac.TabIndex = 3;
            // 
            // txtBrs
            // 
            this.txtBrs.Location = new System.Drawing.Point(40, 144);
            this.txtBrs.Name = "txtBrs";
            this.txtBrs.Size = new System.Drawing.Size(100, 20);
            this.txtBrs.TabIndex = 4;
            // 
            // Sifra
            // 
            this.Sifra.AutoSize = true;
            this.Sifra.Location = new System.Drawing.Point(37, 5);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(28, 13);
            this.Sifra.TabIndex = 5;
            this.Sifra.Text = "Sifra";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(37, 46);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(69, 13);
            this.Ime.TabIndex = 6;
            this.Ime.Text = "Ime i Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Racun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj Sati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrednos Sata";
            // 
            // txtVrs
            // 
            this.txtVrs.Location = new System.Drawing.Point(40, 188);
            this.txtVrs.Name = "txtVrs";
            this.txtVrs.Size = new System.Drawing.Size(100, 20);
            this.txtVrs.TabIndex = 9;
            // 
            // lblUkup
            // 
            this.lblUkup.AutoSize = true;
            this.lblUkup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkup.Location = new System.Drawing.Point(491, 25);
            this.lblUkup.Name = "lblUkup";
            this.lblUkup.Size = new System.Drawing.Size(23, 26);
            this.lblUkup.TabIndex = 11;
            this.lblUkup.Text = "0";
            this.lblUkup.Click += new System.EventHandler(this.lblUkup_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(90, 415);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Racunaj";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnIsplati
            // 
            this.btnIsplati.Location = new System.Drawing.Point(339, 316);
            this.btnIsplati.Name = "btnIsplati";
            this.btnIsplati.Size = new System.Drawing.Size(100, 23);
            this.btnIsplati.TabIndex = 11;
            this.btnIsplati.Text = "Isplata";
            this.btnIsplati.UseVisualStyleBackColor = true;
            this.btnIsplati.Click += new System.EventHandler(this.btnIsplati_Click);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(339, 345);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 11;
            // 
            // lblIznso
            // 
            this.lblIznso.AutoSize = true;
            this.lblIznso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIznso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznso.Location = new System.Drawing.Point(381, 380);
            this.lblIznso.Name = "lblIznso";
            this.lblIznso.Size = new System.Drawing.Size(18, 18);
            this.lblIznso.TabIndex = 12;
            this.lblIznso.Text = "0";
            this.lblIznso.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.lblIznso);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.btnIsplati);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblUkup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbZap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbZap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label Sifra;
        private System.Windows.Forms.TextBox txtBrs;
        private System.Windows.Forms.TextBox txtRac;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtSif;
        private System.Windows.Forms.Label lblUkup;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnIsplati;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label lblIznso;
    }
}

