using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class F_Image : Form
    {
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
    }
}
