using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR04
{
    public partial class ToGrey : Form
    {
        public ToGrey(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            ConvertToGrey((Bitmap)image.Clone());
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main(pictureBox2.Image);
            main.Show();
            SetVisibleCore(false);
        }
        private void ConvertToGrey(Bitmap bmp)
        {
            try
            {
                int width = bmp.Width;
                int height = bmp.Height;
                Color color;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        color = bmp.GetPixel(x, y);
                        int r = color.R;
                        int g = color.G;
                        int b = color.B;
                        int avg = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToGrey_Load(object sender, EventArgs e)
        {

        }
    }
}
