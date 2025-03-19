namespace Polimorf
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
            this.txtAAAAAAA = new System.Windows.Forms.TextBox();
            this.btnZI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAAAAAAA
            // 
            this.txtAAAAAAA.Location = new System.Drawing.Point(37, 150);
            this.txtAAAAAAA.Name = "txtAAAAAAA";
            this.txtAAAAAAA.Size = new System.Drawing.Size(100, 20);
            this.txtAAAAAAA.TabIndex = 0;
            // 
            // btnZI
            // 
            this.btnZI.Location = new System.Drawing.Point(37, 186);
            this.btnZI.Name = "btnZI";
            this.btnZI.Size = new System.Drawing.Size(100, 23);
            this.btnZI.TabIndex = 1;
            this.btnZI.Text = "K|LKEZNI";
            this.btnZI.UseVisualStyleBackColor = true;
            this.btnZI.Click += new System.EventHandler(this.btnZI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZI);
            this.Controls.Add(this.txtAAAAAAA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAAAAAAA;
        private System.Windows.Forms.Button btnZI;
        private System.Windows.Forms.Label label1;
    }
}

