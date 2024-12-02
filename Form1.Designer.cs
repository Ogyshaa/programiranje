namespace WindowsFormsApp1
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
            this.Lb1 = new System.Windows.Forms.ListBox();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.txtkolicina = new System.Windows.Forms.TextBox();
            this.txtsifra = new System.Windows.Forms.TextBox();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnlistaj = new System.Windows.Forms.Button();
            this.txtpkolicina = new System.Windows.Forms.TextBox();
            this.txtpsifra = new System.Windows.Forms.TextBox();
            this.txtpcena = new System.Windows.Forms.TextBox();
            this.btnget = new System.Windows.Forms.Button();
            this.txtkolicinasell = new System.Windows.Forms.TextBox();
            this.txtsifrasell = new System.Windows.Forms.TextBox();
            this.Sell = new System.Windows.Forms.Button();
            this.lbpregled = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Lb1
            // 
            this.Lb1.FormattingEnabled = true;
            this.Lb1.ItemHeight = 37;
            this.Lb1.Location = new System.Drawing.Point(419, 134);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(498, 263);
            this.Lb1.TabIndex = 0;
            // 
            // txtcena
            // 
            this.txtcena.Location = new System.Drawing.Point(121, 371);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(188, 44);
            this.txtcena.TabIndex = 1;
            // 
            // txtkolicina
            // 
            this.txtkolicina.Location = new System.Drawing.Point(121, 293);
            this.txtkolicina.Name = "txtkolicina";
            this.txtkolicina.Size = new System.Drawing.Size(188, 44);
            this.txtkolicina.TabIndex = 2;
            // 
            // txtsifra
            // 
            this.txtsifra.Location = new System.Drawing.Point(121, 109);
            this.txtsifra.Name = "txtsifra";
            this.txtsifra.Size = new System.Drawing.Size(188, 44);
            this.txtsifra.TabIndex = 3;
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(121, 210);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(188, 44);
            this.txtnaziv.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(121, 553);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(144, 83);
            this.btn.TabIndex = 5;
            this.btn.Text = "ADD";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(451, 513);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(161, 52);
            this.btnUcitaj.TabIndex = 6;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(451, 604);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(161, 52);
            this.btnUpisi.TabIndex = 7;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnlistaj
            // 
            this.btnlistaj.Location = new System.Drawing.Point(451, 709);
            this.btnlistaj.Name = "btnlistaj";
            this.btnlistaj.Size = new System.Drawing.Size(168, 44);
            this.btnlistaj.TabIndex = 8;
            this.btnlistaj.Text = "Listaj";
            this.btnlistaj.UseVisualStyleBackColor = true;
            this.btnlistaj.Click += new System.EventHandler(this.btnlistaj_Click);
            // 
            // txtpkolicina
            // 
            this.txtpkolicina.Location = new System.Drawing.Point(1237, 345);
            this.txtpkolicina.Name = "txtpkolicina";
            this.txtpkolicina.Size = new System.Drawing.Size(188, 44);
            this.txtpkolicina.TabIndex = 11;
            // 
            // txtpsifra
            // 
            this.txtpsifra.Location = new System.Drawing.Point(1237, 244);
            this.txtpsifra.Name = "txtpsifra";
            this.txtpsifra.Size = new System.Drawing.Size(188, 44);
            this.txtpsifra.TabIndex = 10;
            // 
            // txtpcena
            // 
            this.txtpcena.Location = new System.Drawing.Point(1237, 428);
            this.txtpcena.Name = "txtpcena";
            this.txtpcena.Size = new System.Drawing.Size(188, 44);
            this.txtpcena.TabIndex = 9;
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(1627, 314);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(144, 83);
            this.btnget.TabIndex = 12;
            this.btnget.Text = "Getuj";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // txtkolicinasell
            // 
            this.txtkolicinasell.Location = new System.Drawing.Point(1237, 749);
            this.txtkolicinasell.Name = "txtkolicinasell";
            this.txtkolicinasell.Size = new System.Drawing.Size(188, 44);
            this.txtkolicinasell.TabIndex = 14;
            // 
            // txtsifrasell
            // 
            this.txtsifrasell.Location = new System.Drawing.Point(1237, 648);
            this.txtsifrasell.Name = "txtsifrasell";
            this.txtsifrasell.Size = new System.Drawing.Size(188, 44);
            this.txtsifrasell.TabIndex = 13;
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(1617, 680);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(144, 83);
            this.Sell.TabIndex = 15;
            this.Sell.Text = "btnsell";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // lbpregled
            // 
            this.lbpregled.FormattingEnabled = true;
            this.lbpregled.ItemHeight = 37;
            this.lbpregled.Location = new System.Drawing.Point(714, 513);
            this.lbpregled.Name = "lbpregled";
            this.lbpregled.Size = new System.Drawing.Size(429, 152);
            this.lbpregled.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2097, 984);
            this.Controls.Add(this.lbpregled);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.txtkolicinasell);
            this.Controls.Add(this.txtsifrasell);
            this.Controls.Add(this.btnget);
            this.Controls.Add(this.txtpkolicina);
            this.Controls.Add(this.txtpsifra);
            this.Controls.Add(this.txtpcena);
            this.Controls.Add(this.btnlistaj);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtnaziv);
            this.Controls.Add(this.txtsifra);
            this.Controls.Add(this.txtkolicina);
            this.Controls.Add(this.txtcena);
            this.Controls.Add(this.Lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb1;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.TextBox txtkolicina;
        private System.Windows.Forms.TextBox txtsifra;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnlistaj;
        private System.Windows.Forms.TextBox txtpkolicina;
        private System.Windows.Forms.TextBox txtpsifra;
        private System.Windows.Forms.TextBox txtpcena;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.TextBox txtkolicinasell;
        private System.Windows.Forms.TextBox txtsifrasell;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.ListBox lbpregled;
    }
}

