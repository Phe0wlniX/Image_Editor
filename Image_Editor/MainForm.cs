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
        public int heigth;
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
    }
}
