using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR04
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }
        public Filter(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            ConvertIm((Bitmap)image.Clone());
        }
        

        private void ConvertIm(Bitmap bmp)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    //новый bitmap с виртуальной рамкой
                    Bitmap paddedBmp = ImageWithBorder(bmp, 1);
                    //Настройка свертки и переменных. Оператор Собеля.
                    double[,] xkernel = new double[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
                    Bitmap result = new Bitmap(bmp.Width, bmp.Height);
                    int width = bmp.Width;
                    int height = bmp.Height;

                    //Блокировка данных изображения в памяти для прямого доступа к пикселам
                    BitmapData srcData = paddedBmp.LockBits(new Rectangle(0, 0, paddedBmp.Width, paddedBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                    //Подсчет количества байт и создание массивов для пиксельных данных
                    int bytes = srcData.Stride * srcData.Height;

                    //Создание массивов байтов для хранения пиксельной информации изображения
                    byte[] pixelBuffer = new byte[bytes];
                    byte[] resultBuffer = new byte[bytes];

                    IntPtr srcScan0 = srcData.Scan0;

                    //Копирование данных изображения в один из байтовых массивов
                    Marshal.Copy(srcScan0, pixelBuffer, 0, bytes);

                    //Разблокирование битов из системной памяти -> у нас есть вся необходимая вам информация в массиве
                    bmp.UnlockBits(srcData);




                    //Создание переменных для пиксельных данных для каждого ядра
                    double xr = 0.0;
                    double xg = 0.0;
                    double xb = 0.0;
                    double yr = 0.0;
                    double yg = 0.0;
                    double yb = 0.0;
                    double rt = 0.0;
                    double gt = 0.0;
                    double bt = 0.0;

                    //Размер  равен 3x3, поэтому центр находится на расстоянии 1 пикселя от границы ядра
                    int filterOffset = 0;
                    int calcOffset = 0;
                    int byteOffset = 0;

                    //Проход по каждому пикселу, чтобы ядро 3на3 полностью помещалось на изображении
                    for (int OffsetY = filterOffset; OffsetY < height - filterOffset; OffsetY++)  
                    {
                        for (int OffsetX = filterOffset; OffsetX < width - filterOffset; OffsetX++)
                        {
                            xr = xg = xb = yr = yg = yb = 0;
                            rt = gt = bt = 0.0;

                            //положение центрального пикселя ядра
                            byteOffset = OffsetY * srcData.Stride + OffsetX * 4;

                            //Применение свертки ядра к текущему пикселю
                            for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                            {
                                for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                                {
                                    calcOffset = byteOffset + filterX * 4 + filterY * srcData.Stride;
                                    xb += (double)(pixelBuffer[calcOffset]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                                    xg += (double)(pixelBuffer[calcOffset + 1]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                                    xr += (double)(pixelBuffer[calcOffset + 2]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                                }
                            }

                            //общие значения rgb для этого пикселя
                            bt = Math.Sqrt((xb * xb) + (yb * yb));
                            gt = Math.Sqrt((xg * xg) + (yg * yg));
                            rt = Math.Sqrt((xr * xr) + (yr * yr));

                            //установленные ограничения, байты могут содержать значения от 0 до 255;
                            bt = RangeControl(bt);
                            gt = RangeControl(gt);
                            rt = RangeControl(rt);                        

                            //новые данные в массиве других байтов для данных изображения
                            resultBuffer[byteOffset] = (byte)(bt);
                            resultBuffer[byteOffset + 1] = (byte)(gt);
                            resultBuffer[byteOffset + 2] = (byte)(rt);
                            resultBuffer[byteOffset + 3] = 255;

                        }
                    }
                    //Блокировка битов в системной памяти
                    BitmapData resultData = result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    //Копировать из массива байтов, содержащего обработанные данные, в растровое изображение
                    Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

                    //Разблокировка битов из системной памяти
                    result.UnlockBits(resultData);
                    
                    pictureBox2.Image = result;
                }
                else
                    MessageBox.Show("Отсутствует исходное изображение");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public double RangeControl(double component)
        {
            if (component > 255)
                component = 255;
            else if (component < 0)
                component = 0;
            return component;
        }

        // Функция для создания расширенного изображения с отражением краев
        private Bitmap ImageWithBorder(Bitmap bmp, int padding)
        {
            int width = bmp.Width + 2 * padding;
            int height = bmp.Height + 2 * padding;
            Bitmap paddedBmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(paddedBmp))
            {
                g.DrawImage(bmp, padding, padding, bmp.Width, bmp.Height);

                // Отражение краев
                g.DrawImage(bmp, new Rectangle(0, padding, padding, bmp.Height), new Rectangle(1, 0, 1, bmp.Height), GraphicsUnit.Pixel); // Левая сторона
                g.DrawImage(bmp, new Rectangle(width - padding, padding, padding, bmp.Height), new Rectangle(bmp.Width - 2, 0, 1, bmp.Height), GraphicsUnit.Pixel); // Правая сторона
                g.DrawImage(bmp, new Rectangle(padding, 0, bmp.Width, padding), new Rectangle(0, 1, bmp.Width, 1), GraphicsUnit.Pixel); // Верхняя сторона
                g.DrawImage(bmp, new Rectangle(padding, height - padding, bmp.Width, padding), new Rectangle(0, bmp.Height - 2, bmp.Width, 1), GraphicsUnit.Pixel); // Нижняя сторона

                // Углы
                g.DrawImage(bmp, 0, 0, new Rectangle(1, 1, 1, 1), GraphicsUnit.Pixel); // Верхний левый угол
                g.DrawImage(bmp, width - padding, 0, new Rectangle(bmp.Width - 2, 1, 1, 1), GraphicsUnit.Pixel); // Верхний правый угол
                g.DrawImage(bmp, 0, height - padding, new Rectangle(1, bmp.Height - 2, 1, 1), GraphicsUnit.Pixel); // Нижний левый угол
                g.DrawImage(bmp, width - padding, height - padding, new Rectangle(bmp.Width - 2, bmp.Height - 2, 1, 1), GraphicsUnit.Pixel); // Нижний правый угол
            }

            return paddedBmp;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main(pictureBox1.Image);
            main.Show();
            SetVisibleCore(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Load(object sender, EventArgs e)
        {

        }

    }
}
