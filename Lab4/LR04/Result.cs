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
    public partial class Result : Form
    {
        Image img; decimal bawint;
        public Result(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            img = image;
            BlackAndWhite2((Bitmap)image.Clone());
            Bitmap result2 = MonoGreyBit((Bitmap)image.Clone());
            ConvertSob(result2);
        }

        private Bitmap MonoGreyBit(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            Color color;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    color = bitmap.GetPixel(x, y);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;
                    int a = color.A;
                    int avg = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                    bitmap.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }            
            return bitmap;
        }
    
       
        private void BlackAndWhite2(Bitmap bmpImg)
        {
            try
            {
                int width = bmpImg.Width;
                int height = bmpImg.Height;
                Color color;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        color = bmpImg.GetPixel(x, y);
                        int r = color.R;
                        int g = color.G;
                        int b = color.B;
                        int avg = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        bmpImg.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox2.Image = bmpImg;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main(pictureBox1.Image);
            main.Show();
            SetVisibleCore(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BlackAndWhite(Bitmap bmpImg, decimal P )
        {
            Bitmap result = new Bitmap(bmpImg.Width, bmpImg.Height);
            Color color = new Color();
            try
            {
                for (int j = 0; j < bmpImg.Height; j++)
                {
                    for (int i = 0; i < bmpImg.Width; i++)
                    {
                        color = bmpImg.GetPixel(i, j);
                        int K = (color.R + color.G + color.B) / 3;
                        result.SetPixel(i, j, K <= P ? Color.Black : Color.White);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox4.Image = result;
        }
        private void buttonPreparation_Click(object sender, EventArgs e)
        {
            BlackAndWhite((Bitmap)img.Clone(), bawint);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bawint = numericUpDown1.Value;
        }

        private void ConvertSob(Bitmap bmp)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    //Первая часть функции посвящена получению данных изображения и сохранению их в массиве.
                    double[,] xkernel = new double[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
                    Bitmap result = new Bitmap(bmp.Width, bmp.Height);
                    double factor = 1; int bias = 0; bool grayscale = false;
                    int width = bmp.Width;
                    int height = bmp.Height;

                    //Блокировка битов исходного изображения в системной памяти
                    BitmapData srcData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                    //Получение общего количества байт в изображении - 32 байта на пиксель x ширина изображения
                    //x высота изображения -> для изображений размером 32 бит/с
                    int bytes = srcData.Stride * srcData.Height;

                    //Создание массивов байтов для хранения пиксельной информации изображения
                    byte[] pixelBuffer = new byte[bytes];
                    byte[] resultBuffer = new byte[bytes];

                    //Получения адреса первых пиксельных данных
                    IntPtr srcScan0 = srcData.Scan0;

                    //Копирование данных изображения в один из байтовых массивов
                    System.Runtime.InteropServices.Marshal.Copy(srcScan0, pixelBuffer, 0, bytes);

                    //Разблокирование битов из системной памяти -> у нас есть вся необходимая вам информация в массиве
                    bmp.UnlockBits(srcData);


                    //Код для установки переменных, используемых в процессе свертки

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

                    //Это то, насколько ваш центральный пиксель смещен от границы вашего ядра
                    //Размер  равен 3x3, поэтому центр находится на расстоянии 1 пикселя от границы ядра
                    int filterOffset = 1;
                    int calcOffset = 0;
                    int byteOffset = 0;

                    //Начнем с пикселя, смещенного на 1 сверху и на 1 с левой стороны
                    //это значит, что все ядро находится на изображении
                    for (int OffsetY = filterOffset; OffsetY < height - filterOffset; OffsetY++)
                    {
                        for (int OffsetX = filterOffset; OffsetX < width - filterOffset; OffsetX++)
                        {
                            //reset rgb значения в 0
                            xr = xg = xb = yr = yg = yb = 0;
                            rt = gt = bt = 0.0;

                            //положение центрального пикселя ядра
                            byteOffset = OffsetY * srcData.Stride + OffsetX * 4;

                            //Применение свертки ядра к текущему пикселю
                            //вычисления ядра
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

                            //устанавливаю новые данные в массиве других байтов для данных изображения
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

                    //Разблокируйте биты из системной памяти
                    result.UnlockBits(resultData);

                    pictureBox5.Image = result;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
