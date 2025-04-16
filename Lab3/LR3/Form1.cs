using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace LR3
{
    public partial class Form1 : Form
    {
        Color currentColor;
        Color patternColor;
        Class1 graphics;
        byte[][] pattern =
        {
            new byte[] {1, 0, 0, 0}, new byte[] {0, 1, 0, 1}, new byte[] {1, 0, 0, 0}, new byte[] {0, 1, 0, 1}
        };
        public struct Pixel
        {
            public int x;
            public int y;
            public Color color;
            public Pixel(int x, int y, Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }
        }
        List<Pixel> pixels = new List<Pixel>();
        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Black;
            graphics = new Class1(Field.Width, Field.Height);
            Field.Image = graphics.field;
        }

        private void Field_MouseClick(object sender, MouseEventArgs e)
        {
            Pixel pix = new Pixel(e.X, e.Y, currentColor);
            pixels.Add(pix);
            if (LineChecked.Checked && pixels.Count == 2)
            {
                graphics.Line(pixels[0].x, pixels[0].y, pixels[1].x, pixels[1].y, currentColor);
                Field.Image = graphics.field;
                pixels.Clear();
            }
            if (CircleChecked.Checked)
            {
                graphics.Circle(pixels[0].x, pixels[0].y, (int)numericUpDown.Value, currentColor);
                Field.Image = graphics.field;
                pixels.Clear();
            }
            if (CurvesChecked.Checked && pixels.Count == (int)numericUpDown1.Value)
            {
                graphics.BezieLine(pixels, 0.001, currentColor);
                Field.Image = graphics.field;
                pixels.Clear();
            }
            if (FillChecked.Checked)
            {
                graphics.FillColor(pixels[0].x, pixels[0].y, currentColor);
                Field.Image = graphics.field;
                pixels.Clear();
            }
            if (radioButton1.Checked)
            {
                graphics.FillColor1(pixels[0].x, pixels[0].y, currentColor);
                Field.Image = graphics.field;
                pixels.Clear();
            }
            if (PatternChecked.Checked)
            {
                graphics.FillPatternColor(pixels[0].x, pixels[0].y, currentColor, patternColor, pattern);
                Field.Image = graphics.field;
                pixels.Clear();
            }
        }


        private void LineChecked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorsDialog = new ColorDialog();
            if (colorsDialog.ShowDialog() == DialogResult.OK)
                currentColor = colorsDialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.field = new Bitmap(Field.Width, Field.Height);
            Field.Image = graphics.field;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
