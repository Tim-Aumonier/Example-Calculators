namespace ExampleTA
{
    partial class MainMenu
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
            this.btnPrimeFactorisation = new System.Windows.Forms.Button();
            this.btnLCM = new System.Windows.Forms.Button();
            this.btnHCF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrimeFactorisation
            // 
            this.btnPrimeFactorisation.Location = new System.Drawing.Point(12, 12);
            this.btnPrimeFactorisation.Name = "btnPrimeFactorisation";
            this.btnPrimeFactorisation.Size = new System.Drawing.Size(110, 33);
            this.btnPrimeFactorisation.TabIndex = 0;
            this.btnPrimeFactorisation.Text = "Prime Factorisation";
            this.btnPrimeFactorisation.UseVisualStyleBackColor = true;
            this.btnPrimeFactorisation.Click += new System.EventHandler(this.btnPrimeFactorisation_Click);
            // 
            // btnLCM
            // 
            this.btnLCM.Location = new System.Drawing.Point(128, 12);
            this.btnLCM.Name = "btnLCM";
            this.btnLCM.Size = new System.Drawing.Size(134, 33);
            this.btnLCM.TabIndex = 1;
            this.btnLCM.Text = "Lowest Common Multiple";
            this.btnLCM.UseVisualStyleBackColor = true;
            this.btnLCM.Click += new System.EventHandler(this.btnLCM_Click);
            // 
            // btnHCF
            // 
            this.btnHCF.Location = new System.Drawing.Point(128, 51);
            this.btnHCF.Name = "btnHCF";
            this.btnHCF.Size = new System.Drawing.Size(134, 33);
            this.btnHCF.TabIndex = 2;
            this.btnHCF.Text = "Highest Common Factor";
            this.btnHCF.UseVisualStyleBackColor = true;
            this.btnHCF.Click += new System.EventHandler(this.btnHCF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 262);
            this.Controls.Add(this.btnHCF);
            this.Controls.Add(this.btnLCM);
            this.Controls.Add(this.btnPrimeFactorisation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrimeFactorisation;
        private System.Windows.Forms.Button btnLCM;
        private System.Windows.Forms.Button btnHCF;
    }
}

