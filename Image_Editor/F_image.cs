﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class F_Image : Form
    {
        Point currentPoint;
        public F_Image()
        {
            InitializeComponent();
        }

        private void F_Image_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.imageFieldOpened = false;
        }

        private void F_Image_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Image_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = MainForm.imageEditor.Image;
        }

        public void savePbImage(string filePath)
        {
            try
            {
                pictureBox1.Image.Save(filePath, getFormat(filePath));
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка");
//                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public System.Drawing.Imaging.ImageFormat getFormat (string filePath)
        {
            string extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case ("*.jpg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ("*.jpeg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ("*.png"):
                    return System.Drawing.Imaging.ImageFormat.Png;
                default:
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawTimer.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawTimer.Stop();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = MainForm.imageEditor.ConvertCoordinates(pictureBox1, e.X, e.Y);
            textBox_X.Text = Convert.ToString(currentPoint.X);
            textBox_Y.Text = Convert.ToString(currentPoint.Y);
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            int brushRadius = MainForm.imageEditor.BrushRadius;
            for (int i = currentPoint.X - brushRadius; i <= currentPoint.X + brushRadius; i++)
            {
                for (int j = currentPoint.Y - brushRadius; j <= currentPoint.Y + brushRadius; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - currentPoint.X, 2) + Math.Pow(j - currentPoint.Y, 2));
                    if (dist <= brushRadius && i >= 0 && j >= 0 && i < MainForm.imageEditor.Image.Width && j < MainForm.imageEditor.Image.Height)
                    MainForm.imageEditor.Image.SetPixel(i, j, MainForm.imageEditor.BrushColor);
                }
            }
            Invalidate();
        }
    }
}
