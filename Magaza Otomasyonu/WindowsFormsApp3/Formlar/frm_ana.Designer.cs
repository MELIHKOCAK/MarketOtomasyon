namespace melihkocak0385
{
    partial class frm_ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ana));
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_tedarikciler = new System.Windows.Forms.Button();
            this.pnl_gecis = new System.Windows.Forms.Panel();
            this.pnl_ust = new System.Windows.Forms.Panel();
            this.xuıObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuıSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.pnl_rapor = new System.Windows.Forms.Panel();
            this.btn_rapor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_tedarikciler = new System.Windows.Forms.Panel();
            this.pnl_kategori = new System.Windows.Forms.Panel();
            this.pnl_siparis = new System.Windows.Forms.Panel();
            this.pnl_urun = new System.Windows.Forms.Panel();
            this.pnl_musteri = new System.Windows.Forms.Panel();
            this.Çıkış = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_orta = new System.Windows.Forms.Panel();
            this.xuıSlidingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_musteri
            // 
            this.btn_musteri.BackColor = System.Drawing.Color.Transparent;
            this.btn_musteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_musteri.FlatAppearance.BorderSize = 0;
            this.btn_musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musteri.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musteri.ForeColor = System.Drawing.Color.White;
            this.btn_musteri.Image = ((System.Drawing.Image)(resources.GetObject("btn_musteri.Image")));
            this.btn_musteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_musteri.Location = new System.Drawing.Point(19, 122);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(174, 55);
            this.btn_musteri.TabIndex = 0;
            this.btn_musteri.Text = "Müşteri";
            this.btn_musteri.UseVisualStyleBackColor = false;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            this.btn_musteri.MouseLeave += new System.EventHandler(this.btn_musteri_MouseLeave);
            this.btn_musteri.MouseHover += new System.EventHandler(this.btn_musteri_MouseHover);
            // 
            // btn_urun
            // 
            this.btn_urun.BackColor = System.Drawing.Color.Transparent;
            this.btn_urun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_urun.FlatAppearance.BorderSize = 0;
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urun.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urun.ForeColor = System.Drawing.Color.White;
            this.btn_urun.Image = ((System.Drawing.Image)(resources.GetObject("btn_urun.Image")));
            this.btn_urun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urun.Location = new System.Drawing.Point(19, 260);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(174, 55);
            this.btn_urun.TabIndex = 1;
            this.btn_urun.Text = "Ürünler";
            this.btn_urun.UseVisualStyleBackColor = false;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            this.btn_urun.MouseLeave += new System.EventHandler(this.btn_urun_MouseLeave);
            this.btn_urun.MouseHover += new System.EventHandler(this.btn_urun_MouseHover);
            // 
            // btn_siparis
            // 
            this.btn_siparis.BackColor = System.Drawing.Color.Transparent;
            this.btn_siparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siparis.FlatAppearance.BorderSize = 0;
            this.btn_siparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siparis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparis.ForeColor = System.Drawing.Color.White;
            this.btn_siparis.Image = ((System.Drawing.Image)(resources.GetObject("btn_siparis.Image")));
            this.btn_siparis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_siparis.Location = new System.Drawing.Point(19, 191);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(174, 55);
            this.btn_siparis.TabIndex = 2;
            this.btn_siparis.Text = "Sipariş";
            this.btn_siparis.UseVisualStyleBackColor = false;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            this.btn_siparis.MouseLeave += new System.EventHandler(this.btn_siparis_MouseLeave_1);
            this.btn_siparis.MouseHover += new System.EventHandler(this.btn_siparis_MouseHover);
            // 
            // btn_kategori
            // 
            this.btn_kategori.BackColor = System.Drawing.Color.Transparent;
            this.btn_kategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kategori.FlatAppearance.BorderSize = 0;
            this.btn_kategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kategori.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategori.ForeColor = System.Drawing.Color.White;
            this.btn_kategori.Image = ((System.Drawing.Image)(resources.GetObject("btn_kategori.Image")));
            this.btn_kategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kategori.Location = new System.Drawing.Point(19, 398);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(174, 55);
            this.btn_kategori.TabIndex = 3;
            this.btn_kategori.Text = "Kategori";
            this.btn_kategori.UseVisualStyleBackColor = false;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            this.btn_kategori.MouseLeave += new System.EventHandler(this.btn_kategori_MouseLeave);
            this.btn_kategori.MouseHover += new System.EventHandler(this.btn_kategori_MouseHover);
            // 
            // btn_tedarikciler
            // 
            this.btn_tedarikciler.BackColor = System.Drawing.Color.Transparent;
            this.btn_tedarikciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tedarikciler.FlatAppearance.BorderSize = 0;
            this.btn_tedarikciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tedarikciler.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tedarikciler.ForeColor = System.Drawing.Color.White;
            this.btn_tedarikciler.Image = ((System.Drawing.Image)(resources.GetObject("btn_tedarikciler.Image")));
            this.btn_tedarikciler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tedarikciler.Location = new System.Drawing.Point(19, 329);
            this.btn_tedarikciler.Name = "btn_tedarikciler";
            this.btn_tedarikciler.Size = new System.Drawing.Size(174, 55);
            this.btn_tedarikciler.TabIndex = 7;
            this.btn_tedarikciler.Text = "        Ürün Tedarikçileri";
            this.btn_tedarikciler.UseVisualStyleBackColor = false;
            this.btn_tedarikciler.Click += new System.EventHandler(this.btn_tedarikciler_Click);
            this.btn_tedarikciler.MouseLeave += new System.EventHandler(this.btn_tedarikciler_MouseLeave);
            this.btn_tedarikciler.MouseHover += new System.EventHandler(this.btn_tedarikciler_MouseHover);
            // 
            // pnl_gecis
            // 
            this.pnl_gecis.BackColor = System.Drawing.Color.Brown;
            this.pnl_gecis.Location = new System.Drawing.Point(1, 75);
            this.pnl_gecis.Name = "pnl_gecis";
            this.pnl_gecis.Size = new System.Drawing.Size(5, 55);
            this.pnl_gecis.TabIndex = 6;
            // 
            // pnl_ust
            // 
            this.pnl_ust.BackColor = System.Drawing.Color.Brown;
            this.pnl_ust.Location = new System.Drawing.Point(0, 0);
            this.pnl_ust.Name = "pnl_ust";
            this.pnl_ust.Size = new System.Drawing.Size(1380, 14);
            this.pnl_ust.TabIndex = 5;
            this.pnl_ust.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_ust_MouseDown);
            this.pnl_ust.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_ust_MouseMove);
            this.pnl_ust.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_ust_MouseUp);
            // 
            // xuıObjectEllipse1
            // 
            this.xuıObjectEllipse1.CornerRadius = 50;
            this.xuıObjectEllipse1.EffectedControl = this;
            this.xuıObjectEllipse1.EffectedForm = this;
            // 
            // xuıSlidingPanel1
            // 
            this.xuıSlidingPanel1.BottomLeft = System.Drawing.Color.DodgerBlue;
            this.xuıSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuıSlidingPanel1.CollapseControl = null;
            this.xuıSlidingPanel1.Collapsed = true;
            this.xuıSlidingPanel1.Controls.Add(this.btn_kategori);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_kategori);
            this.xuıSlidingPanel1.Controls.Add(this.btn_urun);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_urun);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_rapor);
            this.xuıSlidingPanel1.Controls.Add(this.btn_rapor);
            this.xuıSlidingPanel1.Controls.Add(this.pictureBox1);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_tedarikciler);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_siparis);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_musteri);
            this.xuıSlidingPanel1.Controls.Add(this.Çıkış);
            this.xuıSlidingPanel1.Controls.Add(this.pnl_gecis);
            this.xuıSlidingPanel1.Controls.Add(this.btn_exit);
            this.xuıSlidingPanel1.Controls.Add(this.btn_tedarikciler);
            this.xuıSlidingPanel1.Controls.Add(this.btn_siparis);
            this.xuıSlidingPanel1.Controls.Add(this.btn_musteri);
            this.xuıSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuıSlidingPanel1.HideControls = false;
            this.xuıSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuıSlidingPanel1.Name = "xuıSlidingPanel1";
            this.xuıSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuıSlidingPanel1.PanelWidthExpanded = 200;
            this.xuıSlidingPanel1.PrimerColor = System.Drawing.Color.Transparent;
            this.xuıSlidingPanel1.Size = new System.Drawing.Size(207, 591);
            this.xuıSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuıSlidingPanel1.TabIndex = 12;
            this.xuıSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // pnl_rapor
            // 
            this.pnl_rapor.BackColor = System.Drawing.Color.White;
            this.pnl_rapor.Location = new System.Drawing.Point(6, 528);
            this.pnl_rapor.Name = "pnl_rapor";
            this.pnl_rapor.Size = new System.Drawing.Size(200, 2);
            this.pnl_rapor.TabIndex = 8;
            // 
            // btn_rapor
            // 
            this.btn_rapor.BackColor = System.Drawing.Color.Transparent;
            this.btn_rapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rapor.FlatAppearance.BorderSize = 0;
            this.btn_rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rapor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rapor.ForeColor = System.Drawing.Color.White;
            this.btn_rapor.Image = ((System.Drawing.Image)(resources.GetObject("btn_rapor.Image")));
            this.btn_rapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rapor.Location = new System.Drawing.Point(19, 467);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(174, 55);
            this.btn_rapor.TabIndex = 9;
            this.btn_rapor.Text = "Raporlama";
            this.btn_rapor.UseVisualStyleBackColor = false;
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            this.btn_rapor.MouseLeave += new System.EventHandler(this.btn_rapor_MouseLeave);
            this.btn_rapor.MouseHover += new System.EventHandler(this.btn_rapor_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(45, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 97);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_tedarikciler
            // 
            this.pnl_tedarikciler.BackColor = System.Drawing.Color.White;
            this.pnl_tedarikciler.Location = new System.Drawing.Point(6, 390);
            this.pnl_tedarikciler.Name = "pnl_tedarikciler";
            this.pnl_tedarikciler.Size = new System.Drawing.Size(200, 2);
            this.pnl_tedarikciler.TabIndex = 4;
            // 
            // pnl_kategori
            // 
            this.pnl_kategori.BackColor = System.Drawing.Color.White;
            this.pnl_kategori.Location = new System.Drawing.Point(6, 459);
            this.pnl_kategori.Name = "pnl_kategori";
            this.pnl_kategori.Size = new System.Drawing.Size(200, 2);
            this.pnl_kategori.TabIndex = 3;
            // 
            // pnl_siparis
            // 
            this.pnl_siparis.BackColor = System.Drawing.Color.White;
            this.pnl_siparis.Location = new System.Drawing.Point(6, 252);
            this.pnl_siparis.Name = "pnl_siparis";
            this.pnl_siparis.Size = new System.Drawing.Size(200, 2);
            this.pnl_siparis.TabIndex = 2;
            // 
            // pnl_urun
            // 
            this.pnl_urun.BackColor = System.Drawing.Color.White;
            this.pnl_urun.Location = new System.Drawing.Point(6, 321);
            this.pnl_urun.Name = "pnl_urun";
            this.pnl_urun.Size = new System.Drawing.Size(200, 2);
            this.pnl_urun.TabIndex = 1;
            // 
            // pnl_musteri
            // 
            this.pnl_musteri.BackColor = System.Drawing.Color.White;
            this.pnl_musteri.Location = new System.Drawing.Point(6, 183);
            this.pnl_musteri.Name = "pnl_musteri";
            this.pnl_musteri.Size = new System.Drawing.Size(200, 2);
            this.pnl_musteri.TabIndex = 0;
            // 
            // Çıkış
            // 
            this.Çıkış.AutoSize = true;
            this.Çıkış.BackColor = System.Drawing.Color.Transparent;
            this.Çıkış.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Çıkış.ForeColor = System.Drawing.Color.White;
            this.Çıkış.Location = new System.Drawing.Point(47, 547);
            this.Çıkış.Name = "Çıkış";
            this.Çıkış.Size = new System.Drawing.Size(41, 20);
            this.Çıkış.TabIndex = 8;
            this.Çıkış.Text = "Çıkış";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(0, 536);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(41, 43);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_orta
            // 
            this.pnl_orta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_orta.Location = new System.Drawing.Point(208, 14);
            this.pnl_orta.Name = "pnl_orta";
            this.pnl_orta.Size = new System.Drawing.Size(954, 576);
            this.pnl_orta.TabIndex = 10;
            // 
            // frm_ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1161, 591);
            this.Controls.Add(this.pnl_ust);
            this.Controls.Add(this.xuıSlidingPanel1);
            this.Controls.Add(this.pnl_orta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_ana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_ana_Load);
            this.xuıSlidingPanel1.ResumeLayout(false);
            this.xuıSlidingPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Panel pnl_ust;
        private System.Windows.Forms.Button btn_tedarikciler;
        private XanderUI.XUIObjectEllipse xuıObjectEllipse1;
        private XanderUI.XUISlidingPanel xuıSlidingPanel1;
        private System.Windows.Forms.Panel pnl_orta;
        private System.Windows.Forms.Label Çıkış;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Panel pnl_gecis;
        private System.Windows.Forms.Panel pnl_tedarikciler;
        private System.Windows.Forms.Panel pnl_kategori;
        private System.Windows.Forms.Panel pnl_siparis;
        private System.Windows.Forms.Panel pnl_urun;
        private System.Windows.Forms.Panel pnl_musteri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_rapor;
        private System.Windows.Forms.Button btn_rapor;
    }
}

