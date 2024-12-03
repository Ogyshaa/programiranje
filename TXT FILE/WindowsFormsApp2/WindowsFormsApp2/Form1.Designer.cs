namespace WindowsFormsApp2
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnucitaj = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 37;
            this.lb1.Location = new System.Drawing.Point(143, 194);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(407, 300);
            this.lb1.TabIndex = 0;
            // 
            // btnucitaj
            // 
            this.btnucitaj.Location = new System.Drawing.Point(698, 234);
            this.btnucitaj.Name = "btnucitaj";
            this.btnucitaj.Size = new System.Drawing.Size(167, 91);
            this.btnucitaj.TabIndex = 1;
            this.btnucitaj.Text = "ucitaj";
            this.btnucitaj.UseVisualStyleBackColor = true;
            this.btnucitaj.Click += new System.EventHandler(this.btnucitaj_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(698, 371);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(167, 91);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "sve";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(1017, 322);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(154, 84);
            this.btnview.TabIndex = 3;
            this.btnview.Text = "Listaj";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 932);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnucitaj);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button btnucitaj;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

