using System.Drawing;
using System.IO;

namespace Greyhound
{
    class PNMReader
    {
        public Image ReadImage(string path)
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                if (reader.ReadChar() == 'P')
                {
                    char c = reader.ReadChar();

                    switch (c)
                    {
                        case '1':
                            return this.ReadTextBitmapImage(reader);
                        case '2':
                            return this.ReadTextGreyscaleImage(reader);
                        case '3':
                            return this.ReadTextPixelImage(reader);
                        case '4':
                            return this.ReadBinaryBitmapImage(reader);
                        case '5':
                            return this.ReadBinaryGreyscaleImage(reader);
                        case '6':
                            return this.ReadBinaryPixelImage(reader);
                    }
                }
            }

            return null;
        }

        private Image ReadTextBitmapImage(BinaryReader reader)
        {
            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int bit = GetNextTextValue(reader) == 0 ? 255 : 0;

                    bitmap.SetPixel(x, y, Color.FromArgb(bit, bit, bit));
                }
            }

            return bitmap;
        }

        private Image ReadTextGreyscaleImage(BinaryReader reader)
        {
            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);
            int scale = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int grey = GetNextTextValue(reader) * 255 / scale;

                    bitmap.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }

            return bitmap;
        }

        private Image ReadTextPixelImage(BinaryReader reader)
        {
            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);
            int scale = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int red = GetNextTextValue(reader) * 255 / scale;
                    int green = GetNextTextValue(reader) * 255 / scale;
                    int blue = GetNextTextValue(reader) * 255 / scale;

                    bitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return bitmap;
        }

        private Image ReadBinaryBitmapImage(BinaryReader reader)
        {
            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int bit = reader.ReadByte() == 0 ? 255 : 0;

                    bitmap.SetPixel(x, y, Color.FromArgb(bit, bit, bit));
                }
            }

            return bitmap;
        }

        private Image ReadBinaryGreyscaleImage(BinaryReader reader)
        {
            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);
            int scale = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int grey = reader.ReadByte() * 255 / scale;

                    bitmap.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }

            return bitmap;
        }

        private Image ReadBinaryPixelImage(BinaryReader reader)
        {
            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);
            int scale = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int red = reader.ReadByte() * 255 / scale;
                    int green = reader.ReadByte() * 255 / scale;
                    int blue = reader.ReadByte() * 255 / scale;

                    bitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return bitmap;
        }

        private int GetNextHeaderValue(BinaryReader reader)
        {
            bool hasValue = false;
            string value = string.Empty;
            char c;
            bool comment = false;

            do
            {
                c = reader.ReadChar();

                if (c == '#')
                {
                    comment = true;
                }

                if (comment)
                {
                    if (c == '\n')
                    {
                        comment = false;
                    }

                    continue;
                }

                if (!hasValue)
                {
                    if ((c == '\n' || c == ' ' || c == '\t') && value.Length != 0)
                    {
                        hasValue = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        value += c;
                    }
                }

            } while (!hasValue);

            return int.Parse(value);
        }

        private int GetNextTextValue(BinaryReader reader)
        {
            string value = string.Empty;
            char c = reader.ReadChar();

            do
            {
                value += c;

                if (reader.BaseStream.Position < reader.BaseStream.Length)
                    c = reader.ReadChar();

            } while ((!(c == '\n' || c == ' ' || c == '\t') || value.Length == 0) && reader.BaseStream.Position < reader.BaseStream.Length);

            return int.Parse(value);
        }
    }
}