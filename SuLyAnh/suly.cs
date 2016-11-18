using System;
using System.Collections.Generic;
using System.Drawing;

namespace SuLyAnh
{
    internal class suly
    {
        public static Image grayscale(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = temp.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return bmap;
        }

        public static Image rota_flip(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            bmap.RotateFlip(RotateFlipType.Rotate180FlipY);
            return bmap;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static Image lam_min(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    if (i > 0 && j > 0 && i < temp.Width - 2 && j < temp.Height - 2)
                    {
                        // c = temp.GetPixel(i, j);
                        byte r = (byte)(temp.GetPixel(i - 1, j - 1).R * 1 / 16 + temp.GetPixel(i - 1, j).R * 2 / 16 + temp.GetPixel(i - 1, j + 1).R * 1 / 16 +
                            temp.GetPixel(i, j - 1).R * 2 / 16 + temp.GetPixel(i, j).R * 4 / 16 + temp.GetPixel(i, j + 1).R * 2 / 16 +
                            temp.GetPixel(i + 1, j - 1).R * 1 / 16 + temp.GetPixel(i + 1, j).R * 2 / 16 + temp.GetPixel(i + 1, j + 1).R * 1 / 16);
                        byte g = (byte)(temp.GetPixel(i - 1, j - 1).G * 1 / 16 + temp.GetPixel(i - 1, j).G * 2 / 16 + temp.GetPixel(i - 1, j + 1).G * 1 / 16 +
                            temp.GetPixel(i, j - 1).G * 2 / 16 + temp.GetPixel(i, j).G * 4 / 16 + temp.GetPixel(i, j + 1).G * 2 / 16 +
                            temp.GetPixel(i + 1, j - 1).G * 1 / 16 + temp.GetPixel(i + 1, j).G * 2 / 16 + temp.GetPixel(i + 1, j + 1).G * 1 / 16);
                        byte b = (byte)(temp.GetPixel(i - 1, j - 1).B * 1 / 16 + temp.GetPixel(i - 1, j).B * 2 / 16 + temp.GetPixel(i - 1, j + 1).B * 1 / 16 +
                                                    temp.GetPixel(i, j - 1).B * 2 / 16 + temp.GetPixel(i, j).B * 4 / 16 + temp.GetPixel(i, j + 1).B * 2 / 16 +
                                                    temp.GetPixel(i + 1, j - 1).B * 1 / 16 + temp.GetPixel(i + 1, j).B * 2 / 16 + temp.GetPixel(i + 1, j + 1).B * 1 / 16);
                        bmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            return bmap;
        }

        /// <summary>
        /// Lọc trung bình đơn giản
        /// </summary>
        /// <param name="img"></param>
        /// <returns>Kết quả trả về là một ảnh đã được làm mịn</returns>
        public static Image trung_binh(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    if (i > 0 && j > 0 && i < temp.Width - 2 && j < temp.Height - 2)
                    {
                        // c = temp.GetPixel(i, j);
                        byte r = (byte)(temp.GetPixel(i - 1, j - 1).R * 1 / 9 + temp.GetPixel(i - 1, j).R * 1 / 9 + temp.GetPixel(i - 1, j + 1).R * 1 / 9 +
                            temp.GetPixel(i, j - 1).R * 1 / 9 + temp.GetPixel(i, j).R * 1 / 9 + temp.GetPixel(i, j + 1).R * 1 / 9 +
                            temp.GetPixel(i + 1, j - 1).R * 1 / 9 + temp.GetPixel(i + 1, j).R * 1 / 9 + temp.GetPixel(i + 1, j + 1).R * 1 / 9);
                        byte g = (byte)(temp.GetPixel(i - 1, j - 1).G * 1 / 9 + temp.GetPixel(i - 1, j).G * 1 / 9 + temp.GetPixel(i - 1, j + 1).G * 1 / 9 +
                            temp.GetPixel(i, j - 1).G * 1 / 9 + temp.GetPixel(i, j).G * 1 / 9 + temp.GetPixel(i, j + 1).G * 1 / 9 +
                            temp.GetPixel(i + 1, j - 1).G * 1 / 9 + temp.GetPixel(i + 1, j).G * 1 / 9 + temp.GetPixel(i + 1, j + 1).G * 1 / 9);
                        byte b = (byte)(temp.GetPixel(i - 1, j - 1).B * 1 / 9 + temp.GetPixel(i - 1, j).B * 1 / 9 + temp.GetPixel(i - 1, j + 1).B * 1 / 9 +
                            temp.GetPixel(i, j - 1).B * 1 / 9 + temp.GetPixel(i, j).B * 1 / 9 + temp.GetPixel(i, j + 1).B * 1 / 9 +
                            temp.GetPixel(i + 1, j - 1).B * 1 / 9 + temp.GetPixel(i + 1, j).B * 1 / 9 + temp.GetPixel(i + 1, j + 1).B * 1 / 9);
                        bmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            return bmap;
        }

        public static Image lam_noi(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    if (i > 0 && j > 0 && i < temp.Width - 2 && j < temp.Height - 2)
                    {
                        // c = temp.GetPixel(i, j);
                        byte r = (byte)(temp.GetPixel(i, j).R * 5 - temp.GetPixel(i + 1, j).R - temp.GetPixel(i - 1, j).R - temp.GetPixel(i, j + 1).R - temp.GetPixel(i, j - 1).R);
                        byte g = (byte)(temp.GetPixel(i, j).G * 5 - temp.GetPixel(i + 1, j).G - temp.GetPixel(i - 1, j).G - temp.GetPixel(i, j + 1).G - temp.GetPixel(i, j - 1).G);
                        byte b = (byte)(temp.GetPixel(i, j).B * 5 - temp.GetPixel(i + 1, j).B - temp.GetPixel(i - 1, j).B - temp.GetPixel(i, j + 1).B - temp.GetPixel(i, j - 1).B);
                        bmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            return bmap;
        }

        public static Image khu_nhieu(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            List<byte> temr = new List<byte>();
            List<byte> temb = new List<byte>();
            List<byte> temg = new List<byte>();

            for (int i = 1; i < temp.Width - 1; i++)
            {
                for (int j = 1; j < temp.Height - 1; j++)
                {
                    temr.Add(temp.GetPixel(i - 1, j - 1).R);
                    temr.Add(temp.GetPixel(i, j - 1).R);
                    temr.Add(temp.GetPixel(i + 1, j - 1).R);
                    temr.Add(temp.GetPixel(i - 1, j).R);
                    temr.Add(temp.GetPixel(i, j).R);
                    temr.Add(temp.GetPixel(i + 1, j).R);
                    temr.Add(temp.GetPixel(i - 1, j + 1).R);
                    temr.Add(temp.GetPixel(i, j + 1).R);
                    temr.Add(temp.GetPixel(i + 1, j + 1).R);
                    temr.Sort();
                    byte r = temr[4];

                    temb.Add(temp.GetPixel(i - 1, j - 1).B);
                    temb.Add(temp.GetPixel(i, j - 1).B);
                    temb.Add(temp.GetPixel(i + 1, j - 1).B);
                    temb.Add(temp.GetPixel(i - 1, j).B);
                    temb.Add(temp.GetPixel(i, j).B);
                    temb.Add(temp.GetPixel(i + 1, j).B);
                    temb.Add(temp.GetPixel(i - 1, j + 1).B);
                    temb.Add(temp.GetPixel(i, j + 1).B);
                    temb.Add(temp.GetPixel(i + 1, j + 1).B);
                    temb.Sort();
                    byte b = temb[4];

                    temg.Add(temp.GetPixel(i - 1, j - 1).G);
                    temg.Add(temp.GetPixel(i, j - 1).G);
                    temg.Add(temp.GetPixel(i + 1, j - 1).G);
                    temg.Add(temp.GetPixel(i - 1, j).G);
                    temg.Add(temp.GetPixel(i, j).G);
                    temg.Add(temp.GetPixel(i + 1, j).G);
                    temg.Add(temp.GetPixel(i - 1, j + 1).G);
                    temg.Add(temp.GetPixel(i, j + 1).G);
                    temg.Add(temp.GetPixel(i + 1, j + 1).G);
                    temg.Sort();
                    byte g = temg[4];

                    bmap.SetPixel(i, j, Color.FromArgb(r, b, g));

                    temr.Clear();
                    temb.Clear();
                    temg.Clear();
                }
            }
            return bmap;
        }

        public static Image do_sang(Image img, int n)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;

            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    byte r = 0, b = 0, g = 0;

                    c = temp.GetPixel(i, j);

                    if (c.R + n <= 255 && c.R >= 0)
                    {
                        r = (byte)(c.R + n);
                    }
                    else if (c.R + n > 255)
                    {
                        r = 255;
                    }
                    else if (c.R + n < 0)
                    {
                        r = 0;
                    }

                    if (c.B + n <= 255 && c.B > 0)
                    {
                        b = (byte)(c.B + n);
                    }
                    else if (c.B + n > 255)
                    {
                        b = 255;
                    }
                    else if (c.B + n < 0)
                    {
                        b = 0;
                    }

                    if (c.G + n <= 255 && c.G > 0)
                    {
                        g = (byte)(c.G + n);
                    }
                    else if (c.G + n > 255)
                    {
                        g = 255;
                    }
                    else if (c.G + n < 0)
                    {
                        g = 0;
                    }

                    bmap.SetPixel(i, j, Color.FromArgb(r, b, g));
                }
            }
            return bmap;
        }

        #region tương phản

        public static Image tuong_phan(Image img, int n)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    byte r = 0, b = 0, g = 0;

                    c = temp.GetPixel(i, j);

                    if (c.R * n <= 255 && c.R >= 0)
                    {
                        r = (byte)(c.R * n);
                    }
                    else if (c.R * n > 255)
                    {
                        r = 255;
                    }
                    else if (c.R * n < 0)
                    {
                        r = 0;
                    }

                    if (c.B * n <= 255 && c.B > 0)
                    {
                        b = (byte)(c.B * n);
                    }
                    else if (c.B * n > 255)
                    {
                        b = 255;
                    }
                    else if (c.B * n < 0)
                    {
                        b = 0;
                    }

                    if (c.G * n <= 255 && c.G > 0)
                    {
                        g = (byte)(c.G + n);
                    }
                    else if (c.G * n > 255)
                    {
                        g = 255;
                    }
                    else if (c.G * n < 0)
                    {
                        g = 0;
                    }

                    bmap.SetPixel(i, j, Color.FromArgb(r, b, g));
                }
            }
            return bmap;
        }

        #endregion tương phản

        public static Image am_ban(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    byte r = (byte)(255 - temp.GetPixel(i, j).R);
                    byte g = (byte)(255 - temp.GetPixel(i, j).G);
                    byte b = (byte)(255 - temp.GetPixel(i, j).B);
                    bmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return bmap;
        }

        public static Image sobel(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            for (int i = 1; i < temp.Width - 2; i++)
            {
                for (int j = 1; j < temp.Height - 2; j++)
                {
                    // c = temp.GetPixel(i, j);
                    int r1 = (-temp.GetPixel(i, j).R
                        - 2 * temp.GetPixel(i, j + 1).R
                        - temp.GetPixel(i, j + 2).R
                        + temp.GetPixel(i + 2, j).R
                        + 2 * temp.GetPixel(i + 2, j + 1).R +
                          temp.GetPixel(i + 2, j + 2).R);
                    //int b1 = -temp.GetPixel(i, j).B
                    //        - 2 * temp.GetPixel(i, j + 1).B
                    //        - temp.GetPixel(i, j + 2).B
                    //        + temp.GetPixel(i + 2, j).B
                    //        + 2 * temp.GetPixel(i + 2, j + 1).B
                    //        + temp.GetPixel(i + 2, j + 2).B;
                    //int g1 = -temp.GetPixel(i, j).G
                    //        - 2 * temp.GetPixel(i, j + 1).G
                    //        - temp.GetPixel(i, j + 2).G
                    //        + temp.GetPixel(i + 2, j).G
                    //        + 2 * temp.GetPixel(i + 2, j + 1).G
                    //        + temp.GetPixel(i + 2, j + 2).G;

                    int r2 = -temp.GetPixel(i, j).R
                        - 2 * temp.GetPixel(i + 1, j).R
                        - temp.GetPixel(i + 2, j).R
                        + temp.GetPixel(i, j + 2).R
                          + 2 * temp.GetPixel(i + 1, j + 2).R
                          + temp.GetPixel(i + 2, j + 2).R;
                    //int b2 = temp.GetPixel(i, j).B
                    //    - 2 * temp.GetPixel(i + 1, j).B
                    //    - temp.GetPixel(i + 2, j).B
                    //    +
                    //      temp.GetPixel(i, j + 2).B
                    //      + 2 * temp.GetPixel(i + 1, j + 2).B
                    //      + temp.GetPixel(i + 2, j + 2).B;
                    //int g2 = -temp.GetPixel(i, j).G
                    //    - 2 * temp.GetPixel(i + 1, j).G
                    //    - temp.GetPixel(i + 2, j).G +
                    //      temp.GetPixel(i, j + 2).G
                    //      + 2 * temp.GetPixel(i + 1, j + 2).G
                    //      + temp.GetPixel(i + 2, j + 2).G;

                    int r = (Math.Abs(r1) + Math.Abs(r2));
                    //int b = (Math.Abs(b1) + Math.Abs(b2));
                    //int g = (Math.Abs(g1) + Math.Abs(g2));

                    if (r > 255)
                        r = 255;
                    //if (r < 0)
                    //    r = 0;
                    //if (b > 255)
                    //    b = 255;
                    //if (b < 0)
                    //    b = 0;
                    //if (g > 255)
                    //    g = 255;
                    //if (g < 0)
                    //    g = 0;

                    bmap.SetPixel(i + 1, j + 1, Color.FromArgb(r, r, r));
                }
            }
            return bmap;
        }

        public static Image histogram(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            int[] hr = new int[256];
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    hr[Convert.ToInt32(temp.GetPixel(i, j).R)] += 1;
                    //hg[temp.GetPixel(i, j).G] += 1;
                    // hb[temp.GetPixel(i, j).B] += 1;
                    //bmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            int a = temp.Width / 256;
            int cs = 0;
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    for (int k = 0; k < a; k++)
                    {
                        if (j < temp.Height - hr[cs])
                            bmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                            bmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        i += k;
                        cs += 1;
                    }
                }
            }
            return bmap;
        }

        //làm mịn Gaussian
        public static Image Gaussian(Image img)
        {
            Bitmap temp = new Bitmap(img);
            Bitmap bmap = (Bitmap)temp.Clone();
            for (int i = 0; i < temp.Width - 4; i++)
            {
                for (int j = 0; j < temp.Height - 4; j++)
                {
                    int r = (temp.GetPixel(i, j).R
                        + temp.GetPixel(i + 1, j).R * 4
                        + temp.GetPixel(i + 2, j).R * 7
                        + temp.GetPixel(i + 3, j).R * 4
                        + temp.GetPixel(i + 4, j).R
                        + temp.GetPixel(i, j + 1).R * 4
                        + temp.GetPixel(i + 1, j + 1).R * 16
                        + temp.GetPixel(i + 2, j + 1).R * 26
                        + temp.GetPixel(i + 3, j + 1).R * 16
                        + temp.GetPixel(i + 4, j + 1).R * 4
                        + temp.GetPixel(i, j + 2).R * 7
                        + temp.GetPixel(i + 1, j + 2).R * 26
                        + temp.GetPixel(i + 2, j + 2).R * 41
                        + temp.GetPixel(i + 3, j + 2).R * 26
                        + temp.GetPixel(i + 4, j + 2).R * 7
                        + temp.GetPixel(i, j + 3).R * 4
                        + temp.GetPixel(i + 1, j + 3).R * 16
                        + temp.GetPixel(i + 2, j + 3).R * 26
                        + temp.GetPixel(i + 3, j + 3).R * 16
                        + temp.GetPixel(i + 4, j + 3).R * 4
                        + temp.GetPixel(i, j + 4).R
                        + temp.GetPixel(i + 1, j + 4).R * 4
                        + temp.GetPixel(i + 2, j + 4).R * 7
                        + temp.GetPixel(i + 3, j + 4).R * 4
                        + temp.GetPixel(i + 4, j + 4).R) / 273;

                    int b = (temp.GetPixel(i, j).B
                       + temp.GetPixel(i + 1, j).B * 4
                       + temp.GetPixel(i + 2, j).B * 7
                       + temp.GetPixel(i + 3, j).B * 4
                       + temp.GetPixel(i + 4, j).B
                       + temp.GetPixel(i, j + 1).B * 4
                       + temp.GetPixel(i + 1, j + 1).B * 16
                       + temp.GetPixel(i + 2, j + 1).B * 26
                       + temp.GetPixel(i + 3, j + 1).B * 16
                       + temp.GetPixel(i + 4, j + 1).B * 4
                       + temp.GetPixel(i, j + 2).B * 7
                       + temp.GetPixel(i + 1, j + 2).B * 26
                       + temp.GetPixel(i + 2, j + 2).B * 41
                       + temp.GetPixel(i + 3, j + 2).B * 26
                       + temp.GetPixel(i + 4, j + 2).B * 7
                       + temp.GetPixel(i, j + 3).B * 4
                       + temp.GetPixel(i + 1, j + 3).B * 16
                       + temp.GetPixel(i + 2, j + 3).B * 26
                       + temp.GetPixel(i + 3, j + 3).B * 16
                       + temp.GetPixel(i + 4, j + 3).B * 4
                       + temp.GetPixel(i, j + 4).B
                       + temp.GetPixel(i + 1, j + 4).B * 4
                       + temp.GetPixel(i + 2, j + 4).B * 7
                       + temp.GetPixel(i + 3, j + 4).B * 4
                       + temp.GetPixel(i + 4, j + 4).B) / 273;

                    int g = (temp.GetPixel(i, j).G
                       + temp.GetPixel(i + 1, j).G * 4
                       + temp.GetPixel(i + 2, j).G * 7
                       + temp.GetPixel(i + 3, j).G * 4
                       + temp.GetPixel(i + 4, j).G
                       + temp.GetPixel(i, j + 1).G * 4
                       + temp.GetPixel(i + 1, j + 1).G * 16
                       + temp.GetPixel(i + 2, j + 1).G * 26
                       + temp.GetPixel(i + 3, j + 1).G * 16
                       + temp.GetPixel(i + 4, j + 1).G * 4
                       + temp.GetPixel(i, j + 2).G * 7
                       + temp.GetPixel(i + 1, j + 2).G * 26
                       + temp.GetPixel(i + 2, j + 2).G * 41
                       + temp.GetPixel(i + 3, j + 2).G * 26
                       + temp.GetPixel(i + 4, j + 2).G * 7
                       + temp.GetPixel(i, j + 3).G * 4
                       + temp.GetPixel(i + 1, j + 3).G * 16
                       + temp.GetPixel(i + 2, j + 3).G * 26
                       + temp.GetPixel(i + 3, j + 3).G * 16
                       + temp.GetPixel(i + 4, j + 3).G * 4
                       + temp.GetPixel(i, j + 4).G
                       + temp.GetPixel(i + 1, j + 4).G * 4
                       + temp.GetPixel(i + 2, j + 4).G * 7
                       + temp.GetPixel(i + 3, j + 4).G * 4
                       + temp.GetPixel(i + 4, j + 4).G) / 273;

                    bmap.SetPixel(i + 2, j + 2, Color.FromArgb(r, g, b));
                }
            }
            return bmap;
        }
    }
}