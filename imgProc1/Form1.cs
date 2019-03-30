using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgProc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbInput_Click(object sender, EventArgs e)
        {

        }

        private static int truncate(int x)
        {
            if (x > 255)
                x = 255;
            else if (x < 0)
                x = 0;
            return x;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput == null)
            {
                MessageBox.Show("Tidak ada citra yang akan disimpan");
            } else
            {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan File Citra";
                simpanFile.Filter = "Image File(*.bmp,*.jpg,*.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == simpanFile.ShowDialog())
                    this.pbOutput.Image.Save(simpanFile.FileName);
            }
        }

        private void bukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File(*.bmp,*.jpg,*.jpeg)|*.bmp;*.jpg;*.jpeg";
            if(DialogResult.OK == bukaFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(bukaFile.FileName);
                toolStripStatusLabel1.Text = bukaFile.FileName + '|' + pbInput.Image.Width + "X" + pbInput.Image.Height;
            
            }
        }

        private void keluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keBrightness(copy);
            this.pbOutput.Image = copy;
        }

        private void merahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keMerah(copy);
            this.pbOutput.Image = copy;
        }

        private void kuningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keKuning(copy);
            this.pbOutput.Image = copy;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keOrange(copy);
            this.pbOutput.Image = copy;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keCyan(copy);
            this.pbOutput.Image = copy;
        }

        private void unguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keUngu(copy);
            this.pbOutput.Image = copy;
        }

        private void abuabuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keAbu(copy);
            this.pbOutput.Image = copy;
        }

        private void coklatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keCoklat(copy);
            this.pbOutput.Image = copy;
        }

        private void brightnessAndContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");

            }
            else
            {
                frmBrightness bc = new frmBrightness();
                if (bc.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    int nilaiBrightness = Convert.ToInt16(bc.tbBrightness.Text);

                    int nilaiContrast = Convert.ToInt16(bc.tbContrast.Text);
                    double a = (259 * (nilaiContrast + 255)) / (255 * (259 - nilaiContrast));
                    progressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            int r1 = truncate((c1.R + nilaiBrightness) + (Convert.ToInt16(a) * (c1.R - 128) + 128));
                            int g1 = truncate((c1.G + nilaiBrightness) + (Convert.ToInt16(a) * (c1.G - 128) + 128));
                            int b1 = truncate((c1.B + nilaiBrightness) + (Convert.ToInt16(a) * (c1.B - 128) + 128));
                            b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }


                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }

        private void brightnessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogBrightness frm3 = new frmLogBrightness();
            if(frm3.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                double nilaiBrightness = Convert.ToDouble(frm3.tbLogBrightness.Text);
                progressBar1.Visible = true;

                for(int i=0; i<b.Width; i++)
                {
                    for(int j=0; j<b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        double r1 = nilaiBrightness*Math.Log10(1+ truncate(Math.Abs(c1.R)));
                        double g1 = nilaiBrightness * Math.Log10(1 + truncate(Math.Abs(c1.G)));
                        double b1 = nilaiBrightness * Math.Log10(1 + truncate(Math.Abs(c1.B)));

                        b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void contrastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogContrast frm4 = new frmLogContrast();
            if (frm4.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                double nilaiContrast = Convert.ToDouble(frm4.tbLogContrast.Text);
                progressBar1.Visible = true;

                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);

                        double a = (259 * (nilaiContrast + 255)) / (255 * (259 - nilaiContrast));
                        int r1 = truncate(Convert.ToInt16((a*(c1.R-128))+Math.Log10(129)));
                        int g1 = truncate(Convert.ToInt16((a * (c1.G - 128)) + Math.Log10(129)));
                        int b1 = truncate(Convert.ToInt16((a * (c1.B - 128)) + Math.Log10(129)));

                        b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void gammaTransformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pbInput.Image == null)
            {
                MessageBox.Show("Tidak ad citra yang diolah");
            }
            else
            {
                frmGamma frm5 = new frmGamma();
                if(frm5.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    double nilaiGamma = Convert.ToDouble(frm5.tbGamma.Text);
                    progressBar1.Visible = true;
                    double r1, g1, b1;
                    double merah, hijau, biru;

                    for (int i=0; i<b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            merah = b.GetPixel(i, j).R;
                            hijau = b.GetPixel(i, j).G;
                            biru = b.GetPixel(i, j).B;

                            r1 = 255 * (Math.Pow(merah/255, 1/nilaiGamma));
                            g1 = 255 * (Math.Pow(hijau / 255, 1 / nilaiGamma));
                            b1 = 255 * (Math.Pow(biru / 255, 1 / nilaiGamma));

                            b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));

                        }
                        progressBar1.Value=Convert.ToInt16(100 * (i+1)/b.Width);
                    }
                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;

                for(int i =0; i < b.Width; i++)
                {
                    for(int j=0; j<b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int grayAvg = (c1.R + c1.G + c1.B)/3;
                        b.SetPixel(i, j, Color.FromArgb(grayAvg, grayAvg, grayAvg));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void lightlessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int nilaiMax = Math.Max(c1.R, Math.Max(c1.G, c1.B)) ;
                        int nilaiMin = Math.Min(c1.R, Math.Max(c1.G, c1.B)) ;
                        int gLight = (nilaiMax + nilaiMin) / 2 ;
                        b.SetPixel(i, j, Color.FromArgb(gLight, gLight, gLight));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            
            }
        }

        private void luminanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int gLum = Convert.ToInt16(0.21 * c1.R + 0.72 * c1.G + 0.07 * c1.B);
                        b.SetPixel(i, j, Color.FromArgb(gLum, gLum, gLum));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void averageDenoisingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.Cancel)
            {
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            List<Image> pictureArray = new List<Image>();
            foreach (string item in Directory.GetFiles(folderDlg.SelectedPath, "*.jpg", SearchOption.AllDirectories))
            {
                Image _image = Image.FromFile(item);
                pictureArray.Add(_image);
            }

            pbInput.Image = pictureArray[0];
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            Bitmap c = new Bitmap((Bitmap)this.pbInput.Image);
            statusStrip1.Text = "Res. Citra: " + pbInput.Image.Width + " x " +
            pbInput.Image.Height;
            progressBar1.Visible = true;
            int R, G, B, newR, newG, newB;
            //nilai 50 berikut menunjukkan jumlah citra, yang diproses adalah 50 citra
            int jumGambar = 50;

            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    R = 0;
                    G = 0;
                    B = 0;
                    for (int k = 0; k < jumGambar - 1; k++)
                    {
                        b = (Bitmap)pictureArray[k];
                        Color c1 = b.GetPixel(i, j);
                        R += c1.R / jumGambar;
                        G += c1.G / jumGambar;
                        B += c1.B / jumGambar;
                    }
                    c.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                progressBar1.Value = Convert.ToInt16(100 * (i + 1) / c.Width);
            }
            progressBar1.Visible = false;
            this.pbOutput.Image = c;
        }
    
    


        private static double warnaTerdekat(int pValueR, int pValueG, int pValueB)
        {
            double miniDistance = 255 * 255 + 255 * 255 + 255 * 255;
            int palColor, rDiff, gDiff, bDiff;
            double pValueR1 = 0;
            double distance;

            //set warna pallet : hittam, merah, hijau, kuning, biru, cyan, magenta,putih
            int[,] palletteColor = new int[,] { { 0, 0, 0 }, { 255, 0, 0 }, { 0, 255, 0 }, { 255, 255, 0 }, { 0, 0, 255 },
                { 0, 255, 255 }, { 255, 0, 255 }, { 255, 255, 255 } };

            for (palColor = 0; palColor <= palletteColor.GetLength(0) - 1; palColor++)
            {
                rDiff = pValueR - palletteColor[palColor, 0];
                gDiff = pValueG - palletteColor[palColor, 1];
                bDiff = pValueB - palletteColor[palColor, 2];
                distance = rDiff * rDiff + gDiff * gDiff + bDiff * bDiff;
                if (distance < miniDistance)
                {
                    miniDistance = distance;
                    pValueR1 = palColor;
                }
            }

            return pValueR1;
        }

        private void nearest8ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan di olah");
            }
            else
            {
                double baru;
                int[,] palletteColor = new int[,] { { 0, 0, 0 }, { 255, 0, 0 }, { 0, 255, 0 }, { 255, 255, 0 }, { 0, 0, 255 },
                    { 0, 255, 255 }, { 255, 0, 255 }, { 255, 255, 255 } };
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                this.pbOutput.Image = b;
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        baru = warnaTerdekat(c1.R, c1.G, c1.B);
                        b.SetPixel(i, j, Color.FromArgb(palletteColor[(int)baru, 0], palletteColor[(int)baru, 1],
                            palletteColor[(int)baru, 2]));

                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void floydSteinbergErrorDiffusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                int[,] palletteColor = new int[,] { { 0, 0, 0 }, { 255, 0, 0 }, { 0, 255, 0 }, { 255, 255, 0 }, { 0, 0, 255 }, { 0, 255, 255 }, { 255, 0, 255 }, { 255, 255, 255 } };
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                this.pbOutput.Image = b;

                int merah, hijau, biru, newR, newG, newB;
                double baru, errorR, errorG, errorB;
                progressBar1.Visible = true;

                for (int i = 0; i < b.Width - 2; i++)
                {
                    for (int j = 0; j < b.Height - 2; j++)
                    {
                        merah = b.GetPixel(i, j).R;
                        hijau = b.GetPixel(i, j).G;
                        biru = b.GetPixel(i, j).B;
                        baru = warnaTerdekat(merah, hijau, biru);
                        errorR = merah - palletteColor[(int)baru, 0];
                        errorG = hijau - palletteColor[(int)baru, 1];
                        errorB = biru - palletteColor[(int)baru, 2];
                        newR = truncate(Convert.ToInt32(b.GetPixel(i + 1, j).R + 7 / 16 * errorR));
                        newG = truncate(Convert.ToInt32(b.GetPixel(i + 1, j).G + 7 / 16 * errorG));
                        newB = truncate(Convert.ToInt32(b.GetPixel(i + 1, j).B + 7 / 16 * errorB));
                        b.SetPixel(i + 1, j, Color.FromArgb(newR, newG, newB));

                        if (i > 0)
                        {
                            newR = truncate(Convert.ToInt32(b.GetPixel(i - 1, j + 1).R + 3 / 16 * errorR));
                            newG = truncate(Convert.ToInt32(b.GetPixel(i - 1, j + 1).G + 3 / 16 * errorG));
                            newB = truncate(Convert.ToInt32(b.GetPixel(i - 1, j + 1).B + 3 / 16 * errorB));
                            b.SetPixel(i - 1, j + 1, Color.FromArgb(newR, newG, newB));
                        }

                        newR = truncate(Convert.ToInt32(b.GetPixel(i, j + 1).R + 5 / 16 * errorR));
                        newG = truncate(Convert.ToInt32(b.GetPixel(i, j + 1).G + 5 / 16 * errorG));
                        newB = truncate(Convert.ToInt32(b.GetPixel(i, j + 1).B + 5 / 16 * errorB));
                        b.SetPixel(i, j + 1, Color.FromArgb(newR, newG, newB));

                        newR = truncate(Convert.ToInt32(b.GetPixel(i + 1, j + 1).R + 1 / 16 * errorR));
                        newG = truncate(Convert.ToInt32(b.GetPixel(i + 1, j + 1).G + 1 / 16 * errorG));
                        newB = truncate(Convert.ToInt32(b.GetPixel(i + 1, j + 1).B + 1 / 16 * errorB));
                        b.SetPixel(i + 1, j + 1, Color.FromArgb(newR, newG, newB));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);

                Form7 frm7 = new Form7();
                Form6 frm6 = new Form6();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    frm7.chart1.Series["Series1"].Color = Color.Gray;
                    frm7.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm7.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm7.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    frm7.ShowDialog();
                }
                else
                {
                    frm6.chart1.Series["Series1"].Color = Color.Red;
                    frm6.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm6.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm6.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    frm7.chart2.Series["Series1"].Color = Color.Green;
                    frm7.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm7.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm7.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    frm7.chart3.Series["Series1"].Color = Color.Blue;
                    frm7.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm7.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm7.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }
                    frm6.ShowDialog();
                }
            }
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbOutput.Image);

                Form7 frm7 = new Form7();
                Form6 frm6 = new Form6();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    frm7.chart1.Series["Series1"].Color = Color.Gray;
                    frm7.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm7.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm7.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    frm7.ShowDialog();
                }
                else
                {
                    frm6.chart1.Series["Series1"].Color = Color.Red;
                    frm6.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm6.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm6.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    frm7.chart2.Series["Series1"].Color = Color.Green;
                    frm7.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm7.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm7.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    frm7.chart3.Series["Series1"].Color = Color.Blue;
                    frm7.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    frm7.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            frm7.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }
                    frm6.ShowDialog();
                }
            }
        }

        private void inputOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);

                Form7 frm5 = new Form7();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                frm5.chart1.Series["Series1"].Color = Color.Red;
                frm5.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm5.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstR in HistoR)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        frm5.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                    }
                }

                frm5.chart2.Series["Series1"].Color = Color.Green;
                frm5.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm5.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstG in HistoG)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        frm5.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                    }
                }

                frm5.chart3.Series["Series1"].Color = Color.Blue;
                frm5.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm5.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstB in HistoB)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        frm5.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                    }
                }

                frm5.ShowDialog();
            }
        }

        private void outputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbOutput.Image);

                Form7 frm5 = new Form7();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                frm5.chart1.Series["Series1"].Color = Color.Red;
                frm5.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm5.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstR in HistoR)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        frm5.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                    }
                }

                frm5.chart2.Series["Series1"].Color = Color.Green;
                frm5.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm5.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstG in HistoG)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        frm5.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                    }
                }

                frm5.chart3.Series["Series1"].Color = Color.Blue;
                frm5.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm5.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstB in HistoB)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        frm5.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                    }
                }

                frm5.ShowDialog();
            }
        }
    }
}
