using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{


    class DilationFilter: Filters
    {
        private bool[,] kernel = null;
        public DilationFilter(bool[,] kernel)
        {
            this.kernel = kernel;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int y = kernel.GetLength(1) / 2; y < sourceImage.Height - kernel.GetLength(1) / 2; y++)
            {
                worker.ReportProgress((int)((float)y / resultImage.Height * 100));

                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int x = kernel.GetLength(0) / 2; x < sourceImage.Width - kernel.GetLength(0) / 2; x++)
                {
                    int maxR = 0;
                    int maxG = 0;
                    int maxB = 0;
                    Color cur_color;
                    for (int j = -kernel.GetLength(1) / 2; j <= kernel.GetLength(1) / 2; j++)
                    {
                        for (int i = -kernel.GetLength(0) / 2; i <= kernel.GetLength(0) / 2; i++)
                        {
                            if (kernel[i + kernel.GetLength(0) / 2, j + kernel.GetLength(1) / 2])
                            {
                                cur_color = sourceImage.GetPixel(x + i, y + j);
                                maxR = Math.Max(maxR, cur_color.R);
                                maxG = Math.Max(maxG, cur_color.G);
                                maxB = Math.Max(maxB, cur_color.B);
                            }
                        }
                    }

                    maxR = Clamp(maxR, 0, 255);
                    maxG = Clamp(maxG, 0, 255);
                    maxB = Clamp(maxB, 0, 255);

                    resultImage.SetPixel(x, y, Color.FromArgb(maxR, maxG, maxB));
                }
            }

            return resultImage;
        }
    }


    class ErosionFilter : Filters
    {
        private bool[,] kernel = null;
        public ErosionFilter(bool[,] kernel)
        {
            this.kernel = kernel;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int y = kernel.GetLength(1) / 2; y < sourceImage.Height - kernel.GetLength(1) / 2; y++)
            {
                worker.ReportProgress((int)((float)y / resultImage.Height * 100));

                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int x = kernel.GetLength(0) / 2; x < sourceImage.Width - kernel.GetLength(0) / 2; x++)
                {
                    int minR = 255;
                    int minG = 255;
                    int minB = 255;
                    Color cur_color;
                    for (int j = -kernel.GetLength(1) / 2; j <= kernel.GetLength(1) / 2; j++)
                    {
                        for (int i = -kernel.GetLength(0) / 2; i <= kernel.GetLength(0) / 2; i++)
                        {
                            if (kernel[i + kernel.GetLength(0) / 2, j + kernel.GetLength(1) / 2])
                            {
                                cur_color = sourceImage.GetPixel(x + i, y + j);
                                minR = Math.Min(minR, cur_color.R);
                                minG = Math.Min(minR, cur_color.G);
                                minB = Math.Min(minR, cur_color.B);
                            }
                        }
                    }

                    minR = Clamp(minR, 0, 255);
                    minG = Clamp(minG, 0, 255);
                    minB = Clamp(minB, 0, 255);

                    resultImage.SetPixel(x, y, Color.FromArgb(minR, minG, minB));
                }
            }

            return resultImage;
        }
    }

    class ClosingFilter : Filters
    {
        private bool[,] kernel = null;
        public ClosingFilter(bool[,] kernel)
        {
            this.kernel = kernel;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new ErosionFilter(kernel).processImage((new DilationFilter(kernel).processImage(sourceImage, worker)),worker);
            
            return resultImage;
        }
    }
    class OpeningFilter : Filters
    {
        private bool[,] kernel = null;
        public OpeningFilter(bool[,] kernel)
        {
            this.kernel = kernel;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new DilationFilter(kernel).processImage((new ErosionFilter(kernel).processImage(sourceImage, worker)), worker);

            return resultImage;
        }
    }
    class GradFilter : Filters
    {
        private bool[,] kernel = null;
        public GradFilter(bool[,] kernel)
        {
            this.kernel = kernel;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            ErosionFilter e_f = new ErosionFilter(kernel);
            DilationFilter d_f = new DilationFilter(kernel);
            Bitmap tmp_1,tmp_2,resultImage;
            tmp_1 = d_f.processImage(sourceImage, worker); //I(+)B = C
            tmp_2 = e_f.processImage(sourceImage, worker); //I(-)B = D
            resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Color c_1, c_2;
            //C-D
            for (int j = 0; j < sourceImage.Height; j++)
            {
                worker.ReportProgress((int)(j / (float)sourceImage.Height * 100));
                if (worker.CancellationPending) return null;
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    c_1 = tmp_1.GetPixel(i, j);
                    c_2 = tmp_2.GetPixel(i, j);
                    resultImage.SetPixel(i, j, Color.FromArgb(
                        Clamp(c_1.R - c_2.R, 0, 255),
                        Clamp(c_1.G - c_2.G, 0, 255),
                        Clamp(c_1.B - c_2.B, 0, 255)
                        ));
                }
            }
            return resultImage;
        }
    }
}

