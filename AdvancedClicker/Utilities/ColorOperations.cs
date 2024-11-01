using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedClicker.Utilities
{
    public class ColorOperations
    {
        public static Color InterpolateHSL(Color color1, Color color2, float t)
        {
            // Преобразуем цвета в HSL
            var hsl1 = RgbToHsl(color1);
            var hsl2 = RgbToHsl(color2);

            // Интерполяция оттенка с учётом цветового круга
            float h1 = hsl1.H;
            float h2 = hsl2.H;

            // Если разница по кругу меньше, чем в обратную сторону, используем её
            if (Math.Abs(h1 - h2) > 0.5f)
            {
                if (h1 > h2)
                {
                    h2 += 1f;  // Продвигаем h2 на круг вперед
                }
                else
                {
                    h1 += 1f;  // Продвигаем h1 на круг вперед
                }
            }

            // Интерполяция остальных параметров HSL
            float h = (h1 + t * (h2 - h1)) % 1f;
            float s = hsl1.S + t * (hsl2.S - hsl1.S);
            float l = hsl1.L + t * (hsl2.L - hsl1.L);

            // Преобразуем обратно в RGB и возвращаем цвет
            return HslToRgb(h, s, l);
        }

        // Преобразование RGB в HSL
        public static (float H, float S, float L) RgbToHsl(Color color)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));

            float h = 0, s, l = (max + min) / 2f;

            if (max == min)
            {
                h = s = 0; // Achromatic (grey)
            }
            else
            {
                float d = max - min;
                s = l > 0.5f ? d / (2f - max - min) : d / (max + min);
                if (max == r)
                {
                    h = (g - b) / d + (g < b ? 6f : 0f);
                }
                else if (max == g)
                {
                    h = (b - r) / d + 2f;
                }
                else if (max == b)
                {
                    h = (r - g) / d + 4f;
                }
                h /= 6f;
            }

            return (h, s, l);
        }

        // Преобразование HSL в RGB
        public static Color HslToRgb(float h, float s, float l)
        {
            float r, g, b;

            if (s == 0)
            {
                r = g = b = l; // Achromatic (grey)
            }
            else
            {
                float q = l < 0.5f ? l * (1f + s) : l + s - l * s;
                float p = 2f * l - q;
                r = HueToRgb(p, q, h + 1f / 3f);
                g = HueToRgb(p, q, h);
                b = HueToRgb(p, q, h - 1f / 3f);
            }

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private static float HueToRgb(float p, float q, float t)
        {
            if (t < 0f) t += 1f;
            if (t > 1f) t -= 1f;
            if (t < 1f / 6f) return p + (q - p) * 6f * t;
            if (t < 1f / 2f) return q;
            if (t < 2f / 3f) return p + (q - p) * (2f / 3f - t) * 6f;
            return p;
        }

        private static (double H, double S, double V) RGBToHSV(Color color)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double max = Math.Max(Math.Max(r, g), b);
            double min = Math.Min(Math.Min(r, g), b);
            double delta = max - min;

            double h = 0;
            if (delta != 0)
            {
                if (max == r)
                {
                    h = (g - b) / delta + (g < b ? 6 : 0);
                }
                else if (max == g)
                {
                    h = (b - r) / delta + 2;
                }
                else
                {
                    h = (r - g) / delta + 4;
                }
                h /= 6;
            }

            double s = max == 0 ? 0 : delta / max;
            double v = max;

            return (h * 360, s, v);
        }

        public static bool IsColorInGradientRange(Color pixelColor, Color color1, Color color2, int offset)
        {
            // Convert colors to HSV for easier gradient detection
            var pixelHsv = RGBToHSV(pixelColor);
            var color1Hsv = RGBToHSV(color1);
            var color2Hsv = RGBToHSV(color2);

            double offsetFactor = offset / 100.0;

            // Calculate min and max H for the gradient range
            double hueMin = Math.Min(color1Hsv.H, color2Hsv.H);
            double hueMax = Math.Max(color1Hsv.H, color2Hsv.H);

            // Handle the wrap-around for H values (cyclical from 0 to 360 degrees)
            bool isHueInRange = hueMax - hueMin <= 180
                ? isHueInRange = pixelHsv.H >= hueMin * offsetFactor && pixelHsv.H <= hueMax * (2 - offsetFactor)
                : isHueInRange = pixelHsv.H <= hueMax * (2 - offsetFactor) || pixelHsv.H >= hueMin * offsetFactor;

            // Check if the pixel color is within the HSV range defined by the two colors
            return isHueInRange &&
                   pixelHsv.S >= Math.Min(color1Hsv.S, color2Hsv.S) * (offsetFactor) && pixelHsv.S <= Math.Max(color1Hsv.S, color2Hsv.S) * (2 - offsetFactor) &&
                   pixelHsv.V >= Math.Min(color1Hsv.V, color2Hsv.V) * (offsetFactor) && pixelHsv.V <= Math.Max(color1Hsv.V, color2Hsv.V) * (2 - offsetFactor);
        }

        public static bool IsColorInRange(Color pixelColor, List<Color> colors, int offset)
        {
            // Конвертация пикселя в HSV
            var pixelHsv = RGBToHSV(pixelColor);
            double offsetFactor = offset / 100.0;
            // Вычисляем диапазоны для H, S и V с учётом offsetFactor
            double hueOffset = 360 * (1 - offsetFactor); // Hue работает в диапазоне 0-360
            double saturationOffset = 1 - offsetFactor; // Насыщенность в диапазоне 0-1
            double valueOffset = 1 - offsetFactor; // Яркость также в диапазоне 0-1

            foreach (Color color in colors)
            {
                var targetHsv = RGBToHSV(color);

                bool hueInRange = Math.Abs(pixelHsv.H - targetHsv.H) <= hueOffset ||
                                  Math.Abs(360 - Math.Abs(pixelHsv.H - targetHsv.H)) <= hueOffset; // Учитываем цикличность Hue

                bool saturationInRange = Math.Abs(pixelHsv.S - targetHsv.S) <= saturationOffset;
                bool valueInRange = Math.Abs(pixelHsv.V - targetHsv.V) <= valueOffset;

                if (hueInRange && saturationInRange && valueInRange)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
