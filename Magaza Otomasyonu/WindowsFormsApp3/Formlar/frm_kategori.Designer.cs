namespace melihkocak0385
{
    partial class frm_kategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kategori));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_KATEGORIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilkOtomasyonDataSet = new WindowsFormsApp3.IlkOtomasyonDataSet();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.coms_text = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tumunusecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_no = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_ayrac = new System.Windows.Forms.Panel();
            this.sgmt_kategori = new XanderUI.XUISegment();
            this.pnl_islem = new System.Windows.Forms.Panel();
            this.coms_form = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbx_ara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.pnl_istatistik = new System.Windows.Forms.Panel();
            this.error_no = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBL_KATEGORITableAdapter = new WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TBL_KATEGORITableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_KATEGORIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkOtomasyonDataSet)).BeginInit();
            this.coms_text.SuspendLayout();
            this.pnl_islem.SuspendLayout();
            this.coms_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_istatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_no)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kNoDataGridViewTextBoxColumn,
            this.kAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBL_KATEGORIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(669, 212);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kNoDataGridViewTextBoxColumn
            // 
            this.kNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kNoDataGridViewTextBoxColumn.DataPropertyName = "K_No";
            this.kNoDataGridViewTextBoxColumn.HeaderText = "Kategori No";
            this.kNoDataGridViewTextBoxColumn.Name = "kNoDataGridViewTextBoxColumn";
            this.kNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kAdDataGridViewTextBoxColumn
            // 
            this.kAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kAdDataGridViewTextBoxColumn.DataPropertyName = "K_Ad";
            this.kAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.kAdDataGridViewTextBoxColumn.Name = "kAdDataGridViewTextBoxColumn";
            this.kAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBL_KATEGORIBindingSource
            // 
            this.tBL_KATEGORIBindingSource.DataMember = "TBL_KATEGORI";
            this.tBL_KATEGORIBindingSource.DataSource = this.ilkOtomasyonDataSet;
            // 
            // ilkOtomasyonDataSet
            // 
            this.ilkOtomasyonDataSet.DataSetName = "IlkOtomasyonDataSet";
            this.ilkOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_no
            // 
            this.txt_no.ContextMenuStrip = this.coms_text;
            this.txt_no.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_no.Location = new System.Drawing.Point(97, 26);
            this.txt_no.MaxLength = 255;
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(150, 23);
            this.txt_no.TabIndex = 3;
            this.txt_no.TextChanged += new System.EventHandler(this.txt_no_TextChanged);
            this.txt_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_KeyPress);
            // 
            // coms_text
            // 
            this.coms_text.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tumunusecToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem,
            this.kesToolStripMenuItem});
            this.coms_text.Name = "coms_text";
            this.coms_text.Size = new System.Drawing.Size(183, 92);
            // 
            // tumunusecToolStripMenuItem
            // 
            this.tumunusecToolStripMenuItem.Name = "tumunusecToolStripMenuItem";
            this.tumunusecToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tumunusecToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tumunusecToolStripMenuItem.Text = "Tümünü Seç";
            this.tumunusecToolStripMenuItem.Click += new System.EventHandler(this.tumunusecToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapistirToolStripMenuItem
            // 
            this.yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            this.yapistirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapistirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yapistirToolStripMenuItem.Text = "Yapıştır";
            this.yapistirToolStripMenuItem.Click += new System.EventHandler(this.yapistirToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(470, 3);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(191, 32);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Kategori Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_no.ForeColor = System.Drawing.Color.White;
            this.lbl_no.Location = new System.Drawing.Point(3, 25);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(88, 20);
            this.lbl_no.TabIndex = 3;
            this.lbl_no.Text = "Kategori No:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.White;
            this.lbl_ad.Location = new System.Drawing.Point(3, 52);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(86, 20);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "Kategori Ad:";
            // 
            // txt_ad
            // 
            this.txt_ad.ContextMenuStrip = this.coms_text;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(97, 53);
            this.txt_ad.MaxLength = 30;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(150, 23);
            this.txt_ad.TabIndex = 4;
            this.txt_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad_KeyPress);
            // 
            // btn_sil
            // 
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(470, 45);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(191, 32);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Kategori Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(471, 129);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(191, 32);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "Kategori Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Image = ((System.Drawing.Image)(resources.GetObject("btn_listele.Image")));
            this.btn_listele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listele.Location = new System.Drawing.Point(470, 87);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(191, 32);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.Text = "Kategori Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifirla.Image = ((System.Drawing.Image)(resources.GetObject("btn_sifirla.Image")));
            this.btn_sifirla.Location = new System.Drawing.Point(236, 3);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(13, 17);
            this.btn_sifirla.TabIndex = 2;
            this.btn_sifirla.UseVisualStyleBackColor = true;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // pnl_ayrac
            // 
            this.pnl_ayrac.BackColor = System.Drawing.Color.White;
            this.pnl_ayrac.Location = new System.Drawing.Point(335, -2);
            this.pnl_ayrac.Name = "pnl_ayrac";
            this.pnl_ayrac.Size = new System.Drawing.Size(3, 41);
            this.pnl_ayrac.TabIndex = 22;
            // 
            // sgmt_kategori
            // 
            this.sgmt_kategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.sgmt_kategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sgmt_kategori.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sgmt_kategori.Items = "İşlemler, İstatistikler";
            this.sgmt_kategori.Location = new System.Drawing.Point(-3, -2);
            this.sgmt_kategori.Name = "sgmt_kategori";
            this.sgmt_kategori.SegmentActiveTextColor = System.Drawing.Color.White;
            this.sgmt_kategori.SegmentBackColor = System.Drawing.Color.Transparent;
            this.sgmt_kategori.SegmentColor = System.Drawing.Color.White;
            this.sgmt_kategori.SegmentInactiveTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.sgmt_kategori.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.sgmt_kategori.SelectedIndex = 0;
            this.sgmt_kategori.Size = new System.Drawing.Size(677, 41);
            this.sgmt_kategori.TabIndex = 1;
            this.sgmt_kategori.IndexChanged += new System.EventHandler(this.sgmt_kategori_IndexChanged);
            // 
            // pnl_islem
            // 
            this.pnl_islem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_islem.ContextMenuStrip = this.coms_form;
            this.pnl_islem.Controls.Add(this.cmbx_ara);
            this.pnl_islem.Controls.Add(this.label1);
            this.pnl_islem.Controls.Add(this.btn_ekle);
            this.pnl_islem.Controls.Add(this.dataGridView1);
            this.pnl_islem.Controls.Add(this.txt_no);
            this.pnl_islem.Controls.Add(this.btn_sifirla);
            this.pnl_islem.Controls.Add(this.lbl_no);
            this.pnl_islem.Controls.Add(this.btn_listele);
            this.pnl_islem.Controls.Add(this.lbl_ad);
            this.pnl_islem.Controls.Add(this.btn_ara);
            this.pnl_islem.Controls.Add(this.btn_guncelle);
            this.pnl_islem.Controls.Add(this.txt_ad);
            this.pnl_islem.Controls.Add(this.btn_sil);
            this.pnl_islem.Location = new System.Drawing.Point(3, 45);
            this.pnl_islem.Name = "pnl_islem";
            this.pnl_islem.Size = new System.Drawing.Size(687, 432);
            this.pnl_islem.TabIndex = 24;
            // 
            // coms_form
            // 
            this.coms_form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikisToolStripMenuItem});
            this.coms_form.Name = "coms_form";
            this.coms_form.Size = new System.Drawing.Size(100, 26);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // cmbx_ara
            // 
            this.cmbx_ara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_ara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_ara.FormattingEnabled = true;
            this.cmbx_ara.Items.AddRange(new object[] {
            "Seçiniz...",
            "No\'ya Göre",
            "Ada Göre"});
            this.cmbx_ara.Location = new System.Drawing.Point(97, 81);
            this.cmbx_ara.Name = "cmbx_ara";
            this.cmbx_ara.Size = new System.Drawing.Size(150, 25);
            this.cmbx_ara.TabIndex = 5;
            this.cmbx_ara.SelectedIndexChanged += new System.EventHandler(this.cmbx_ara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kategori Ara:";
            // 
            // btn_ara
            // 
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.Location = new System.Drawing.Point(471, 171);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(191, 32);
            this.btn_ara.TabIndex = 10;
            this.btn_ara.Text = "Kategori Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 38);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(233, 163);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adet.ForeColor = System.Drawing.Color.White;
            this.lbl_adet.Location = new System.Drawing.Point(3, 15);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(110, 20);
            this.lbl_adet.TabIndex = 37;
            this.lbl_adet.Text = "Kategori Sayısı:";
            // 
            // pnl_istatistik
            // 
            this.pnl_istatistik.Controls.Add(this.lbl_adet);
            this.pnl_istatistik.Controls.Add(this.chart1);
            this.pnl_istatistik.Location = new System.Drawing.Point(693, 45);
            this.pnl_istatistik.Name = "pnl_istatistik";
            this.pnl_istatistik.Size = new System.Drawing.Size(671, 432);
            this.pnl_istatistik.TabIndex = 25;
            // 
            // error_no
            // 
            this.error_no.ContainerControl = this;
            // 
            // tBL_KATEGORITableAdapter
            // 
            this.tBL_KATEGORITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Siparis_Urun_DetayTableAdapter = null;
            this.tableAdapterManager.TBL_KATEGORITableAdapter = this.tBL_KATEGORITableAdapter;
            this.tableAdapterManager.TBL_MUSTERİTableAdapter = null;
            this.tableAdapterManager.TBL_SIPARISTableAdapter = null;
            this.tableAdapterManager.TBL_TEDARIKCILERTableAdapter = null;
            this.tableAdapterManager.TBL_URUNTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(677, 478);
            this.Controls.Add(this.pnl_istatistik);
            this.Controls.Add(this.pnl_islem);
            this.Controls.Add(this.pnl_ayrac);
            this.Controls.Add(this.sgmt_kategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_kategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.frm_kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_KATEGORIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkOtomasyonDataSet)).EndInit();
            this.coms_text.ResumeLayout(false);
            this.pnl_islem.ResumeLayout(false);
            this.pnl_islem.PerformLayout();
            this.coms_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnl_istatistik.ResumeLayout(false);
            this.pnl_istatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_no)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sifirla;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnl_ayrac;
        private XanderUI.XUISegment sgmt_kategori;
        private System.Windows.Forms.Panel pnl_islem;
        private System.Windows.Forms.ContextMenuStrip coms_text;
        private System.Windows.Forms.ContextMenuStrip coms_form;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tumunusecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Panel pnl_istatistik;
        private System.Windows.Forms.ErrorProvider error_no;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_ara;
        private System.Windows.Forms.BindingSource tBL_KATEGORIBindingSource;
        private WindowsFormsApp3.IlkOtomasyonDataSet ilkOtomasyonDataSet;
        private WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TBL_KATEGORITableAdapter tBL_KATEGORITableAdapter;
        private WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAdDataGridViewTextBoxColumn;
    }
}