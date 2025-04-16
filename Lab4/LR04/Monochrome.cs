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
    public partial class Monochrome : Form
    {
        Image img; decimal bawint;
        public Monochrome(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            img = image;
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
                        int grey = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                        int K = (int)(grey * 255) / (int)P;
                        result.SetPixel(i, j, K <= P ? Color.Black : Color.White);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox2.Image = result;
        }
       
        private void buttonPreparation_Click(object sender, EventArgs e)
        {
            BlackAndWhite((Bitmap)img.Clone(), bawint);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main(pictureBox1.Image);
            main.Show();
            SetVisibleCore(false);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bawint = numericUpDown1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
