using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace laba_1
{


    //матричные
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for ( int l= -radiusY; l<=radiusY; l++)
                for (int k=-radiusX; k<=radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR+=neighborColor.R* kernel[k + radiusX, l + radiusY];
                    resultG+=neighborColor.G* kernel[k + radiusX, l + radiusY];
                    resultB+=neighborColor.B* kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }
    }
    class BlurFilter: MatrixFilter
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
        }
    }

    class WaveFilterHorizontal : Filters
    {
        Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            x = Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 60)), 0, sourceImage.Width - 1);
            return sourceImage.GetPixel(x, y);
        }
    }
    class WaveFilterVertical : Filters
    {
        Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            y = Clamp((int)(y + 20*Math.Sin(2*Math.PI*x/60)), 0, sourceImage.Height - 1);
            return sourceImage.GetPixel(x, y);
        }
    }

    class GlassFilter : Filters
    {
        Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            x = Clamp((int)(x + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Width-1);
            y = Clamp((int)(y + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Height-1);
            return sourceImage.GetPixel(x, y);
        }
    }


    class GaussianFilter: MatrixFilter
    {
        public void createGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;
            for ( int i= -radius; i<=radius; i++)
            {
                for (int j = -radius; j <= radius; j++){
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++) kernel[i, j] /= norm;
        }
        public GaussianFilter()
        {
            createGaussianKernel(3, 2);
        }
    }
    class SobelFilterOY : MatrixFilter
    {
       public SobelFilterOY()
        {

            kernel = new float[,] { 
                { -1, -2, -1 },
                {  0,  0,  0 },
                {  1,  2,  1 } };
        }
    }
    class SobelFilterOX : MatrixFilter
    {
        public SobelFilterOX()
        {
            kernel = new float[,] {
                { -1,  0,  1 },
                { -2,  0,  2 },
                { -1,  0,  1 } };
        }
    }
    class SobelFilter : MatrixFilter
    {
        public SobelFilter()
        {
            kernel = new float[,] {
                { -2, -2,  0 },
                { -2,  0,  2 },
                {  0,  2,  2 } };
        }
    }
    class SharpeningFilter: MatrixFilter
    {
        public SharpeningFilter()
        {
            kernel = new float[,] { 
                {0,-1,0 },
                {-1,5,-1 },
                {0,-1,0 }
            };
        }
    }

    class SharraFilterOX : MatrixFilter
    {
        public SharraFilterOX()
        {

            kernel = new float[,] {
                { 3,  0,  -3},
                {10,  0, -10},
                { 3,  0,  -3} };
        }
    }

    class SharraFilterOY : MatrixFilter
    {
        public SharraFilterOY()
        {

            kernel = new float[,] {
                { 3,  10,  3},
                { 0,   0,  0},
                {-3, -10, -3} };
        }
    }
    class SharraFilter : MatrixFilter
    {
        public SharraFilter()
        {

            kernel = new float[,] {
                { 6,  10,  0},
                {10,  0, -10},
                { 0,  -10,  -6} };
        }
    }

    class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter(int n = 10)
        {
            kernel = new float[n, n];
            for (int i = 0; i < n; i++) { kernel[i, i] = 1f/(float)n; }
        }
    }
    //работа с гистограммой
    class LinearStretching: Filters
    {
        int min_color, max_color;
        public LinearStretching() { min_color = 255;max_color = 0; }
        private int findMinColor(Bitmap sourceImage)
        {
            int min_intens = 255,intens;
            Color cur_color;
            for (int i = 0;i < sourceImage.Width;i++)
            {
                for(int j = 0;j < sourceImage.Height;j++)
                {
                    cur_color = sourceImage.GetPixel(i, j);
                    intens = (int)(0.36 * cur_color.R + 0.53 * cur_color.G + 0.11 * cur_color.B);
                    min_intens = (min_intens < intens) ? min_intens : intens;
                }
            }
            return min_intens;
        }
        private int findMaxColor(Bitmap sourceImage)
        {
            int max_intens = 0, intens;
            Color cur_color;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    cur_color = sourceImage.GetPixel(i, j);
                    intens = (int)(0.36 * cur_color.R + 0.53 * cur_color.G + 0.11 * cur_color.B);
                    max_intens = (max_intens > intens) ? max_intens : intens;
                }
            }
            return max_intens;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            min_color = findMinColor(sourceImage);
            max_color = findMaxColor(sourceImage);
            Bitmap resImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < resImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < resImage.Height; j++)
                {
                    resImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resImage;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color cur_color = sourceImage.GetPixel(x, y);
            return Color.FromArgb(
                Clamp((cur_color.R - min_color)*(255-0)/(max_color-min_color),0,255),
                Clamp((cur_color.G - min_color)*(255-0)/(max_color-min_color),0,255),
                Clamp((cur_color.B - min_color)*(255-0)/(max_color-min_color),0,255)
                );
        }
    }

    class additionalFiltes : Filters
    {
        /*
* <100 - чёрный
*  от 100 до 150 - синий
*  от 150 до 200 - голубой
*  >200 - белый
*/
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color cur_color = sourceImage.GetPixel(x, y);
            Color res_color = Color.FromArgb(0,0,0);
            double intensivity= 0.36*cur_color.R + 0.53*cur_color.G + 0.11*cur_color.B;
            if (intensivity < 100)
            {
                res_color = Color.FromArgb(0, 0, 0);
            }
            if (intensivity > 100 & intensivity < 150)
            {
                res_color = Color.FromArgb(0, 0, 255);
            }
            if (intensivity > 150 & intensivity < 200)
            {
                res_color = Color.FromArgb(0, 189, 255);
            }
            if (intensivity > 200)
            {
                res_color = Color.FromArgb(255, 255, 255);
            }
            return res_color;
        }
    }
}
