namespace melihkocak0385
{
    partial class frm_musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_musteri));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.coms_text = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tumunusectoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_MUSTERİBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilkOtomasyonDataSet = new WindowsFormsApp3.IlkOtomasyonDataSet();
            this.lbl_no = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.cmbx_ara = new System.Windows.Forms.ComboBox();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_sıfırla = new System.Windows.Forms.Button();
            this.pnl_islem = new System.Windows.Forms.Panel();
            this.pnl_ayrac = new System.Windows.Forms.Panel();
            this.sgmt_musteri = new XanderUI.XUISegment();
            this.pnl_istatistik = new System.Windows.Forms.Panel();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.coms_form = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error_no = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_soyad = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBL_MUSTERİTableAdapter = new WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TBL_MUSTERİTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager();
            this.coms_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_MUSTERİBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkOtomasyonDataSet)).BeginInit();
            this.pnl_islem.SuspendLayout();
            this.pnl_istatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.coms_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_soyad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(481, 50);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(191, 32);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Müşteri Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(481, 6);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(191, 32);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Müşteri Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(481, 138);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(191, 32);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Müşteri Güncelle";
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
            this.btn_listele.Location = new System.Drawing.Point(481, 94);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(191, 32);
            this.btn_listele.TabIndex = 11;
            this.btn_listele.Text = "Müşteri Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.ContextMenuStrip = this.coms_text;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(115, 51);
            this.txt_ad.MaxLength = 30;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(150, 23);
            this.txt_ad.TabIndex = 4;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            this.txt_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad_KeyPress);
            // 
            // coms_text
            // 
            this.coms_text.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tumunusectoolStripMenuItem1,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem,
            this.kesToolStripMenuItem});
            this.coms_text.Name = "coms_text";
            this.coms_text.Size = new System.Drawing.Size(183, 92);
            // 
            // tumunusectoolStripMenuItem1
            // 
            this.tumunusectoolStripMenuItem1.Name = "tumunusectoolStripMenuItem1";
            this.tumunusectoolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tumunusectoolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.tumunusectoolStripMenuItem1.Text = "Tümünü Seç";
            this.tumunusectoolStripMenuItem1.Click += new System.EventHandler(this.tumunusectoolStripMenuItem1_Click);
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
            this.yapistirToolStripMenuItem.ShortcutKeyDisplayString = "";
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
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.SystemColors.Window;
            this.txt_soyad.ContextMenuStrip = this.coms_text;
            this.txt_soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(115, 79);
            this.txt_soyad.MaxLength = 30;
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(150, 23);
            this.txt_soyad.TabIndex = 5;
            this.txt_soyad.TextChanged += new System.EventHandler(this.txt_soyad_TextChanged);
            this.txt_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soyad_KeyPress);
            // 
            // txt_mail
            // 
            this.txt_mail.ContextMenuStrip = this.coms_text;
            this.txt_mail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(115, 135);
            this.txt_mail.MaxLength = 40;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(150, 23);
            this.txt_mail.TabIndex = 7;
            // 
            // txt_tel
            // 
            this.txt_tel.ContextMenuStrip = this.coms_text;
            this.txt_tel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(115, 107);
            this.txt_tel.MaxLength = 11;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(150, 23);
            this.txt_tel.TabIndex = 6;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.White;
            this.lbl_ad.Location = new System.Drawing.Point(5, 53);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(80, 20);
            this.lbl_ad.TabIndex = 8;
            this.lbl_ad.Text = "Müşteri Ad:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.White;
            this.lbl_soyad.Location = new System.Drawing.Point(5, 81);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(104, 20);
            this.lbl_soyad.TabIndex = 9;
            this.lbl_soyad.Text = "Müşteri Soyad:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.ForeColor = System.Drawing.Color.White;
            this.lbl_mail.Location = new System.Drawing.Point(5, 137);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(92, 20);
            this.lbl_mail.TabIndex = 10;
            this.lbl_mail.Text = "Müşteri Mail:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel.ForeColor = System.Drawing.Color.White;
            this.lbl_tel.Location = new System.Drawing.Point(5, 109);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(83, 20);
            this.lbl_tel.TabIndex = 11;
            this.lbl_tel.Text = "Müşteri Tel:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNoDataGridViewTextBoxColumn,
            this.mAdDataGridViewTextBoxColumn,
            this.mSoyadDataGridViewTextBoxColumn,
            this.mTelDataGridViewTextBoxColumn,
            this.mMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBL_MUSTERİBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(669, 212);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mNoDataGridViewTextBoxColumn
            // 
            this.mNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mNoDataGridViewTextBoxColumn.DataPropertyName = "M_No";
            this.mNoDataGridViewTextBoxColumn.HeaderText = "Müşteri No";
            this.mNoDataGridViewTextBoxColumn.Name = "mNoDataGridViewTextBoxColumn";
            this.mNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAdDataGridViewTextBoxColumn
            // 
            this.mAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mAdDataGridViewTextBoxColumn.DataPropertyName = "M_Ad";
            this.mAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.mAdDataGridViewTextBoxColumn.Name = "mAdDataGridViewTextBoxColumn";
            this.mAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSoyadDataGridViewTextBoxColumn
            // 
            this.mSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mSoyadDataGridViewTextBoxColumn.DataPropertyName = "M_Soyad";
            this.mSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.mSoyadDataGridViewTextBoxColumn.Name = "mSoyadDataGridViewTextBoxColumn";
            this.mSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mTelDataGridViewTextBoxColumn
            // 
            this.mTelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mTelDataGridViewTextBoxColumn.DataPropertyName = "M_Tel";
            this.mTelDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.mTelDataGridViewTextBoxColumn.Name = "mTelDataGridViewTextBoxColumn";
            this.mTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mMailDataGridViewTextBoxColumn
            // 
            this.mMailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mMailDataGridViewTextBoxColumn.DataPropertyName = "M_Mail";
            this.mMailDataGridViewTextBoxColumn.HeaderText = "Mail Adresi";
            this.mMailDataGridViewTextBoxColumn.Name = "mMailDataGridViewTextBoxColumn";
            this.mMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBL_MUSTERİBindingSource
            // 
            this.tBL_MUSTERİBindingSource.DataMember = "TBL_MUSTERİ";
            this.tBL_MUSTERİBindingSource.DataSource = this.ilkOtomasyonDataSet;
            // 
            // ilkOtomasyonDataSet
            // 
            this.ilkOtomasyonDataSet.DataSetName = "IlkOtomasyonDataSet";
            this.ilkOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_no.ForeColor = System.Drawing.Color.White;
            this.lbl_no.Location = new System.Drawing.Point(5, 23);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(82, 20);
            this.lbl_no.TabIndex = 14;
            this.lbl_no.Text = "Müşteri No:";
            // 
            // txt_no
            // 
            this.txt_no.ContextMenuStrip = this.coms_text;
            this.txt_no.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_no.Location = new System.Drawing.Point(115, 23);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(150, 23);
            this.txt_no.TabIndex = 3;
            this.txt_no.TextChanged += new System.EventHandler(this.txt_no_TextChanged);
            this.txt_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_KeyPress);
            // 
            // cmbx_ara
            // 
            this.cmbx_ara.DisplayMember = "0";
            this.cmbx_ara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_ara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_ara.FormattingEnabled = true;
            this.cmbx_ara.Items.AddRange(new object[] {
            "Seçiniz..",
            "No\'ya Göre Ara",
            "Ada Göre Ara"});
            this.cmbx_ara.Location = new System.Drawing.Point(115, 165);
            this.cmbx_ara.Name = "cmbx_ara";
            this.cmbx_ara.Size = new System.Drawing.Size(150, 25);
            this.cmbx_ara.TabIndex = 8;
            this.cmbx_ara.Tag = "";
            this.cmbx_ara.ValueMember = "0";
            this.cmbx_ara.SelectedIndexChanged += new System.EventHandler(this.cmbx_ara_SelectedIndexChanged);
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.ForeColor = System.Drawing.Color.White;
            this.lbl_ara.Location = new System.Drawing.Point(5, 167);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(106, 20);
            this.lbl_ara.TabIndex = 16;
            this.lbl_ara.Text = "Müşteri Arama:";
            // 
            // btn_ara
            // 
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.Location = new System.Drawing.Point(481, 182);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(191, 32);
            this.btn_ara.TabIndex = 13;
            this.btn_ara.Text = "Müşteri Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sıfırla.FlatAppearance.BorderSize = 0;
            this.btn_sıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sıfırla.Image = ((System.Drawing.Image)(resources.GetObject("btn_sıfırla.Image")));
            this.btn_sıfırla.Location = new System.Drawing.Point(252, 4);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sıfırla.Size = new System.Drawing.Size(13, 16);
            this.btn_sıfırla.TabIndex = 2;
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // pnl_islem
            // 
            this.pnl_islem.Controls.Add(this.btn_sil);
            this.pnl_islem.Controls.Add(this.btn_sıfırla);
            this.pnl_islem.Controls.Add(this.btn_ekle);
            this.pnl_islem.Controls.Add(this.btn_ara);
            this.pnl_islem.Controls.Add(this.btn_guncelle);
            this.pnl_islem.Controls.Add(this.lbl_ara);
            this.pnl_islem.Controls.Add(this.btn_listele);
            this.pnl_islem.Controls.Add(this.cmbx_ara);
            this.pnl_islem.Controls.Add(this.txt_ad);
            this.pnl_islem.Controls.Add(this.lbl_no);
            this.pnl_islem.Controls.Add(this.txt_soyad);
            this.pnl_islem.Controls.Add(this.txt_no);
            this.pnl_islem.Controls.Add(this.txt_mail);
            this.pnl_islem.Controls.Add(this.dataGridView1);
            this.pnl_islem.Controls.Add(this.txt_tel);
            this.pnl_islem.Controls.Add(this.lbl_tel);
            this.pnl_islem.Controls.Add(this.lbl_ad);
            this.pnl_islem.Controls.Add(this.lbl_mail);
            this.pnl_islem.Controls.Add(this.lbl_soyad);
            this.pnl_islem.Location = new System.Drawing.Point(-3, 40);
            this.pnl_islem.Name = "pnl_islem";
            this.pnl_islem.Size = new System.Drawing.Size(695, 452);
            this.pnl_islem.TabIndex = 19;
            // 
            // pnl_ayrac
            // 
            this.pnl_ayrac.BackColor = System.Drawing.Color.White;
            this.pnl_ayrac.Location = new System.Drawing.Point(335, -2);
            this.pnl_ayrac.Name = "pnl_ayrac";
            this.pnl_ayrac.Size = new System.Drawing.Size(3, 41);
            this.pnl_ayrac.TabIndex = 22;
            // 
            // sgmt_musteri
            // 
            this.sgmt_musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.sgmt_musteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sgmt_musteri.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sgmt_musteri.Items = "İşlemler, İstatistikler";
            this.sgmt_musteri.Location = new System.Drawing.Point(-3, -2);
            this.sgmt_musteri.Name = "sgmt_musteri";
            this.sgmt_musteri.SegmentActiveTextColor = System.Drawing.Color.White;
            this.sgmt_musteri.SegmentBackColor = System.Drawing.Color.Transparent;
            this.sgmt_musteri.SegmentColor = System.Drawing.Color.White;
            this.sgmt_musteri.SegmentInactiveTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.sgmt_musteri.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.sgmt_musteri.SelectedIndex = 0;
            this.sgmt_musteri.Size = new System.Drawing.Size(677, 41);
            this.sgmt_musteri.TabIndex = 1;
            this.sgmt_musteri.IndexChanged += new System.EventHandler(this.sgmt_musteri_IndexChanged);
            // 
            // pnl_istatistik
            // 
            this.pnl_istatistik.Controls.Add(this.lbl_adet);
            this.pnl_istatistik.Controls.Add(this.chart1);
            this.pnl_istatistik.Location = new System.Drawing.Point(695, 40);
            this.pnl_istatistik.Name = "pnl_istatistik";
            this.pnl_istatistik.Size = new System.Drawing.Size(673, 451);
            this.pnl_istatistik.TabIndex = 20;
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adet.ForeColor = System.Drawing.Color.White;
            this.lbl_adet.Location = new System.Drawing.Point(11, 18);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(216, 20);
            this.lbl_adet.TabIndex = 37;
            this.lbl_adet.Text = "Mağazada Kayıtlı Müşteri Sayısı:";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(15, 51);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(233, 163);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // coms_form
            // 
            this.coms_form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.coms_form.Name = "coms_1";
            this.coms_form.Size = new System.Drawing.Size(100, 26);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // error_no
            // 
            this.error_no.ContainerControl = this;
            // 
            // error_ad
            // 
            this.error_ad.ContainerControl = this;
            // 
            // error_soyad
            // 
            this.error_soyad.ContainerControl = this;
            // 
            // tBL_MUSTERİTableAdapter
            // 
            this.tBL_MUSTERİTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Siparis_Urun_DetayTableAdapter = null;
            this.tableAdapterManager.TBL_KATEGORITableAdapter = null;
            this.tableAdapterManager.TBL_MUSTERİTableAdapter = this.tBL_MUSTERİTableAdapter;
            this.tableAdapterManager.TBL_SIPARISTableAdapter = null;
            this.tableAdapterManager.TBL_TEDARIKCILERTableAdapter = null;
            this.tableAdapterManager.TBL_URUNTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(677, 478);
            this.ContextMenuStrip = this.coms_form;
            this.Controls.Add(this.pnl_istatistik);
            this.Controls.Add(this.pnl_ayrac);
            this.Controls.Add(this.sgmt_musteri);
            this.Controls.Add(this.pnl_islem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_musteri";
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.frm_musteri_Load);
            this.coms_text.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_MUSTERİBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkOtomasyonDataSet)).EndInit();
            this.pnl_islem.ResumeLayout(false);
            this.pnl_islem.PerformLayout();
            this.pnl_istatistik.ResumeLayout(false);
            this.pnl_istatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.coms_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_soyad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.ComboBox cmbx_ara;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_sıfırla;
        private System.Windows.Forms.Panel pnl_islem;
        private System.Windows.Forms.Panel pnl_ayrac;
        private XanderUI.XUISegment sgmt_musteri;
        private System.Windows.Forms.Panel pnl_istatistik;
        private System.Windows.Forms.ContextMenuStrip coms_form;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip coms_text;
        private System.Windows.Forms.ToolStripMenuItem tumunusectoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.ErrorProvider error_no;
        private System.Windows.Forms.ErrorProvider error_ad;
        private System.Windows.Forms.ErrorProvider error_soyad;
        private System.Windows.Forms.BindingSource tBL_MUSTERİBindingSource;
        private WindowsFormsApp3.IlkOtomasyonDataSet ilkOtomasyonDataSet;
        private WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TBL_MUSTERİTableAdapter tBL_MUSTERİTableAdapter;
        private WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMailDataGridViewTextBoxColumn;
    }
}