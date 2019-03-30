namespace imgProc1
{
    partial class frmLogContrast
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
            this.hsbLogContrast = new System.Windows.Forms.HScrollBar();
            this.tbLogContrast = new System.Windows.Forms.TextBox();
            this.btnLogContrast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsbLogContrast
            // 
            this.hsbLogContrast.Location = new System.Drawing.Point(13, 13);
            this.hsbLogContrast.Maximum = 105;
            this.hsbLogContrast.Name = "hsbLogContrast";
            this.hsbLogContrast.Size = new System.Drawing.Size(259, 24);
            this.hsbLogContrast.TabIndex = 0;
            this.hsbLogContrast.ValueChanged += new System.EventHandler(this.hsbLogContrast_ValueChanged);
            // 
            // tbLogContrast
            // 
            this.tbLogContrast.Location = new System.Drawing.Point(285, 17);
            this.tbLogContrast.Name = "tbLogContrast";
            this.tbLogContrast.Size = new System.Drawing.Size(45, 20);
            this.tbLogContrast.TabIndex = 1;
            this.tbLogContrast.Text = "0";
            this.tbLogContrast.TextChanged += new System.EventHandler(this.tbLogContrast_TextChanged);
            // 
            // btnLogContrast
            // 
            this.btnLogContrast.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogContrast.Location = new System.Drawing.Point(138, 72);
            this.btnLogContrast.Name = "btnLogContrast";
            this.btnLogContrast.Size = new System.Drawing.Size(75, 23);
            this.btnLogContrast.TabIndex = 2;
            this.btnLogContrast.Text = "Ok";
            this.btnLogContrast.UseVisualStyleBackColor = true;
            this.btnLogContrast.Click += new System.EventHandler(this.btnLogContrast_Click);
            // 
            // frmLogContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 107);
            this.Controls.Add(this.btnLogContrast);
            this.Controls.Add(this.tbLogContrast);
            this.Controls.Add(this.hsbLogContrast);
            this.Name = "frmLogContrast";
            this.Text = "Log Contrast";
            this.Load += new System.EventHandler(this.frmLogContrast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbLogContrast;
        private System.Windows.Forms.Button btnLogContrast;
        public System.Windows.Forms.TextBox tbLogContrast;
    }
}