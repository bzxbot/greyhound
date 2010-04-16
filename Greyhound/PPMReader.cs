using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace PNMReader
{
    class PPMReader
    {
        public Image GetImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }

            using (BinaryReader reader = new BinaryReader(new FileStream(filePath, FileMode.Open)))
            {
                if (reader.ReadChar() == 'P')
                {
                    char c = reader.ReadChar();

                    if (c == '3')
                    {
                        return GetTextImage(reader);
                    }
                    else if (c == '6')
                    {
                        return GetBinaryImage(reader);
                    }
                }
            }

            return null;
        }

        private Image GetBinaryImage(BinaryReader reader)
        {
            reader.ReadChar();

            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);
            int scale = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int red = reader.ReadByte();
                    int green = reader.ReadByte();
                    int blue = reader.ReadByte();

                    bitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return bitmap;
        }

        private Image GetTextImage(BinaryReader reader)
        {
            reader.ReadChar();

            char c;

            int width = GetNextHeaderValue(reader);
            int height = GetNextHeaderValue(reader);
            int scale = GetNextHeaderValue(reader);

            Bitmap bitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    string red = string.Empty;
                    string green = string.Empty;
                    string blue = string.Empty;

                    c = reader.ReadChar();

                    do
                    {
                        red += c;

                        c = reader.ReadChar();

                    } while (!(c == '\n' || c == ' ' || c == '\t'));

                    c = reader.ReadChar();

                    do
                    {
                        green += c;

                        c = reader.ReadChar();

                    } while (!(c == '\n' || c == ' ' || c == '\t'));

                    c = reader.ReadChar();

                    do
                    {
                        blue += c;

                        c = reader.ReadChar();

                    } while (!(c == '\n' || c == ' ' || c == '\t'));

                    bitmap.SetPixel(x, y, Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue)));
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
                    if (c == '\n' || c == ' ' || c == '\t')
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
    }
}
