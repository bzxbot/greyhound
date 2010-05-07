using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Greyhound.TileEditor
{
    static class ImageFilters
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

        #endregion Public Methods
    }
}
