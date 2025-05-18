using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.obrazWgraj = new MaterialSkin.Controls.MaterialButton();
            this.obrazZapisz = new MaterialSkin.Controls.MaterialButton();
            this.zresetujObraz = new MaterialSkin.Controls.MaterialButton();
            this.wgrajDrugiObraz = new MaterialSkin.Controls.MaterialButton();
            this.tworzenieHistogramu = new MaterialSkin.Controls.MaterialButton();
            this.RBGnaHSV = new MaterialSkin.Controls.MaterialButton();
            this.metodaSredniej = new MaterialSkin.Controls.MaterialButton();
            this.metodaYUV = new MaterialSkin.Controls.MaterialButton();
            this.RGBnaYUV = new MaterialSkin.Controls.MaterialButton();
            this.datekcjaKrawedzi = new MaterialSkin.Controls.MaterialButton();
            this.odejmowanieObrazow = new MaterialSkin.Controls.MaterialButton();
            this.progowanieTrackBar = new MaterialSkin.Controls.MaterialSlider();
            this.kanalCzerwony = new MaterialSkin.Controls.MaterialButton();
            this.kanalZielony = new MaterialSkin.Controls.MaterialButton();
            this.kanalNiebieski = new MaterialSkin.Controls.MaterialButton();
            this.progowanieObrazu = new MaterialSkin.Controls.MaterialButton();
            this.progowanieHistogram = new MaterialSkin.Controls.MaterialButton();
            this.multiprogowanieObrazu = new MaterialSkin.Controls.MaterialButton();
            this.progowanieMinTrackBar = new MaterialSkin.Controls.MaterialSlider();
            this.progowanieMaxTrackBar = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(53, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 400);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(496, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(400, 400);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(1382, 97);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 400);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(935, 97);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(400, 400);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // obrazWgraj
            // 
            this.obrazWgraj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.obrazWgraj.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.obrazWgraj.Depth = 0;
            this.obrazWgraj.HighEmphasis = true;
            this.obrazWgraj.Icon = null;
            this.obrazWgraj.Location = new System.Drawing.Point(196, 523);
            this.obrazWgraj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.obrazWgraj.MouseState = MaterialSkin.MouseState.HOVER;
            this.obrazWgraj.Name = "obrazWgraj";
            this.obrazWgraj.NoAccentTextColor = System.Drawing.Color.Empty;
            this.obrazWgraj.Size = new System.Drawing.Size(122, 36);
            this.obrazWgraj.TabIndex = 38;
            this.obrazWgraj.Text = "WGRAJ OBRAZ";
            this.obrazWgraj.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.obrazWgraj.UseAccentColor = false;
            this.obrazWgraj.UseVisualStyleBackColor = true;
            this.obrazWgraj.Click += new System.EventHandler(this.obrazWgraj_Click);
            // 
            // obrazZapisz
            // 
            this.obrazZapisz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.obrazZapisz.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.obrazZapisz.Depth = 0;
            this.obrazZapisz.HighEmphasis = true;
            this.obrazZapisz.Icon = null;
            this.obrazZapisz.Location = new System.Drawing.Point(196, 667);
            this.obrazZapisz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.obrazZapisz.MouseState = MaterialSkin.MouseState.HOVER;
            this.obrazZapisz.Name = "obrazZapisz";
            this.obrazZapisz.NoAccentTextColor = System.Drawing.Color.Empty;
            this.obrazZapisz.Size = new System.Drawing.Size(122, 36);
            this.obrazZapisz.TabIndex = 39;
            this.obrazZapisz.Text = "ZAPISZ OBRAZ";
            this.obrazZapisz.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.obrazZapisz.UseAccentColor = false;
            this.obrazZapisz.UseVisualStyleBackColor = true;
            this.obrazZapisz.Click += new System.EventHandler(this.obrazZapisz_Click);
            // 
            // zresetujObraz
            // 
            this.zresetujObraz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zresetujObraz.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.zresetujObraz.Depth = 0;
            this.zresetujObraz.HighEmphasis = true;
            this.zresetujObraz.Icon = null;
            this.zresetujObraz.Location = new System.Drawing.Point(186, 619);
            this.zresetujObraz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.zresetujObraz.MouseState = MaterialSkin.MouseState.HOVER;
            this.zresetujObraz.Name = "zresetujObraz";
            this.zresetujObraz.NoAccentTextColor = System.Drawing.Color.Empty;
            this.zresetujObraz.Size = new System.Drawing.Size(143, 36);
            this.zresetujObraz.TabIndex = 40;
            this.zresetujObraz.Text = "ZRESETUJ OBRAZ";
            this.zresetujObraz.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.zresetujObraz.UseAccentColor = false;
            this.zresetujObraz.UseVisualStyleBackColor = true;
            this.zresetujObraz.Click += new System.EventHandler(this.zresetujObraz_Click);
            // 
            // wgrajDrugiObraz
            // 
            this.wgrajDrugiObraz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wgrajDrugiObraz.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.wgrajDrugiObraz.Depth = 0;
            this.wgrajDrugiObraz.HighEmphasis = true;
            this.wgrajDrugiObraz.Icon = null;
            this.wgrajDrugiObraz.Location = new System.Drawing.Point(174, 571);
            this.wgrajDrugiObraz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wgrajDrugiObraz.MouseState = MaterialSkin.MouseState.HOVER;
            this.wgrajDrugiObraz.Name = "wgrajDrugiObraz";
            this.wgrajDrugiObraz.NoAccentTextColor = System.Drawing.Color.Empty;
            this.wgrajDrugiObraz.Size = new System.Drawing.Size(169, 36);
            this.wgrajDrugiObraz.TabIndex = 41;
            this.wgrajDrugiObraz.Text = "WGRAJ DRUGI OBRAZ";
            this.wgrajDrugiObraz.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.wgrajDrugiObraz.UseAccentColor = false;
            this.wgrajDrugiObraz.UseVisualStyleBackColor = true;
            this.wgrajDrugiObraz.Click += new System.EventHandler(this.wgrajDrugiObraz_Click);
            // 
            // tworzenieHistogramu
            // 
            this.tworzenieHistogramu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tworzenieHistogramu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.tworzenieHistogramu.Depth = 0;
            this.tworzenieHistogramu.HighEmphasis = true;
            this.tworzenieHistogramu.Icon = null;
            this.tworzenieHistogramu.Location = new System.Drawing.Point(1050, 523);
            this.tworzenieHistogramu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tworzenieHistogramu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tworzenieHistogramu.Name = "tworzenieHistogramu";
            this.tworzenieHistogramu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.tworzenieHistogramu.Size = new System.Drawing.Size(168, 36);
            this.tworzenieHistogramu.TabIndex = 42;
            this.tworzenieHistogramu.Text = "STWÓRZ HISTOGRAM";
            this.tworzenieHistogramu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.tworzenieHistogramu.UseAccentColor = false;
            this.tworzenieHistogramu.UseVisualStyleBackColor = true;
            this.tworzenieHistogramu.Click += new System.EventHandler(this.tworzenieHistogramu_Click);
            // 
            // RBGnaHSV
            // 
            this.RBGnaHSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RBGnaHSV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RBGnaHSV.Depth = 0;
            this.RBGnaHSV.HighEmphasis = true;
            this.RBGnaHSV.Icon = null;
            this.RBGnaHSV.Location = new System.Drawing.Point(612, 523);
            this.RBGnaHSV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RBGnaHSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.RBGnaHSV.Name = "RBGnaHSV";
            this.RBGnaHSV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RBGnaHSV.Size = new System.Drawing.Size(166, 36);
            this.RBGnaHSV.TabIndex = 44;
            this.RBGnaHSV.Text = "ZMIANA RGB NA HSV";
            this.RBGnaHSV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RBGnaHSV.UseAccentColor = false;
            this.RBGnaHSV.UseVisualStyleBackColor = true;
            this.RBGnaHSV.Click += new System.EventHandler(this.RBGnaHSV_Click);
            // 
            // metodaSredniej
            // 
            this.metodaSredniej.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metodaSredniej.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.metodaSredniej.Depth = 0;
            this.metodaSredniej.HighEmphasis = true;
            this.metodaSredniej.Icon = null;
            this.metodaSredniej.Location = new System.Drawing.Point(564, 618);
            this.metodaSredniej.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.metodaSredniej.MouseState = MaterialSkin.MouseState.HOVER;
            this.metodaSredniej.Name = "metodaSredniej";
            this.metodaSredniej.NoAccentTextColor = System.Drawing.Color.Empty;
            this.metodaSredniej.Size = new System.Drawing.Size(274, 36);
            this.metodaSredniej.TabIndex = 45;
            this.metodaSredniej.Text = "WYKORZYSTANIE METODY ŚREDNIEj";
            this.metodaSredniej.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.metodaSredniej.UseAccentColor = false;
            this.metodaSredniej.UseVisualStyleBackColor = true;
            this.metodaSredniej.Click += new System.EventHandler(this.metodaSredniej_Click);
            // 
            // metodaYUV
            // 
            this.metodaYUV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metodaYUV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.metodaYUV.Depth = 0;
            this.metodaYUV.HighEmphasis = true;
            this.metodaYUV.Icon = null;
            this.metodaYUV.Location = new System.Drawing.Point(542, 666);
            this.metodaYUV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.metodaYUV.MouseState = MaterialSkin.MouseState.HOVER;
            this.metodaYUV.Name = "metodaYUV";
            this.metodaYUV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.metodaYUV.Size = new System.Drawing.Size(310, 36);
            this.metodaYUV.TabIndex = 46;
            this.metodaYUV.Text = "WYKORZYSTANIE METODY Z MODELU YUV";
            this.metodaYUV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.metodaYUV.UseAccentColor = false;
            this.metodaYUV.UseVisualStyleBackColor = true;
            this.metodaYUV.Click += new System.EventHandler(this.metodaYUV_Click);
            // 
            // RGBnaYUV
            // 
            this.RGBnaYUV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RGBnaYUV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RGBnaYUV.Depth = 0;
            this.RGBnaYUV.HighEmphasis = true;
            this.RGBnaYUV.Icon = null;
            this.RGBnaYUV.Location = new System.Drawing.Point(612, 571);
            this.RGBnaYUV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RGBnaYUV.MouseState = MaterialSkin.MouseState.HOVER;
            this.RGBnaYUV.Name = "RGBnaYUV";
            this.RGBnaYUV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RGBnaYUV.Size = new System.Drawing.Size(165, 36);
            this.RGBnaYUV.TabIndex = 47;
            this.RGBnaYUV.Text = "ZMIANA RGB NA YUV";
            this.RGBnaYUV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RGBnaYUV.UseAccentColor = false;
            this.RGBnaYUV.UseVisualStyleBackColor = true;
            this.RGBnaYUV.Click += new System.EventHandler(this.RGBnaYUV_Click);
            // 
            // datekcjaKrawedzi
            // 
            this.datekcjaKrawedzi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datekcjaKrawedzi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.datekcjaKrawedzi.Depth = 0;
            this.datekcjaKrawedzi.HighEmphasis = true;
            this.datekcjaKrawedzi.Icon = null;
            this.datekcjaKrawedzi.Location = new System.Drawing.Point(610, 714);
            this.datekcjaKrawedzi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.datekcjaKrawedzi.MouseState = MaterialSkin.MouseState.HOVER;
            this.datekcjaKrawedzi.Name = "datekcjaKrawedzi";
            this.datekcjaKrawedzi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.datekcjaKrawedzi.Size = new System.Drawing.Size(170, 36);
            this.datekcjaKrawedzi.TabIndex = 48;
            this.datekcjaKrawedzi.Text = "DETEKCJA KRAWĘDZI";
            this.datekcjaKrawedzi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.datekcjaKrawedzi.UseAccentColor = false;
            this.datekcjaKrawedzi.UseVisualStyleBackColor = true;
            this.datekcjaKrawedzi.Click += new System.EventHandler(this.datekcjaKrawedzi_Click);
            // 
            // odejmowanieObrazow
            // 
            this.odejmowanieObrazow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.odejmowanieObrazow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.odejmowanieObrazow.Depth = 0;
            this.odejmowanieObrazow.HighEmphasis = true;
            this.odejmowanieObrazow.Icon = null;
            this.odejmowanieObrazow.Location = new System.Drawing.Point(1482, 523);
            this.odejmowanieObrazow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.odejmowanieObrazow.MouseState = MaterialSkin.MouseState.HOVER;
            this.odejmowanieObrazow.Name = "odejmowanieObrazow";
            this.odejmowanieObrazow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.odejmowanieObrazow.Size = new System.Drawing.Size(201, 36);
            this.odejmowanieObrazow.TabIndex = 49;
            this.odejmowanieObrazow.Text = "ODEJMOWANIE OBRAZÓW";
            this.odejmowanieObrazow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.odejmowanieObrazow.UseAccentColor = false;
            this.odejmowanieObrazow.UseVisualStyleBackColor = true;
            this.odejmowanieObrazow.Click += new System.EventHandler(this.odejmowanieObrazow_Click);
            // 
            // progowanieTrackBar
            // 
            this.progowanieTrackBar.Depth = 0;
            this.progowanieTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progowanieTrackBar.Location = new System.Drawing.Point(924, 570);
            this.progowanieTrackBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progowanieTrackBar.Name = "progowanieTrackBar";
            this.progowanieTrackBar.RangeMax = 255;
            this.progowanieTrackBar.Size = new System.Drawing.Size(442, 40);
            this.progowanieTrackBar.TabIndex = 50;
            this.progowanieTrackBar.Text = "Progowanie (0-255)";
            this.progowanieTrackBar.Value = 0;
            this.progowanieTrackBar.ValueMax = 255;
            // 
            // kanalCzerwony
            // 
            this.kanalCzerwony.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kanalCzerwony.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.kanalCzerwony.Depth = 0;
            this.kanalCzerwony.HighEmphasis = true;
            this.kanalCzerwony.Icon = null;
            this.kanalCzerwony.Location = new System.Drawing.Point(623, 762);
            this.kanalCzerwony.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kanalCzerwony.MouseState = MaterialSkin.MouseState.HOVER;
            this.kanalCzerwony.Name = "kanalCzerwony";
            this.kanalCzerwony.NoAccentTextColor = System.Drawing.Color.Empty;
            this.kanalCzerwony.Size = new System.Drawing.Size(151, 36);
            this.kanalCzerwony.TabIndex = 51;
            this.kanalCzerwony.Text = "KANAŁ CZERWONY";
            this.kanalCzerwony.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.kanalCzerwony.UseAccentColor = false;
            this.kanalCzerwony.UseVisualStyleBackColor = true;
            this.kanalCzerwony.Click += new System.EventHandler(this.kanalCzerwony_Click);
            // 
            // kanalZielony
            // 
            this.kanalZielony.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kanalZielony.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.kanalZielony.Depth = 0;
            this.kanalZielony.HighEmphasis = true;
            this.kanalZielony.Icon = null;
            this.kanalZielony.Location = new System.Drawing.Point(634, 810);
            this.kanalZielony.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kanalZielony.MouseState = MaterialSkin.MouseState.HOVER;
            this.kanalZielony.Name = "kanalZielony";
            this.kanalZielony.NoAccentTextColor = System.Drawing.Color.Empty;
            this.kanalZielony.Size = new System.Drawing.Size(131, 36);
            this.kanalZielony.TabIndex = 52;
            this.kanalZielony.Text = "KANAŁ ZIELONY";
            this.kanalZielony.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.kanalZielony.UseAccentColor = false;
            this.kanalZielony.UseVisualStyleBackColor = true;
            this.kanalZielony.Click += new System.EventHandler(this.kanalZielony_Click);
            // 
            // kanalNiebieski
            // 
            this.kanalNiebieski.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kanalNiebieski.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.kanalNiebieski.Depth = 0;
            this.kanalNiebieski.HighEmphasis = true;
            this.kanalNiebieski.Icon = null;
            this.kanalNiebieski.Location = new System.Drawing.Point(629, 857);
            this.kanalNiebieski.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kanalNiebieski.MouseState = MaterialSkin.MouseState.HOVER;
            this.kanalNiebieski.Name = "kanalNiebieski";
            this.kanalNiebieski.NoAccentTextColor = System.Drawing.Color.Empty;
            this.kanalNiebieski.Size = new System.Drawing.Size(140, 36);
            this.kanalNiebieski.TabIndex = 53;
            this.kanalNiebieski.Text = "KANAŁ NIEBIESKI";
            this.kanalNiebieski.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.kanalNiebieski.UseAccentColor = false;
            this.kanalNiebieski.UseVisualStyleBackColor = true;
            this.kanalNiebieski.Click += new System.EventHandler(this.kanalNiebieski_Click);
            // 
            // progowanieObrazu
            // 
            this.progowanieObrazu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progowanieObrazu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.progowanieObrazu.Depth = 0;
            this.progowanieObrazu.HighEmphasis = true;
            this.progowanieObrazu.Icon = null;
            this.progowanieObrazu.Location = new System.Drawing.Point(1071, 619);
            this.progowanieObrazu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.progowanieObrazu.MouseState = MaterialSkin.MouseState.HOVER;
            this.progowanieObrazu.Name = "progowanieObrazu";
            this.progowanieObrazu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.progowanieObrazu.Size = new System.Drawing.Size(116, 36);
            this.progowanieObrazu.TabIndex = 54;
            this.progowanieObrazu.Text = "PROGOWANIE";
            this.progowanieObrazu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.progowanieObrazu.UseAccentColor = false;
            this.progowanieObrazu.UseVisualStyleBackColor = true;
            this.progowanieObrazu.Click += new System.EventHandler(this.progowanieObrazu_Click);
            // 
            // progowanieHistogram
            // 
            this.progowanieHistogram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progowanieHistogram.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.progowanieHistogram.Depth = 0;
            this.progowanieHistogram.HighEmphasis = true;
            this.progowanieHistogram.Icon = null;
            this.progowanieHistogram.Location = new System.Drawing.Point(935, 667);
            this.progowanieHistogram.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.progowanieHistogram.MouseState = MaterialSkin.MouseState.HOVER;
            this.progowanieHistogram.Name = "progowanieHistogram";
            this.progowanieHistogram.NoAccentTextColor = System.Drawing.Color.Empty;
            this.progowanieHistogram.Size = new System.Drawing.Size(402, 36);
            this.progowanieHistogram.TabIndex = 55;
            this.progowanieHistogram.Text = "Progowanie według maks. wartości histogramu";
            this.progowanieHistogram.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.progowanieHistogram.UseAccentColor = false;
            this.progowanieHistogram.UseVisualStyleBackColor = true;
            this.progowanieHistogram.Click += new System.EventHandler(this.progowanieHistogram_Click);
            // 
            // multiprogowanieObrazu
            // 
            this.multiprogowanieObrazu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiprogowanieObrazu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.multiprogowanieObrazu.Depth = 0;
            this.multiprogowanieObrazu.HighEmphasis = true;
            this.multiprogowanieObrazu.Icon = null;
            this.multiprogowanieObrazu.Location = new System.Drawing.Point(1053, 829);
            this.multiprogowanieObrazu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.multiprogowanieObrazu.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiprogowanieObrazu.Name = "multiprogowanieObrazu";
            this.multiprogowanieObrazu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.multiprogowanieObrazu.Size = new System.Drawing.Size(160, 36);
            this.multiprogowanieObrazu.TabIndex = 56;
            this.multiprogowanieObrazu.Text = "multiprogowanie";
            this.multiprogowanieObrazu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.multiprogowanieObrazu.UseAccentColor = false;
            this.multiprogowanieObrazu.UseVisualStyleBackColor = true;
            this.multiprogowanieObrazu.Click += new System.EventHandler(this.multiprogowanieObrazu_Click);
            // 
            // progowanieMinTrackBar
            // 
            this.progowanieMinTrackBar.Depth = 0;
            this.progowanieMinTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progowanieMinTrackBar.Location = new System.Drawing.Point(926, 731);
            this.progowanieMinTrackBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progowanieMinTrackBar.Name = "progowanieMinTrackBar";
            this.progowanieMinTrackBar.RangeMax = 255;
            this.progowanieMinTrackBar.Size = new System.Drawing.Size(442, 40);
            this.progowanieMinTrackBar.TabIndex = 57;
            this.progowanieMinTrackBar.Text = "Progowanie minimalne ";
            this.progowanieMinTrackBar.Value = 0;
            this.progowanieMinTrackBar.ValueMax = 255;
            // 
            // progowanieMaxTrackBar
            // 
            this.progowanieMaxTrackBar.Depth = 0;
            this.progowanieMaxTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progowanieMaxTrackBar.Location = new System.Drawing.Point(924, 777);
            this.progowanieMaxTrackBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progowanieMaxTrackBar.Name = "progowanieMaxTrackBar";
            this.progowanieMaxTrackBar.RangeMax = 255;
            this.progowanieMaxTrackBar.Size = new System.Drawing.Size(442, 40);
            this.progowanieMaxTrackBar.TabIndex = 58;
            this.progowanieMaxTrackBar.Text = "Progowanie maksymalne ";
            this.progowanieMaxTrackBar.Value = 0;
            this.progowanieMaxTrackBar.ValueMax = 255;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(174, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 59;
            this.materialLabel1.Text = "OBRAZ WEJŚCIOWY";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(536, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(329, 19);
            this.materialLabel2.TabIndex = 60;
            this.materialLabel2.Text = "DRUGI OBRAZ WEJŚCIOWY (LUB WYNIKOWY)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(1522, 76);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(125, 19);
            this.materialLabel3.TabIndex = 61;
            this.materialLabel3.Text = "ODJĘTE OBRAZY";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(1090, 75);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(92, 19);
            this.materialLabel4.TabIndex = 62;
            this.materialLabel4.Text = "HISTOGRAM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1829, 936);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.progowanieMaxTrackBar);
            this.Controls.Add(this.progowanieMinTrackBar);
            this.Controls.Add(this.multiprogowanieObrazu);
            this.Controls.Add(this.progowanieHistogram);
            this.Controls.Add(this.progowanieObrazu);
            this.Controls.Add(this.kanalNiebieski);
            this.Controls.Add(this.kanalZielony);
            this.Controls.Add(this.kanalCzerwony);
            this.Controls.Add(this.progowanieTrackBar);
            this.Controls.Add(this.odejmowanieObrazow);
            this.Controls.Add(this.datekcjaKrawedzi);
            this.Controls.Add(this.RGBnaYUV);
            this.Controls.Add(this.metodaYUV);
            this.Controls.Add(this.metodaSredniej);
            this.Controls.Add(this.RBGnaHSV);
            this.Controls.Add(this.tworzenieHistogramu);
            this.Controls.Add(this.wgrajDrugiObraz);
            this.Controls.Add(this.zresetujObraz);
            this.Controls.Add(this.obrazZapisz);
            this.Controls.Add(this.obrazWgraj);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Form1";
            this.Text = "Image Processing App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialButton obrazWgraj;
        private MaterialSkin.Controls.MaterialButton obrazZapisz;
        private MaterialSkin.Controls.MaterialButton zresetujObraz;
        private MaterialSkin.Controls.MaterialButton wgrajDrugiObraz;
        private MaterialSkin.Controls.MaterialButton tworzenieHistogramu;
        private MaterialSkin.Controls.MaterialButton RBGnaHSV;
        private MaterialSkin.Controls.MaterialButton metodaSredniej;
        private MaterialSkin.Controls.MaterialButton metodaYUV;
        private MaterialSkin.Controls.MaterialButton RGBnaYUV;
        private MaterialSkin.Controls.MaterialButton datekcjaKrawedzi;
        private MaterialSkin.Controls.MaterialButton odejmowanieObrazow;
        private MaterialSkin.Controls.MaterialSlider progowanieTrackBar;
        private MaterialSkin.Controls.MaterialButton kanalCzerwony;
        private MaterialSkin.Controls.MaterialButton kanalZielony;
        private MaterialSkin.Controls.MaterialButton kanalNiebieski;
        private MaterialSkin.Controls.MaterialButton progowanieObrazu;
        private MaterialSkin.Controls.MaterialButton progowanieHistogram;
        private MaterialSkin.Controls.MaterialButton multiprogowanieObrazu;
        private MaterialSkin.Controls.MaterialSlider progowanieMinTrackBar;
        private MaterialSkin.Controls.MaterialSlider progowanieMaxTrackBar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}

