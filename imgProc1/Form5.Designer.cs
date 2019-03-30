namespace imgProc1
{
    partial class frmGamma
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
            this.hscGamma = new System.Windows.Forms.HScrollBar();
            this.tbGamma = new System.Windows.Forms.TextBox();
            this.btnGammaOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hscGamma
            // 
            this.hscGamma.Location = new System.Drawing.Point(13, 13);
            this.hscGamma.Maximum = 800;
            this.hscGamma.Name = "hscGamma";
            this.hscGamma.Size = new System.Drawing.Size(306, 26);
            this.hscGamma.TabIndex = 0;
            this.hscGamma.ValueChanged += new System.EventHandler(this.hscGamma_ValueChanged);
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(337, 18);
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(100, 20);
            this.tbGamma.TabIndex = 1;
            this.tbGamma.Text = "0";
            this.tbGamma.TextChanged += new System.EventHandler(this.tbGamma_TextChanged);
            // 
            // btnGammaOk
            // 
            this.btnGammaOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGammaOk.Location = new System.Drawing.Point(193, 79);
            this.btnGammaOk.Name = "btnGammaOk";
            this.btnGammaOk.Size = new System.Drawing.Size(75, 23);
            this.btnGammaOk.TabIndex = 2;
            this.btnGammaOk.Text = "Ok";
            this.btnGammaOk.UseVisualStyleBackColor = true;
            this.btnGammaOk.Click += new System.EventHandler(this.btnGammaOk_Click);
            // 
            // frmGamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 114);
            this.Controls.Add(this.btnGammaOk);
            this.Controls.Add(this.tbGamma);
            this.Controls.Add(this.hscGamma);
            this.Name = "frmGamma";
            this.Text = "Gamma Tranform";
            this.Load += new System.EventHandler(this.frmGamma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscGamma;
        public System.Windows.Forms.Button btnGammaOk;
        public System.Windows.Forms.TextBox tbGamma;
    }
}