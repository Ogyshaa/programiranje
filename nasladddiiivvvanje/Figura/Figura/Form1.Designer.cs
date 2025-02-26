namespace Figura
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lbobim = new System.Windows.Forms.Label();
            this.lbpov = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lbOblik1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(81, 115);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 0;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(81, 176);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 1;
            // 
            // lbobim
            // 
            this.lbobim.AutoSize = true;
            this.lbobim.Location = new System.Drawing.Point(309, 122);
            this.lbobim.Name = "lbobim";
            this.lbobim.Size = new System.Drawing.Size(35, 13);
            this.lbobim.TabIndex = 2;
            this.lbobim.Text = "label1";
            // 
            // lbpov
            // 
            this.lbpov.AutoSize = true;
            this.lbpov.Location = new System.Drawing.Point(309, 183);
            this.lbpov.Name = "lbpov";
            this.lbpov.Size = new System.Drawing.Size(35, 13);
            this.lbpov.TabIndex = 3;
            this.lbpov.Text = "label2";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(209, 146);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "izrac";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbOblik1
            // 
            this.lbOblik1.AutoSize = true;
            this.lbOblik1.Location = new System.Drawing.Point(383, 151);
            this.lbOblik1.Name = "lbOblik1";
            this.lbOblik1.Size = new System.Drawing.Size(35, 13);
            this.lbOblik1.TabIndex = 5;
            this.lbOblik1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOblik1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbpov);
            this.Controls.Add(this.lbobim);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lbobim;
        private System.Windows.Forms.Label lbpov;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbOblik1;
    }
}

