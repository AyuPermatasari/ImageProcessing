namespace imgProc1
{
    partial class frmLogBrightness
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
            this.hsbLogBrightness = new System.Windows.Forms.HScrollBar();
            this.tbLogBrightness = new System.Windows.Forms.TextBox();
            this.btnLogBrightness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsbLogBrightness
            // 
            this.hsbLogBrightness.Location = new System.Drawing.Point(13, 13);
            this.hsbLogBrightness.Maximum = 105;
            this.hsbLogBrightness.Name = "hsbLogBrightness";
            this.hsbLogBrightness.Size = new System.Drawing.Size(236, 18);
            this.hsbLogBrightness.TabIndex = 0;
            this.hsbLogBrightness.ValueChanged += new System.EventHandler(this.hsbLogBrightness_ValueChanged);
            // 
            // tbLogBrightness
            // 
            this.tbLogBrightness.Location = new System.Drawing.Point(274, 11);
            this.tbLogBrightness.Name = "tbLogBrightness";
            this.tbLogBrightness.Size = new System.Drawing.Size(39, 20);
            this.tbLogBrightness.TabIndex = 1;
            this.tbLogBrightness.Text = "0";
            this.tbLogBrightness.TextChanged += new System.EventHandler(this.tbLogBrightness_TextChanged);
            // 
            // btnLogBrightness
            // 
            this.btnLogBrightness.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogBrightness.Location = new System.Drawing.Point(120, 71);
            this.btnLogBrightness.Name = "btnLogBrightness";
            this.btnLogBrightness.Size = new System.Drawing.Size(75, 23);
            this.btnLogBrightness.TabIndex = 2;
            this.btnLogBrightness.Text = "Ok";
            this.btnLogBrightness.UseVisualStyleBackColor = true;
            this.btnLogBrightness.Click += new System.EventHandler(this.btnLogBrightness_Click);
            // 
            // frmLogBrightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 106);
            this.Controls.Add(this.btnLogBrightness);
            this.Controls.Add(this.tbLogBrightness);
            this.Controls.Add(this.hsbLogBrightness);
            this.Name = "frmLogBrightness";
            this.Text = "Log Brightness";
            this.Load += new System.EventHandler(this.frmLogBrightness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbLogBrightness;
        private System.Windows.Forms.Button btnLogBrightness;
        public System.Windows.Forms.TextBox tbLogBrightness;
    }
}