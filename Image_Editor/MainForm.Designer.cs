namespace Image_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_open_window = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_close_window = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_instument = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_BrushRadius = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_color = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BrushRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.menu_View});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageDialog,
            this.Save,
            this.Create_new});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // openImageDialog
            // 
            this.openImageDialog.Name = "openImageDialog";
            this.openImageDialog.Size = new System.Drawing.Size(180, 22);
            this.openImageDialog.Text = "Загрузить";
            this.openImageDialog.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Сохранить как";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Create_new
            // 
            this.Create_new.Name = "Create_new";
            this.Create_new.Size = new System.Drawing.Size(180, 22);
            this.Create_new.Text = "Создать новый";
            this.Create_new.Click += new System.EventHandler(this.Create_new_Click);
            // 
            // menu_View
            // 
            this.menu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_open_window,
            this.bt_close_window});
            this.menu_View.Name = "menu_View";
            this.menu_View.Size = new System.Drawing.Size(39, 20);
            this.menu_View.Text = "Вид";
            // 
            // bt_open_window
            // 
            this.bt_open_window.Name = "bt_open_window";
            this.bt_open_window.Size = new System.Drawing.Size(213, 22);
            this.bt_open_window.Text = "Открыть окно рисования";
            this.bt_open_window.Click += new System.EventHandler(this.bt_open_window_Click);
            // 
            // bt_close_window
            // 
            this.bt_close_window.Name = "bt_close_window";
            this.bt_close_window.Size = new System.Drawing.Size(213, 22);
            this.bt_close_window.Text = "Закрыть окно рисования";
            this.bt_close_window.Click += new System.EventHandler(this.bt_close_window_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.bt_instument});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 0);
            // 
            // bt_instument
            // 
            this.bt_instument.Name = "bt_instument";
            this.bt_instument.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_instument.Size = new System.Drawing.Size(74, 17);
            this.bt_instument.Text = "Инструмент";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.nud_BrushRadius);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 404);
            this.panel2.TabIndex = 4;
            // 
            // nud_BrushRadius
            // 
            this.nud_BrushRadius.Location = new System.Drawing.Point(6, 106);
            this.nud_BrushRadius.Name = "nud_BrushRadius";
            this.nud_BrushRadius.Size = new System.Drawing.Size(120, 20);
            this.nud_BrushRadius.TabIndex = 0;
            this.nud_BrushRadius.ValueChanged += new System.EventHandler(this.nud_BrushRadius_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p_color);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кисть";
            // 
            // p_color
            // 
            this.p_color.BackColor = System.Drawing.SystemColors.HighlightText;
            this.p_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_color.Location = new System.Drawing.Point(6, 42);
            this.p_color.Name = "p_color";
            this.p_color.Size = new System.Drawing.Size(56, 24);
            this.p_color.TabIndex = 5;
            this.p_color.Tag = "";
            this.p_color.Paint += new System.Windows.Forms.PaintEventHandler(this.p_color_Paint);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_BrushRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem openImageDialog;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Create_new;
        private System.Windows.Forms.ToolStripMenuItem menu_View;
        private System.Windows.Forms.ToolStripMenuItem bt_open_window;
        private System.Windows.Forms.ToolStripMenuItem bt_close_window;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel bt_instument;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nud_BrushRadius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel p_color;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

