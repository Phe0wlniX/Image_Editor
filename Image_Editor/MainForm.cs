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

    public struct CrNewDialogLongRes
    {
        public int width;
        public int heidth;
        public bool ready;
    }


    public partial class MainForm : Form
    {
        F_Image imageField = null;
        public static bool imageFieldOpened = false;

        public static ImageEditor imageEditor = new ImageEditor();
        public static CrNewDialogLongRes diagRes = new CrNewDialogLongRes();
        public MainForm()
        {
            InitializeComponent();

            p_color.BackColor = Color.White;
            CreateField();
            openFile.Filter = "All files (*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg";
            saveFile.Filter = "All files (*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg";
        }
        public void CreateField()
        {
            imageField = new F_Image();
            imageField.MdiParent = this;
            imageField.Show();
            imageFieldOpened = true;
        }

        private void Create_new_Click(object sender, EventArgs e)
        {
            F_CreateNewBitmap createNewBitmap = new F_CreateNewBitmap();
            createNewBitmap.ShowDialog();
            if(diagRes.ready)
            {
                imageEditor = new ImageEditor(diagRes.width, diagRes.heidth);
                imageField.Refresh();
                p_color.BackColor = Color.White;
                nud_BrushRadius.Value = 30;
            }
        }

        private void bt_open_window_Click(object sender, EventArgs e)
        {
            if (!imageFieldOpened)
            {
                CreateField();
            }
        }

        private void bt_close_window_Click(object sender, EventArgs e)
        {
            if (imageFieldOpened)
            {
                imageField.Close();
                imageFieldOpened = false;
            }
        }

        private void p_color_Paint(object sender, PaintEventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                p_color.BackColor = colorDialog.Color;
                imageEditor.SetBrushColor(colorDialog.Color);
            }
        }

        private void nud_BrushRadius_ValueChanged(object sender, EventArgs e)
        {
            imageEditor.SetBrushRadius(Convert.ToInt32(nud_BrushRadius.Value));
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                imageEditor.LoadImage(filePath);
                imageField.Refresh();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog())
        }
    }
}
