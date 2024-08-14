
namespace Марк_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3ToMIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3ToWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAVToMIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDToPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDToSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheetMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(167, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 471);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(201, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(714, 376);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 151);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 545);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(758, 196);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(268, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(317, 147);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.mP3ToMIDToolStripMenuItem,
            this.mP3ToWAVToolStripMenuItem,
            this.wAVToMIDToolStripMenuItem,
            this.mIDToPDFToolStripMenuItem,
            this.mIDToSheetToolStripMenuItem,
            this.sheetMusicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mP3ToMIDToolStripMenuItem
            // 
            this.mP3ToMIDToolStripMenuItem.Name = "mP3ToMIDToolStripMenuItem";
            this.mP3ToMIDToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.mP3ToMIDToolStripMenuItem.Text = "MP3 to MID";
            this.mP3ToMIDToolStripMenuItem.Click += new System.EventHandler(this.mP3ToMIDToolStripMenuItem_Click);
            // 
            // mP3ToWAVToolStripMenuItem
            // 
            this.mP3ToWAVToolStripMenuItem.Name = "mP3ToWAVToolStripMenuItem";
            this.mP3ToWAVToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.mP3ToWAVToolStripMenuItem.Text = "MP3 to WAV";
            this.mP3ToWAVToolStripMenuItem.Click += new System.EventHandler(this.mP3ToWAVToolStripMenuItem_Click);
            // 
            // wAVToMIDToolStripMenuItem
            // 
            this.wAVToMIDToolStripMenuItem.Name = "wAVToMIDToolStripMenuItem";
            this.wAVToMIDToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.wAVToMIDToolStripMenuItem.Text = "WAV to MID";
            this.wAVToMIDToolStripMenuItem.Click += new System.EventHandler(this.wAVToMIDToolStripMenuItem_Click);
            // 
            // mIDToPDFToolStripMenuItem
            // 
            this.mIDToPDFToolStripMenuItem.Name = "mIDToPDFToolStripMenuItem";
            this.mIDToPDFToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.mIDToPDFToolStripMenuItem.Text = "MID to PDF";
            this.mIDToPDFToolStripMenuItem.Click += new System.EventHandler(this.mIDToPDFToolStripMenuItem_Click);
            // 
            // mIDToSheetToolStripMenuItem
            // 
            this.mIDToSheetToolStripMenuItem.Name = "mIDToSheetToolStripMenuItem";
            this.mIDToSheetToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.mIDToSheetToolStripMenuItem.Text = "MID to sheet";
            this.mIDToSheetToolStripMenuItem.Click += new System.EventHandler(this.mIDToSheetToolStripMenuItem_Click);
            // 
            // sheetMusicToolStripMenuItem
            // 
            this.sheetMusicToolStripMenuItem.Name = "sheetMusicToolStripMenuItem";
            this.sheetMusicToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.sheetMusicToolStripMenuItem.Text = "Sheet music";
            this.sheetMusicToolStripMenuItem.Click += new System.EventHandler(this.sheetMusicToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Марк_4.Properties.Resources.скрипичный_ключ;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.Text = "Редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3ToWAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wAVToMIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIDToPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIDToSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3ToMIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheetMusicToolStripMenuItem;
    }
}

