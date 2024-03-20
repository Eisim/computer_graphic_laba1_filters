using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R,
                                               255 - sourceColor.G,
                                               255 - sourceColor.B);
            return resultColor;
        }

    }
    class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color cur_color = sourceImage.GetPixel(x, y);
            int intensivity = (int)(0.36 * cur_color.R + 0.53 * cur_color.G + 0.11 * cur_color.B);
            Color color = Color.FromArgb(intensivity, intensivity, intensivity);
            return color;
        }
    }
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double k = 20;
            Color cur_color = sourceImage.GetPixel(x, y);
            int intensivity = (int)(0.36 * cur_color.R + 0.53 * cur_color.G + 0.11 * cur_color.B);
            Color color = Color.FromArgb(Clamp((int)(intensivity + 2 * k), 0, 255),
                                         Clamp((int)(intensivity + 0.5 * k), 0, 255),
                                         Clamp((int)(intensivity - 1 * k), 0, 255));
            return color;
        }
    }
    class BrightnessFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k = 10;
            Color cur_color = sourceImage.GetPixel(x, y);
            Color color = Color.FromArgb(Clamp(cur_color.R + k, 0, 255),
                                         Clamp(cur_color.G + k, 0, 255),
                                         Clamp(cur_color.B + k, 0, 255));
            return color;
        }
    }
    class CorrectionWithAReferenceColor : Filters
    {
        Color source_color, result_color;

        public CorrectionWithAReferenceColor(Color source_color, Color result_color)
        {
            this.source_color = source_color;
            this.result_color = result_color;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color cur_color = sourceImage.GetPixel(x, y);
            Color resule_color = Color.FromArgb(
                Clamp(cur_color.R * (result_color.R + 1) / (source_color.R + 1), 0, 255),
                Clamp(cur_color.G * (result_color.G + 1) / (source_color.G + 1), 0, 255),
                Clamp(cur_color.B * (result_color.B + 1) / (source_color.B + 1), 0, 255)
                );
            return resule_color;
        }
    }
}
