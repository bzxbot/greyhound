using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Greyhound.TileEditor
{
    static class ImageProcessing
    {
        #region Public Methods

        public static Image ApplyGrayScale(Image imgOrig)
        {
            Bitmap grayScale = new Bitmap(imgOrig);

            for (int x = 0; x < grayScale.Width; x++)
            {
                for (int y = 0; y < grayScale.Height; y++)
                {
                    Color pixel = grayScale.GetPixel(x, y);
                    byte grayedValue = (byte)(.299 * pixel.R + .587 * pixel.G + .114 * pixel.B);
                    grayScale.SetPixel(x, y, Color.FromArgb(grayedValue, grayedValue, grayedValue));
                }
            }

            return grayScale;
        }

        public static Image ApplySepia(Image imgOrig)
        {
            Bitmap sepiaImage = new Bitmap(imgOrig);

            for (int x = 0; x < sepiaImage.Width; x++)
            {
                for (int y = 0; y < sepiaImage.Height; y++)
                {
                    Color pixel = sepiaImage.GetPixel(x, y);

                    int redColor = Convert.ToInt32((pixel.R * .393 + pixel.G * .769 + pixel.B * .189));
                    int greenColor = Convert.ToInt32((pixel.R * .349 + pixel.G * .686 + pixel.B * .168));
                    int blueColor = Convert.ToInt32((pixel.R * .272 + pixel.G * .534 + pixel.B * .131));

                    if (redColor > 255)
                        redColor = 255;

                    if (greenColor > 255)
                        greenColor = 255;

                    if (blueColor > 255)
                        blueColor = 255;

                    sepiaImage.SetPixel(x, y, Color.FromArgb(redColor, greenColor, blueColor));
                }
            }

            return sepiaImage;
        }

        public static Image ApplyInvertColor(Image imgOrig)
        {
            Bitmap invertedColors = new Bitmap(imgOrig);

            for (int x = 0; x < invertedColors.Width; x++)
            {
                for (int y = 0; y < invertedColors.Height; y++)
                {
                    Color pixel = invertedColors.GetPixel(x, y);

                    int Rcolor = 255 - pixel.R;
                    int Gcolor = 255 - pixel.G;
                    int Bcolor = 255 - pixel.B;

                    invertedColors.SetPixel(x, y, Color.FromArgb(Rcolor, Gcolor, Bcolor));
                }
            }

            return invertedColors;
        }

        public static Image ChangeHue(Image imgOrig, Color color)
        {
            HSLColor neoHue = ConvertRBGtoHSL(color);

            Bitmap changedHue = new Bitmap(imgOrig);

            for (int x = 0; x < changedHue.Width; x++)
            {
                for (int y = 0; y < changedHue.Height; y++)
                {
                    Color pixel = changedHue.GetPixel(x, y);
                    HSLColor hslPixel = ConvertRBGtoHSL(pixel);

                    hslPixel.H = neoHue.H;

                    changedHue.SetPixel(x, y, ConvertHSLtoRGB(hslPixel));
                }
            }

            return changedHue;
        }

        #endregion Public Methods

        #region Private Methods

        private static double MaxValue(Double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return -1;
            }

            double maxValue = values[0];

            foreach (double value in values)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }

        private static double MinValue(Double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return -1;
            }

            double minValue = values[0];

            foreach (double value in values)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
            }

            return minValue;
        }

        private static HSLColor ConvertRBGtoHSL(Color color)
        {
            HSLColor hsl1 = new HSLColor();
            hsl1.H = color.GetHue() / 360.0;
            hsl1.L = color.GetBrightness();
            hsl1.S = color.GetSaturation();
            return hsl1;

            //HSLColor hsl = new HSLColor();
            ////Passa r g e b para escala de 1
            //double red = color.R / 255.0;
            //double green = color.G / 255.0;
            //double blue = color.B / 255.0;

            ////L = (max + min) /2
            //double maxColor = MaxValue(new double[] { red, green, blue });
            //double minColor = MinValue(new double[] { red, green, blue });
            //hsl.L = (maxColor + minColor) / 2.0;

            //if (maxColor == minColor)
            //{
            //    hsl.S = 0;
            //    hsl.H = 0;
            //}
            //else
            //{
            //    if (hsl.L < .5)
            //    {
            //        hsl.S = (maxColor - minColor) / (maxColor + minColor);
            //    }
            //    else
            //    {
            //        hsl.S = (maxColor - minColor) / (2 - maxColor - minColor);
            //    }

            //    if (red == maxColor)
            //    {
            //        hsl.H = (green - blue) / (maxColor - minColor);
            //    }

            //    else if (green == maxColor)
            //    {
            //        hsl.H = 2 + (blue - red) / (maxColor - minColor);
            //    }

            //    else
            //    {
            //        hsl.H = 4 + (red - green) / (maxColor - minColor);
            //    }
            //}
                      
            //hsl.H *= 60;

            //while (hsl.H < 0)
            //{
            //    hsl.H += 360;
            //}

            //return hsl;
        }

        private static Color ConvertHSLtoRGB(HSLColor hsl)
        {
            double r = 0, g = 0, b = 0;
            double temp1, temp2;

            if (hsl.L == 0)
            {
                r = g = b = 0;
            }
            else
            {
                if (hsl.S == 0)
                {
                    r = g = b = hsl.L;
                }

                else
                {
                    temp2 = ((hsl.L <= 0.5) ? hsl.L * (1.0 + hsl.S) : hsl.L + hsl.S - (hsl.L * hsl.S));

                    temp1 = 2.0 * hsl.L - temp2;

                    double[] t3 = new double[] { hsl.H + 1.0 / 3.0, hsl.H, hsl.H - 1.0 / 3.0 };
                    double[] clr = new double[] { 0, 0, 0 };

                    for (int i = 0; i < 3; i++)
                    {
                        if (t3[i] < 0)
                        {
                            t3[i] += 1.0;
                        }

                        if (t3[i] > 1)
                        {
                            t3[i] -= 1.0;
                        }

                        if (6.0 * t3[i] < 1.0)
                        {
                            clr[i] = temp1 + (temp2 - temp1) * t3[i] * 6.0;
                        }
                        else if (2.0 * t3[i] < 1.0)
                        {
                            clr[i] = temp2;
                        }
                        else if (3.0 * t3[i] < 2.0)
                        {
                            clr[i] = (temp1 + (temp2 - temp1) * ((2.0 / 3.0) - t3[i]) * 6.0);
                        }
                        else
                        {
                            clr[i] = temp1;
                        }
                    }

                    r = clr[0];
                    g = clr[1];
                    b = clr[2];
                }
            }

            return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
        }

        #endregion Private Methods
    }
}
