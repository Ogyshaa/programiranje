namespace nekikuvarc
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPostaviGranicu = new System.Windows.Forms.Button();
            this.txtOcene = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.liBoxOcene = new System.Windows.Forms.ListBox();
            this.lblGranica = new System.Windows.Forms.Label();
            this.txtGranica = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUpis = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(74, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(74, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PREZIME:";
            // 
            // btnPostaviGranicu
            // 
            this.btnPostaviGranicu.Location = new System.Drawing.Point(118, 244);
            this.btnPostaviGranicu.Name = "btnPostaviGranicu";
            this.btnPostaviGranicu.Size = new System.Drawing.Size(115, 23);
            this.btnPostaviGranicu.TabIndex = 4;
            this.btnPostaviGranicu.Text = "POSTAVI GRANICU";
            this.btnPostaviGranicu.UseVisualStyleBackColor = true;
            this.btnPostaviGranicu.Click += new System.EventHandler(this.btnPostaviGranicu_Click);
            // 
            // txtOcene
            // 
            this.txtOcene.Location = new System.Drawing.Point(74, 67);
            this.txtOcene.Name = "txtOcene";
            this.txtOcene.Size = new System.Drawing.Size(100, 20);
            this.txtOcene.TabIndex = 5;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "OCENE:";
            // 
            // liBoxOcene
            // 
            this.liBoxOcene.FormattingEnabled = true;
            this.liBoxOcene.Location = new System.Drawing.Point(12, 93);
            this.liBoxOcene.Name = "liBoxOcene";
            this.liBoxOcene.Size = new System.Drawing.Size(248, 147);
            this.liBoxOcene.TabIndex = 7;
           
            // 
            // lblGranica
            // 
            this.lblGranica.AutoSize = true;
            this.lblGranica.Location = new System.Drawing.Point(10, 269);
            this.lblGranica.Name = "lblGranica";
            this.lblGranica.Size = new System.Drawing.Size(58, 13);
            this.lblGranica.TabIndex = 8;
            this.lblGranica.Text = "GRANICA:";
            
            // 
            // txtGranica
            // 
            this.txtGranica.Location = new System.Drawing.Point(12, 244);
            this.txtGranica.Name = "txtGranica";
            this.txtGranica.Size = new System.Drawing.Size(100, 20);
            this.txtGranica.TabIndex = 9;
            
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(180, 65);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUpis
            // 
            this.btnUpis.Location = new System.Drawing.Point(118, 273);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(115, 23);
            this.btnUpis.TabIndex = 12;
            this.btnUpis.Text = "UPISI";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(162, 299);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(27, 13);
            this.lblRezultat.TabIndex = 13;
            this.lblRezultat.Text = "Y/N";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 407);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnUpis);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtGranica);
            this.Controls.Add(this.lblGranica);
            this.Controls.Add(this.liBoxOcene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOcene);
            this.Controls.Add(this.btnPostaviGranicu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPostaviGranicu;
        private System.Windows.Forms.TextBox txtOcene;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox liBoxOcene;
        private System.Windows.Forms.Label lblGranica;
        private System.Windows.Forms.TextBox txtGranica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Label lblRezultat;
    }
}

