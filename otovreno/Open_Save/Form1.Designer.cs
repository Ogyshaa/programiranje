namespace Open_Save
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
            this.label1 = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lbFile = new System.Windows.Forms.ListBox();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = ":)";
            // 
            // ofd1
            // 
            this.ofd1.Filter = "\"All files|*.*|C# files|*.cs\"";
            this.ofd1.InitialDirectory = "@\"D\\Ognjen Radojkovic\"";
            this.ofd1.Multiselect = true;
            this.ofd1.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd1_FileOk);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(313, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPENZI";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbFile
            // 
            this.lbFile.FormattingEnabled = true;
            this.lbFile.Location = new System.Drawing.Point(12, 95);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(776, 342);
            this.lbFile.TabIndex = 2;
            // 
            // sfd1
            // 
            this.sfd1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE ME ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lbFile;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.Button btnSave;
    }
}

