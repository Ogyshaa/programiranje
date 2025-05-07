namespace eventtt
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
            this.txtSrp = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtPraksa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSrp
            // 
            this.txtSrp.Location = new System.Drawing.Point(80, 103);
            this.txtSrp.Name = "txtSrp";
            this.txtSrp.Size = new System.Drawing.Size(100, 20);
            this.txtSrp.TabIndex = 0;
       
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(80, 129);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 20);
            this.txtTest.TabIndex = 1;
         
            // 
            // txtPraksa
            // 
            this.txtPraksa.Location = new System.Drawing.Point(80, 155);
            this.txtPraksa.Name = "txtPraksa";
            this.txtPraksa.Size = new System.Drawing.Size(100, 20);
            this.txtPraksa.TabIndex = 2;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPraksa);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtSrp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrp;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtPraksa;
    }
}

