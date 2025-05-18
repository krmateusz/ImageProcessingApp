using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ImageProcessingApp
{
    public partial class Form1 : MaterialForm
    {

        Bitmap obrazek;
        Bitmap obrazek1;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.LightBlue100, Accent.LightBlue200, TextShade.WHITE);
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            chart1.BackColor = Color.White;
        }


   
        private void RGBtoHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            value = max / 255d;

            if (max == min)
            {
                hue = 0;
                saturation = 0;
            }
            else
            {
                double chroma = max - min;
                hue = (max - min) / (max + min) < 0.00001 ? 0 : 60 * ((max - min) / (max + min) + (min - max) / (6 - (max + min)));
                saturation = chroma / max;
            }
        }

        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = (int)((hue * 6) % 6);
            double f = hue * 6 - Math.Floor(hue * 6);

            value = value * 255;
            int v = (int)value;
            int p = (int)(value * (1 - saturation));
            int q = (int)(value * (1 - f * saturation));
            int t = (int)(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }



 
        private void obrazWgraj_Click(object sender, EventArgs e)
        {
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.bmp;*.tiff;*.tif";
            if (okienko.ShowDialog() == DialogResult.OK && okienko.CheckFileExists == true)
            {
                pictureBox3.Image = Image.FromFile(okienko.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void obrazZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog okienko = new SaveFileDialog();
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image.Save(okienko.FileName, ImageFormat.Png);
                MessageBox.Show("Zapisano plik");
            }
        }

        private void zresetujObraz_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox3.Image;
        }

        private void RBGnaHSV_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);

                    double hue, saturation, value;
                    RGBtoHSV(oryginalnyKolor, out hue, out saturation, out value);

                    Color nowyKolor = ColorFromHSV(hue, saturation, value);

                    obrazek.SetPixel(x, y, nowyKolor);
                }
            }

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void wgrajDrugiObraz_Click(object sender, EventArgs e)
        {
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.bmp;*.tiff;*.tif";
            if (okienko.ShowDialog() == DialogResult.OK && okienko.CheckFileExists == true)
            {
                pictureBox4.Image = Image.FromFile(okienko.FileName);
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void tworzenieHistogramu_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox4.Image);

            int[] histogram = new int[256];

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);

                    if (oryginalnyKolor.R == oryginalnyKolor.G && oryginalnyKolor.G == oryginalnyKolor.B)
                    {
                        int odcienSzarosci = oryginalnyKolor.R;
                        histogram[odcienSzarosci]++;
                    }
                }
            }

            chart1.Series.Clear();
            chart1.Series.Add("Histogram");
            chart1.Series["Histogram"].ChartType = SeriesChartType.Area;

            for (int i = 0; i < histogram.Length; i++)
            {
                chart1.Series["Histogram"].Points.AddXY(i, histogram[i]);
            }

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void RGBnaYUV_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);


                    double Y = 0.299 * oryginalnyKolor.R + 0.587 * oryginalnyKolor.G + 0.114 * oryginalnyKolor.B;
                    double U = 0.493 * (oryginalnyKolor.B - Y);
                    double V = 0.877 * (oryginalnyKolor.R - Y);


                    int newY = (int)Y;
                    int newU = (int)(U + 128);
                    int newV = (int)(V + 128);


                    newY = Math.Max(0, Math.Min(255, newY));
                    newU = Math.Max(0, Math.Min(255, newU));
                    newV = Math.Max(0, Math.Min(255, newV));


                    Color newYUV = Color.FromArgb(newY, newU, newV);


                    obrazek.SetPixel(x, y, newYUV);
                }
            }

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void metodaSredniej_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = ((Bitmap)obrazek).GetPixel(x, y);
                    int wartoscSzarosci = (int)((oryginalnyKolor.R + oryginalnyKolor.G + oryginalnyKolor.B) / 3);
                    Color odcienSzarosci = Color.FromArgb(wartoscSzarosci, wartoscSzarosci, wartoscSzarosci);
                    obrazek.SetPixel(x, y, odcienSzarosci);
                }
            }
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void metodaYUV_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = ((Bitmap)obrazek).GetPixel(x, y);
                    int wartoscSzarosci = (int)(oryginalnyKolor.R * 0.299 + oryginalnyKolor.G * 0.587 + oryginalnyKolor.B * 0.114);
                    Color odcienSzarosci = Color.FromArgb(wartoscSzarosci, wartoscSzarosci, wartoscSzarosci);
                    obrazek.SetPixel(x, y, odcienSzarosci);
                }
            }
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void datekcjaKrawedzi_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);


            for (int y = 0; y < obrazek.Height - 1; y++)
            {
                for (int x = 0; x < obrazek.Width - 1; x++)
                {
                    Color aktualnyPixel = obrazek.GetPixel(x, y);
                    Color nastepnyPixelPoziomo = obrazek.GetPixel(x + 1, y);
                    Color nastepnyPixelPionowo = obrazek.GetPixel(x, y + 1);
                    Color nastepnyPixelUkosnie = obrazek.GetPixel(x + 1, y + 1);

                    int R_poziomo = Math.Abs(aktualnyPixel.R - nastepnyPixelPoziomo.R);
                    int G_poziomo = Math.Abs(aktualnyPixel.G - nastepnyPixelPoziomo.G);
                    int B_poziomo = Math.Abs(aktualnyPixel.B - nastepnyPixelPoziomo.B);

                    int R_pionowo = Math.Abs(aktualnyPixel.R - nastepnyPixelPionowo.R);
                    int G_pionowo = Math.Abs(aktualnyPixel.G - nastepnyPixelPionowo.G);
                    int B_pionowo = Math.Abs(aktualnyPixel.B - nastepnyPixelPionowo.B);

                    int R_uko = Math.Abs(aktualnyPixel.R - nastepnyPixelUkosnie.R);
                    int G_uko = Math.Abs(aktualnyPixel.G - nastepnyPixelUkosnie.G);
                    int B_uko = Math.Abs(aktualnyPixel.B - nastepnyPixelUkosnie.B);

                    int roznica_poziomo = (int)(R_poziomo * 0.299 + G_poziomo * 0.587 + B_poziomo * 0.114);
                    int roznica_pionowo = (int)(R_pionowo * 0.299 + G_pionowo * 0.587 + B_pionowo * 0.114);
                    int roznica_uko = (int)(R_uko * 0.299 + G_uko * 0.587 + B_uko * 0.114);

                    int roznica = Math.Max(roznica_poziomo, Math.Max(roznica_pionowo, roznica_uko));

                    Color kolorKrawedzi = Color.FromArgb(roznica, roznica, roznica);
                    obrazek.SetPixel(x, y, kolorKrawedzi);
                }
            }

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void kanalCzerwony_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);
            int wysokosc = obrazek.Height;
            int szerokosc = obrazek.Width;
            for (int y = 0; y < wysokosc; y++)
            {
                for (int x = 0; x < szerokosc; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);
                    int czerwony = oryginalnyKolor.R;
                    Color nowyKolor = Color.FromArgb(czerwony, 0, 0);
                    obrazek.SetPixel(x, y, nowyKolor);
                }
            }
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void kanalZielony_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);
            int wysokosc = obrazek.Height;
            int szerokosc = obrazek.Width;
            for (int y = 0; y < wysokosc; y++)
            {
                for (int x = 0; x < szerokosc; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);
                    int zielony = oryginalnyKolor.G;
                    Color nowyKolor = Color.FromArgb(0, zielony, 0);
                    obrazek.SetPixel(x, y, nowyKolor);
                }
            }
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void kanalNiebieski_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);
            int wysokosc = obrazek.Height;
            int szerokosc = obrazek.Width;
            for (int y = 0; y < wysokosc; y++)
            {
                for (int x = 0; x < szerokosc; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);
                    int niebiseki = oryginalnyKolor.B;
                    Color nowyKolor = Color.FromArgb(0, 0, niebiseki);
                    obrazek.SetPixel(x, y, nowyKolor);
                }
            }
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void odejmowanieObrazow_Click(object sender, EventArgs e)
        {
            obrazek = new Bitmap((Bitmap)pictureBox3.Image);
            obrazek1 = new Bitmap((Bitmap)pictureBox4.Image);


            Bitmap obrazWynikowy = new Bitmap(obrazek.Width, obrazek.Height);

            for (int y = 0; y < obrazWynikowy.Height; y++)
            {
                for (int x = 0; x < obrazWynikowy.Width; x++)
                {

                    Color piksel = obrazek.GetPixel(x, y);
                    Color piksel1 = obrazek1.GetPixel(x, y);

                    int wartoscSzarosci = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                    int wartoscSzarosci1 = (int)(piksel1.R * 0.299 + piksel1.G * 0.587 + piksel1.B * 0.114);
                    int roznica = wartoscSzarosci - wartoscSzarosci1;

                    if (roznica < 0)
                    {
                        roznica = 0;
                    }


                    Color kolorWynikowy = Color.FromArgb(roznica, roznica, roznica);
                    obrazWynikowy.SetPixel(x, y, kolorWynikowy);
                }
            }
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Image = obrazWynikowy;
        }

        private void progowanieObrazu_Click(object sender, EventArgs e)
        {
            int progowanie = progowanieTrackBar.Value;

            obrazek = new Bitmap((Bitmap)pictureBox3.Image);

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);
                    int wartoscSzarosci = (int)(oryginalnyKolor.R * 0.299 + oryginalnyKolor.G * 0.587 + oryginalnyKolor.B * 0.114);

                    if (wartoscSzarosci < progowanie)
                    {
                        obrazek.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        obrazek.SetPixel(x, y, Color.White);
                    }
                }
            }

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }

        private void progowanieHistogram_Click(object sender, EventArgs e)
        {
            int maxWartoscHistogramu = 0;
            int progowanie = 0;

            foreach (DataPoint point in chart1.Series["Histogram"].Points)
            {
                if (point.YValues[0] > maxWartoscHistogramu)
                {
                    maxWartoscHistogramu = (int)point.YValues[0];
                    progowanie = (int)point.XValue;
                }
            }
            obrazek = new Bitmap((Bitmap)pictureBox4.Image);
            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);

                    if (oryginalnyKolor.R < progowanie)
                    {
                        obrazek.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        obrazek.SetPixel(x, y, Color.White);
                    }
                }
            }

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
            MessageBox.Show($"Wartość progu: {progowanie}");
        }

        private void multiprogowanieObrazu_Click(object sender, EventArgs e)
        {
            int progowanieMin = progowanieMinTrackBar.Value;
            int progowanieMax = progowanieMaxTrackBar.Value;

            obrazek = new Bitmap((Bitmap)pictureBox3.Image);

            for (int y = 0; y < obrazek.Height; y++)
            {
                for (int x = 0; x < obrazek.Width; x++)
                {
                    Color oryginalnyKolor = obrazek.GetPixel(x, y);
                    int wartoscSzarosci = (int)(oryginalnyKolor.R * 0.299 + oryginalnyKolor.G * 0.587 + oryginalnyKolor.B * 0.114);

                    if (wartoscSzarosci >= progowanieMin && wartoscSzarosci <= progowanieMax)
                    {
                        obrazek.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        obrazek.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = obrazek;
        }
    }
}
