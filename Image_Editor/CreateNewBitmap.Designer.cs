namespace Image_Editor
{
    partial class F_CreateNewBitmap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Width = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Label();
            this.bе_ok = new System.Windows.Forms.Button();
            this.bt_undone = new System.Windows.Forms.Button();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.nud_Heidth = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Heidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(46, 56);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(46, 13);
            this.Width.TabIndex = 0;
            this.Width.Text = "Ширина";
            // 
            // bt
            // 
            this.bt.AutoSize = true;
            this.bt.Location = new System.Drawing.Point(239, 56);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(45, 13);
            this.bt.TabIndex = 1;
            this.bt.Text = "Высота";
            // 
            // bе_ok
            // 
            this.bе_ok.Location = new System.Drawing.Point(57, 115);
            this.bе_ok.Name = "bе_ok";
            this.bе_ok.Size = new System.Drawing.Size(75, 23);
            this.bе_ok.TabIndex = 2;
            this.bе_ok.Text = "ОК";
            this.bе_ok.UseVisualStyleBackColor = true;
            this.bе_ok.Click += new System.EventHandler(this.bе_ok_Click);
            // 
            // bt_undone
            // 
            this.bt_undone.Location = new System.Drawing.Point(201, 115);
            this.bt_undone.Name = "bt_undone";
            this.bt_undone.Size = new System.Drawing.Size(75, 23);
            this.bt_undone.TabIndex = 3;
            this.bt_undone.Text = "Отмена";
            this.bt_undone.UseVisualStyleBackColor = true;
            this.bt_undone.Click += new System.EventHandler(this.bt_undone_Click);
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(12, 72);
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(120, 20);
            this.nud_Width.TabIndex = 4;
            // 
            // nud_Heidth
            // 
            this.nud_Heidth.Location = new System.Drawing.Point(201, 72);
            this.nud_Heidth.Name = "nud_Heidth";
            this.nud_Heidth.Size = new System.Drawing.Size(120, 20);
            this.nud_Heidth.TabIndex = 5;
            // 
            // F_CreateNewBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 150);
            this.Controls.Add(this.nud_Heidth);
            this.Controls.Add(this.nud_Width);
            this.Controls.Add(this.bt_undone);
            this.Controls.Add(this.bе_ok);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.Width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CreateNewBitmap";
            this.Text = "Размер";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Heidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label bt;
        private System.Windows.Forms.Button bе_ok;
        private System.Windows.Forms.Button bt_undone;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.NumericUpDown nud_Heidth;
    }
}