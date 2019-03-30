namespace imgProc1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightlessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.merahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abuabuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coklatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessAndContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticOpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageDenoisingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearest8ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydSteinbergErrorDiffusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDanOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.brightnessAndContrastToolStripMenuItem,
            this.logToolStripMenuItem,
            this.aritmeticOpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaToolStripMenuItem,
            this.sToolStripMenuItem,
            this.keluarAplikasiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // bukaToolStripMenuItem
            // 
            this.bukaToolStripMenuItem.Name = "bukaToolStripMenuItem";
            this.bukaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.bukaToolStripMenuItem.Text = "&Buka";
            this.bukaToolStripMenuItem.Click += new System.EventHandler(this.bukaToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sToolStripMenuItem.Text = "&Simpan sebagai...";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // keluarAplikasiToolStripMenuItem
            // 
            this.keluarAplikasiToolStripMenuItem.Name = "keluarAplikasiToolStripMenuItem";
            this.keluarAplikasiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.keluarAplikasiToolStripMenuItem.Text = "&Keluar Aplikasi";
            this.keluarAplikasiToolStripMenuItem.Click += new System.EventHandler(this.keluarAplikasiToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.tugasToolStripMenuItem,
            this.gammaTransformToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "&Colors";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightlessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.grayscaleToolStripMenuItem.Text = "&Grayscale";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.averageToolStripMenuItem.Text = "&Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // lightlessToolStripMenuItem
            // 
            this.lightlessToolStripMenuItem.Name = "lightlessToolStripMenuItem";
            this.lightlessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lightlessToolStripMenuItem.Text = "&Lightless";
            this.lightlessToolStripMenuItem.Click += new System.EventHandler(this.lightlessToolStripMenuItem_Click);
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.luminanceToolStripMenuItem.Text = "&Luminance";
            this.luminanceToolStripMenuItem.Click += new System.EventHandler(this.luminanceToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastToolStripMenuItem});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.brightnessToolStripMenuItem.Text = "&Brightness";
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.contrastToolStripMenuItem.Text = "&Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // tugasToolStripMenuItem
            // 
            this.tugasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.merahToolStripMenuItem,
            this.kuningToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.unguToolStripMenuItem,
            this.abuabuToolStripMenuItem,
            this.coklatToolStripMenuItem});
            this.tugasToolStripMenuItem.Name = "tugasToolStripMenuItem";
            this.tugasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tugasToolStripMenuItem.Text = "&Tugas";
            // 
            // merahToolStripMenuItem
            // 
            this.merahToolStripMenuItem.Name = "merahToolStripMenuItem";
            this.merahToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.merahToolStripMenuItem.Text = "Merah";
            this.merahToolStripMenuItem.Click += new System.EventHandler(this.merahToolStripMenuItem_Click);
            // 
            // kuningToolStripMenuItem
            // 
            this.kuningToolStripMenuItem.Name = "kuningToolStripMenuItem";
            this.kuningToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kuningToolStripMenuItem.Text = "Kuning";
            this.kuningToolStripMenuItem.Click += new System.EventHandler(this.kuningToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // unguToolStripMenuItem
            // 
            this.unguToolStripMenuItem.Name = "unguToolStripMenuItem";
            this.unguToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.unguToolStripMenuItem.Text = "Ungu";
            this.unguToolStripMenuItem.Click += new System.EventHandler(this.unguToolStripMenuItem_Click);
            // 
            // abuabuToolStripMenuItem
            // 
            this.abuabuToolStripMenuItem.Name = "abuabuToolStripMenuItem";
            this.abuabuToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.abuabuToolStripMenuItem.Text = "Abu-abu";
            this.abuabuToolStripMenuItem.Click += new System.EventHandler(this.abuabuToolStripMenuItem_Click);
            // 
            // coklatToolStripMenuItem
            // 
            this.coklatToolStripMenuItem.Name = "coklatToolStripMenuItem";
            this.coklatToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.coklatToolStripMenuItem.Text = "Coklat";
            this.coklatToolStripMenuItem.Click += new System.EventHandler(this.coklatToolStripMenuItem_Click);
            // 
            // gammaTransformToolStripMenuItem
            // 
            this.gammaTransformToolStripMenuItem.Name = "gammaTransformToolStripMenuItem";
            this.gammaTransformToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gammaTransformToolStripMenuItem.Text = "Gamma Transform";
            this.gammaTransformToolStripMenuItem.Click += new System.EventHandler(this.gammaTransformToolStripMenuItem_Click);
            // 
            // brightnessAndContrastToolStripMenuItem
            // 
            this.brightnessAndContrastToolStripMenuItem.Name = "brightnessAndContrastToolStripMenuItem";
            this.brightnessAndContrastToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.brightnessAndContrastToolStripMenuItem.Text = "Brightness and Contrast";
            this.brightnessAndContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessAndContrastToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem1,
            this.contrastToolStripMenuItem1});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // brightnessToolStripMenuItem1
            // 
            this.brightnessToolStripMenuItem1.Name = "brightnessToolStripMenuItem1";
            this.brightnessToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.brightnessToolStripMenuItem1.Text = "Brightness";
            this.brightnessToolStripMenuItem1.Click += new System.EventHandler(this.brightnessToolStripMenuItem1_Click);
            // 
            // contrastToolStripMenuItem1
            // 
            this.contrastToolStripMenuItem1.Name = "contrastToolStripMenuItem1";
            this.contrastToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.contrastToolStripMenuItem1.Text = "Contrast";
            this.contrastToolStripMenuItem1.Click += new System.EventHandler(this.contrastToolStripMenuItem1_Click);
            // 
            // aritmeticOpToolStripMenuItem
            // 
            this.aritmeticOpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageDenoisingToolStripMenuItem,
            this.nearest8ColorToolStripMenuItem,
            this.floydSteinbergErrorDiffusionToolStripMenuItem});
            this.aritmeticOpToolStripMenuItem.Name = "aritmeticOpToolStripMenuItem";
            this.aritmeticOpToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.aritmeticOpToolStripMenuItem.Text = "&Aritmetic Op";
            // 
            // averageDenoisingToolStripMenuItem
            // 
            this.averageDenoisingToolStripMenuItem.Name = "averageDenoisingToolStripMenuItem";
            this.averageDenoisingToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.averageDenoisingToolStripMenuItem.Text = "&Average Denoising";
            this.averageDenoisingToolStripMenuItem.Click += new System.EventHandler(this.averageDenoisingToolStripMenuItem_Click);
            // 
            // nearest8ColorToolStripMenuItem
            // 
            this.nearest8ColorToolStripMenuItem.Name = "nearest8ColorToolStripMenuItem";
            this.nearest8ColorToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.nearest8ColorToolStripMenuItem.Text = "&Nearest 8 Color";
            this.nearest8ColorToolStripMenuItem.Click += new System.EventHandler(this.nearest8ColorToolStripMenuItem_Click);
            // 
            // floydSteinbergErrorDiffusionToolStripMenuItem
            // 
            this.floydSteinbergErrorDiffusionToolStripMenuItem.Name = "floydSteinbergErrorDiffusionToolStripMenuItem";
            this.floydSteinbergErrorDiffusionToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.floydSteinbergErrorDiffusionToolStripMenuItem.Text = "&Floyd Steinberg Error Diffusion";
            this.floydSteinbergErrorDiffusionToolStripMenuItem.Click += new System.EventHandler(this.floydSteinbergErrorDiffusionToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.histogramRGBToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.inputOutputToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.histogramToolStripMenuItem.Text = "Histogram Grayscale";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.outputToolStripMenuItem.Text = "Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click);
            // 
            // inputOutputToolStripMenuItem
            // 
            this.inputOutputToolStripMenuItem.Name = "inputOutputToolStripMenuItem";
            this.inputOutputToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.inputOutputToolStripMenuItem.Text = "Input & Output";
            this.inputOutputToolStripMenuItem.Click += new System.EventHandler(this.inputOutputToolStripMenuItem_Click);
            // 
            // histogramRGBToolStripMenuItem
            // 
            this.histogramRGBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem1,
            this.outputToolStripMenuItem1,
            this.inputDanOutputToolStripMenuItem});
            this.histogramRGBToolStripMenuItem.Name = "histogramRGBToolStripMenuItem";
            this.histogramRGBToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.histogramRGBToolStripMenuItem.Text = "Histogram RGB";
            // 
            // inputToolStripMenuItem1
            // 
            this.inputToolStripMenuItem1.Name = "inputToolStripMenuItem1";
            this.inputToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inputToolStripMenuItem1.Text = "Input";
            this.inputToolStripMenuItem1.Click += new System.EventHandler(this.inputToolStripMenuItem1_Click);
            // 
            // outputToolStripMenuItem1
            // 
            this.outputToolStripMenuItem1.Name = "outputToolStripMenuItem1";
            this.outputToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.outputToolStripMenuItem1.Text = "Output";
            this.outputToolStripMenuItem1.Click += new System.EventHandler(this.outputToolStripMenuItem1_Click);
            // 
            // inputDanOutputToolStripMenuItem
            // 
            this.inputDanOutputToolStripMenuItem.Name = "inputDanOutputToolStripMenuItem";
            this.inputDanOutputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputDanOutputToolStripMenuItem.Text = "Input dan Output";
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(13, 28);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(500, 350);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput.TabIndex = 1;
            this.pbInput.TabStop = false;
            this.pbInput.Click += new System.EventHandler(this.pbInput_Click);
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(519, 28);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 350);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 2;
            this.pbOutput.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Garuda Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem bukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightlessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem merahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abuabuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coklatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessAndContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gammaTransformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticOpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageDenoisingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearest8ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydSteinbergErrorDiffusionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputDanOutputToolStripMenuItem;
    }
}

