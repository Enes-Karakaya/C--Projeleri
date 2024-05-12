namespace Web_tarayıcı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.durum_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.geriButonu = new System.Windows.Forms.ToolStripButton();
            this.İleriButonu = new System.Windows.Forms.ToolStripButton();
            this.yenile_buton = new System.Windows.Forms.ToolStripButton();
            this.BtnAnasayfa = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.Buton_ara = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.durum_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(757, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // durum_label
            // 
            this.durum_label.Name = "durum_label";
            this.durum_label.Size = new System.Drawing.Size(47, 17);
            this.durum_label.Text = "Durum:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriButonu,
            this.İleriButonu,
            this.yenile_buton,
            this.BtnAnasayfa,
            this.toolStripTextBox1,
            this.Buton_ara,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // geriButonu
            // 
            this.geriButonu.Image = global::Web_tarayıcı.Properties.Resources.geri;
            this.geriButonu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.geriButonu.Name = "geriButonu";
            this.geriButonu.Size = new System.Drawing.Size(48, 22);
            this.geriButonu.Text = "Geri";
            this.geriButonu.Click += new System.EventHandler(this.geriButonu_Click);
            // 
            // İleriButonu
            // 
            this.İleriButonu.Image = global::Web_tarayıcı.Properties.Resources.ileri;
            this.İleriButonu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.İleriButonu.Name = "İleriButonu";
            this.İleriButonu.Size = new System.Drawing.Size(46, 22);
            this.İleriButonu.Text = "İleri";
            this.İleriButonu.Click += new System.EventHandler(this.İleriButonu_Click);
            // 
            // yenile_buton
            // 
            this.yenile_buton.Image = global::Web_tarayıcı.Properties.Resources.yenile;
            this.yenile_buton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yenile_buton.Name = "yenile_buton";
            this.yenile_buton.Size = new System.Drawing.Size(58, 22);
            this.yenile_buton.Text = "Yenile";
            this.yenile_buton.Click += new System.EventHandler(this.yenile_buton_Click);
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.Image")));
            this.BtnAnasayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.Size = new System.Drawing.Size(63, 22);
            this.BtnAnasayfa.Text = "Ana Sayfa";
            this.BtnAnasayfa.Click += new System.EventHandler(this.BtnAnasayfa_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Black;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(400, 25);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // Buton_ara
            // 
            this.Buton_ara.Image = global::Web_tarayıcı.Properties.Resources.seach;
            this.Buton_ara.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buton_ara.Name = "Buton_ara";
            this.Buton_ara.Size = new System.Drawing.Size(42, 22);
            this.Buton_ara.Text = "Git";
            this.Buton_ara.Click += new System.EventHandler(this.Buton_ara_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 559);
            this.panel1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(757, 559);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(31, 22);
            this.toolStripButton1.Text = "kod";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton geriButonu;
        private System.Windows.Forms.ToolStripButton İleriButonu;
        private System.Windows.Forms.ToolStripButton yenile_buton;
        private System.Windows.Forms.ToolStripButton BtnAnasayfa;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel durum_label;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton Buton_ara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

