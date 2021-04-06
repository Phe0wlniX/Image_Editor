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
    public partial class F_CreateNewBitmap : Form
    {
        public F_CreateNewBitmap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            MainForm.diagRes.ready = false;
        }

        private void bе_ok_Click(object sender, EventArgs e)
        {
            MainForm.diagRes.width = Convert.ToInt32(nud_Width.Value);
            MainForm.diagRes.heidth = Convert.ToInt32(nud_Heidth.Value);
            MainForm.diagRes.ready = true;
            this.Close();
        }

        private void bt_undone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
