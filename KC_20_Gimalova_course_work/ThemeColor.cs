using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC_20_Gimalova_course_work
{
    internal class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string>()
        {
            "#a6c6f2",
            "#eca6f2",
            "#a6d2f2",
            "#f2a6d2",
            "#d2f2a6"
        };

        //метод для изменения яркости
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //если ... меньше 0, сделать цвет темнее
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //если ... больше 0, сделать цвет светлее
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
