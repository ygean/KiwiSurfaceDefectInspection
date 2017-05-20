using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 图像处理
{
    /// <summary>
    /// 图像处理库
    /// </summary>
    public class ImagePro
    {
        /// <summary>
        /// 灰度化代码
        /// </summary>
        /// <param name="img1"></param>
        public unsafe static bool GrayScale(Bitmap b)
        {
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            IntPtr scan0 = bmData.Scan0;
            byte* p = (byte*)((void*)scan0);
            int noffset = stride - b.Width * 3;
            for (int y = 0; y < b.Height; y++)
            {
                for (int x = 0; x < b.Width; x++)
                {
                    byte blue = *p;
                    byte green = p[1];
                    byte red = p[2];
                    *p = (p[1] = (p[2] = (byte)(0.299 * (double)red + 0.587 * (double)green + 0.114 * (double)blue)));
                    p += 3;
                }
                p += noffset;
            }
            b.UnlockBits(bmData);
            return true;
        }

        /// <summary>
        /// 二值化代码
        /// </summary>
        /// <param name="sourceBitmap"></param>
        public unsafe static void Binarize(Bitmap sourceBitmap, string yuzhi)
        {
            if (sourceBitmap != null)
            {
                string Rbrthreshold = yuzhi;                
                if (Rbrthreshold == "" || Convert.ToInt16(Rbrthreshold) < -255 || Convert.ToInt16(Rbrthreshold) > 255)
                {
                    MessageBox.Show("阀值必须在-255~255之间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    Rectangle rect = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
                    BitmapData bmpData = sourceBitmap.LockBits(rect, ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
                    int rgbth = (int)Convert.ToInt16(Rbrthreshold);
                    byte* ptr = (byte*)((void*)bmpData.Scan0);
                    for (int i = 0; i < bmpData.Height; i++)
                    {
                        for (int j = 0; j < bmpData.Width; j++)
                        {
                            int blue;
                            if (rgbth > 0)
                            {
                                blue = (((int)(*ptr) < Math.Abs(rgbth)) ? 0 : 255);
                            }
                            else
                            {
                                blue = (((int)(*ptr) > Math.Abs(rgbth)) ? 0 : 255);
                            }
                            *ptr = (ptr[1] = (ptr[2] = (byte)blue));
                            ptr += 3;
                        }
                        ptr += bmpData.Stride - bmpData.Width * 3;
                    }
                    sourceBitmap.UnlockBits(bmpData);
                }

            }
            else
            {
                MessageBox.Show("无图像可处理", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        /// <summary>
        /// 获取图像总的像素量
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static unsafe byte[] GetImageAllPixel(Bitmap img)
        {
            byte[] result = new byte[img.Width * img.Height];
            int n = 0;
            BitmapData data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly,
                                           PixelFormat.Format24bppRgb);
            var bp = (byte*)data.Scan0.ToPointer();

            for (int i = 0; i != data.Height; i++)
            {
                for (int j = 0; j != data.Width; j++)
                {
                    result[n] = bp[i * data.Stride + j * 3];
                    n++;
                }
            }
            img.UnlockBits(data);
            
            return result;
        }

        /// <summary>
        /// 获取所有像素点，并返回一个long值
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static long CalculateAllPixel(Bitmap bmp)
        {
            byte[] Arr_1 = new byte[bmp.Width * bmp.Height];
            Arr_1 = ImagePro.GetImageAllPixel(bmp);            
            return Convert.ToInt64(Arr_1.Length) / 10000;
        }

        /// <summary>
        /// 获取黑化的像素量
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static unsafe byte[] GetImageBlackPixel(Bitmap img)
        {
            byte[] result = new byte[img.Width * img.Height];
            int n = 0;
            BitmapData data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly,
                                           PixelFormat.Format24bppRgb);
            var bp = (byte*)data.Scan0.ToPointer();

            for (int i = 0; i != data.Height; i++)
            {
                for (int j = 0; j != data.Width; j++)
                {
                    result[n] = bp[i * data.Stride + j * 3];
                    n++;
                }
            }
            img.UnlockBits(data);
            
            return result;
        }

        /// <summary>
        /// 获取黑点的总数，并返回long值
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static long CalculateBlackPixel(Bitmap bmp)
        {
            byte[] Arr_2 = new byte[bmp.Width * bmp.Height];
            Arr_2 = ImagePro.GetImageBlackPixel(bmp);
            long TotalBlackPixel = 0;
            for (int k = 0; k < Arr_2.Length; k++)
            {
                if (Arr_2[k] == 0)
                {
                    TotalBlackPixel += 1;
                }
            }
            return TotalBlackPixel;
        }
    }
}
