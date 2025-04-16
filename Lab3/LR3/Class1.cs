using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LR3.Form1;

namespace LR3
{
    class Class1
    {
        public Bitmap field { get; set; }
        public Class1(int width, int height)
        {
            field = new Bitmap(width, height);
        }
        public void Line(int x0, int y0, int x1, int y1, Color color)
        {
            // Алгоритм Брезенхама рисования прямой
            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            if (dx > dy)
            {
                // Линия больше наклонена по оси X
                float e = (float)dy / dx - 0.5f;

                int x = x0, y = y0;

                for (int i = 0; i <= dx; i++)
                {
                    DrawPoint(x, y, color);

                    // Если ошибка превысила порог 0, увеличиваем y
                    if (e >= 0)
                    {
                        y += sy;
                        e -= 1.0f;
                    }

                    // Увеличиваем x и обновляем ошибку
                    x += sx;
                    e += (float)dy / dx;
                }
            }
            else
            {
                // Линия больше наклонена по оси Y
                float e = (float)dx / dy - 0.5f;

                int x = x0, y = y0;

                for (int i = 0; i <= dy; i++)
                {
                    DrawPoint(x,y, color);

                    // Если ошибка превысила порог 0, увеличиваем x
                    if (e >= 0)
                    {
                        x += sx;
                        e -= 1.0f;
                    }

                    // Увеличиваем y и обновляем ошибку
                    y += sy;
                    e += (float)dx / dy;
                }
            }
        }
        public void Circle(int x0, int y0, int radius, Color color)
        {
            // Алгоритм Брезенхама рисования окружности
            int x = 0;
            int y = radius;
            int d = 3-2*radius;
            while (y >= x)
            {
                DrawPoint(x + x0, y + y0, color);
                DrawPoint(y + x0, x + y0, color);
                DrawPoint(-x + x0, y + y0, color);
                DrawPoint(-y + x0, x + y0, color);
                DrawPoint(-x + x0, -y + y0, color);
                DrawPoint(-y + x0, -x + y0, color);
                DrawPoint(x + x0, -y + y0, color);
                DrawPoint(y + x0, -x + y0, color);
                x++;
                if (d <= 0)
                    d += 4 * x + 6;
                else
                {
                    y--;
                    d += 4 * (x - y) + 10;
                }
            }
        }
        public void BezieLine(List<Pixel> pixels, double step, Color color)
        {
            pixels = GetBeziePoints(pixels, step);
            for (int i = 0; i < pixels.Count - 1; i++)
                Line(pixels[i].x, pixels[i].y, pixels[i + 1].x, pixels[i + 1].y, color);
        }

        private List<Pixel> GetBeziePoints1(List<Pixel> pixels, double step)
        {
            throw new NotImplementedException();
        }

        private List<Pixel> GetBeziePoints(List<Pixel> pixels, double step)
        {
            List<Pixel> resultPoints = new List<Pixel>();
            int n = pixels.Count - 1;
            Color color = Color.AliceBlue;
            for (double t = 0; t < 1; t += step)
            {
                double x = 0;
                double y = 0;
                foreach (var pixel in pixels)
                {
                    color = pixel.color;
                    var factor = Coefficient(pixels.IndexOf(pixel), n, t);
                    x += factor * pixel.x;
                    y += factor * pixel.y;
                }
                resultPoints.Add(new Pixel((int)x, (int)y, color));
            }
            return resultPoints;
        }
        private double Coefficient(int i, int n, double t)
        {
            return Factorial(n) / (Factorial(i) * Factorial(n - i)) * Math.Pow(t, i) * Math.Pow(1 - t, n - i);
        }
        private double Factorial(int n)
        {
            double res = 1;
            for (var i = 1; i <= n; i++)
                res *= i;
            return res;
        }

        public void FillColor(int x, int y, Color fill_color)
        {
            Color backcolor = field.GetPixel(x, y);
            var xLeft = x;
            var xRight = x + 1;
            //Двигаемся влево и закрашиваем пикселы в цвет до тех пор, пока не встретим границу 
            while ((xRight < field.Width - 1) && (field.GetPixel(xRight, y) == backcolor))
            {
                field.SetPixel(xRight, y, fill_color);
                xRight++;
            }
            xRight--;
            //Двигаемся вправо и закрашиваем пикселы в цвет до тех пор, пока не встретим границу
            while ((xLeft > 0) && (field.GetPixel(xLeft, y) == backcolor))
            {
                field.SetPixel(xLeft, y, fill_color);
                xLeft--;
            }
            xLeft++;
            var xLeft1 = xLeft;
            while ((xLeft1 < xRight) && (y != 0))
            {
                while ((xLeft1 < xRight) && (field.GetPixel(xLeft1, y - 1) != backcolor))
                    xLeft1++;
                if (xLeft1 < xRight) FillColor(xLeft1, y - 1, fill_color);
                xLeft1++;
            }
            xLeft1 = xLeft;
            while ((xLeft1 < xRight) && (y != field.Height - 1))
            {
                while ((xLeft1 < xRight) && (field.GetPixel(xLeft1, y + 1) != backcolor))
                    xLeft1++;
                if (xLeft1 < xRight) FillColor(xLeft1, y + 1, fill_color);
                xLeft1++;
            }
        }
        public void FillPatternColor(int x, int y, Color fill_color, Color pattern_color, byte[][] pattern)
        {
            Color backcolor = field.GetPixel(x, y);
            if (pattern == null) FillColor(x, y, fill_color);
            else
            {
                var xLeft = x;
                var xRight = x + 1;
                while ((xRight < field.Width - 1) && (field.GetPixel(xRight, y) == backcolor))
                {
                    field.SetPixel(xRight, y, SetColor(xRight, y, fill_color, pattern_color, pattern));
                    xRight++;
                }
                xRight--;
                while ((xLeft > 0) && (field.GetPixel(xLeft, y) == backcolor))
                {
                    field.SetPixel(xLeft, y, SetColor(xLeft, y, fill_color, pattern_color, pattern));
                    xLeft--;
                }
                xLeft++;
                var xLeft1 = xLeft;
                while ((xLeft1 < xRight) && (y != 0))
                {
                    while ((xLeft1 < xRight) && (field.GetPixel(xLeft1, y - 1) != backcolor))
                        xLeft1++;
                    if (xLeft1 < xRight) FillPatternColor(xLeft1, y - 1, fill_color, pattern_color, pattern);
                    xLeft1++;
                }
                xLeft1 = xLeft;
                while ((xLeft1 < xRight) && (y != field.Height - 1))
                {
                    while ((xLeft1 < xRight) && (field.GetPixel(xLeft1, y + 1) != backcolor))
                        xLeft1++;
                    if (xLeft1 < xRight) FillPatternColor(xLeft1, y + 1, fill_color, pattern_color, pattern);
                    xLeft1++;
                }
            }
        }
        public void FillColor1(int x, int y, Color color)
        {

                Color bgcolor = field.GetPixel(x, y);
                field.SetPixel(x, y, color);
                //закраска вверх
                if ((y + 1 < field.Height) && (field.GetPixel(x, y + 1) == bgcolor))
                {
                    FillColor1(x, y + 1, color);
                }
                //закраска вправо
                if ((x + 1 <= field.Height) && (field.GetPixel(x + 1, y) == bgcolor))
                {
                    FillColor1(x + 1, y, color);
                }
                //закраска вниз при условии того, что пиксел ниже не раскрашен
                if ((y - 1 >= 0) && (field.GetPixel(x, y - 1) == bgcolor))
                {
                    FillColor1(x, y - 1, color);
                }
                //закраска влево при условии того, что пиксел левее не раскрашен
                if ((x - 1 >= 0) && (field.GetPixel(x - 1, y) == bgcolor))
                {
                    FillColor1(x - 1, y, color);
                }
        }
        private Color SetColor(int x, int y, Color fill_color, Color pattern_color, byte[][] pattern)
        {
            Color[] colors = { fill_color, pattern_color };
            byte m = pattern[x % pattern[0].Length][y % pattern.Length];
            return colors[m];
        }
        void DrawPoint(int x, int y, Color color)
        {
            if (x > 0 & x < field.Width & y > 0 & y < field.Height)
                field.SetPixel(x, y, color);
        }
    }
}
