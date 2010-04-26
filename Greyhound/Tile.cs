using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;

namespace Greyhound
{
    public class Tile
    {
        public Bitmap bitmap;
        public Bitmap Bitmap
        {
            get
            {
                return bitmap;
            }
            set
            {
                bitmap = value;

                using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
                {
                    MemoryStream ms = new MemoryStream();

                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                    ImageHash = Convert.ToBase64String(sha1.ComputeHash(ms));
                }
            }
        }

        public string ImageHash { get; private set; }

    }
}
