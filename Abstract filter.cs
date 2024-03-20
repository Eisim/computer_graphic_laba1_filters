using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    abstract class Filters
    {
        protected virtual Color calculateNewPixelColor(Bitmap sourceImage, int x, int y) { return sourceImage.GetPixel(x, y); }

        public virtual Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
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
        public int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            else if (value > max) return max;
            return value;
        }
    }
}
