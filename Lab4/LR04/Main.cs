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
    public partial class Main : Form
    {
        Bitmap image;
        bool isGrey;
        public Main()
        {
            InitializeComponent();
            isGrey = false;
        }
        public Main(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            isGrey = true;
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = ("Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*"); //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pictureBox1.Image = image;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл");
                }
            }
        }
        private void buttonToGrey_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ToGrey grey = new ToGrey(pictureBox1.Image);
                grey.Show();
                SetVisibleCore(false);
                isGrey = true;
            }
            else
                MessageBox.Show("Отсутствует исходное изображение");
        }
        private void buttonMonochrome_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (isGrey)
                {
                    Monochrome mono = new Monochrome(pictureBox1.Image);
                    mono.Show();
                    SetVisibleCore(false);
                }
                else
                    MessageBox.Show("Отсутствует изображение в оттенках серого, выполните перевод");
            }
            else
                MessageBox.Show("Отсутствует исходное изображение");
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                    Filter filter = new Filter(pictureBox1.Image);
                    filter.Show();
                    SetVisibleCore(false);
            }
            else
                MessageBox.Show("Отсутствует исходное изображение");
        }
        private void buttonResult_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Result result = new Result(pictureBox1.Image);
                result.Show();
                SetVisibleCore(false);
            }
            else
                MessageBox.Show("Отсутствует исходное изображение");
        }
    }
}
