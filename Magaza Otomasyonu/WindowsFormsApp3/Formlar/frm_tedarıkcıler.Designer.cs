namespace melihkocak0385
{
    partial class frm_tedarikciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tedarikciler));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.coms_text = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tumunusectoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.cmbx_ara = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_TEDARIKCILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilkOtomasyonDataSet = new WindowsFormsApp3.IlkOtomasyonDataSet();
            this.pnl_islem = new System.Windows.Forms.Panel();
            this.coms_form = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.lbl_no = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.sgmt_tedarikciler = new XanderUI.XUISegment();
            this.pnl_istatistik = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_aded = new System.Windows.Forms.Label();
            this.pnl_ayrac = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.error_no = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_adres = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBL_TEDARIKCILERTableAdapter = new WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TBL_TEDARIKCILERTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager();
            this.coms_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TEDARIKCILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkOtomasyonDataSet)).BeginInit();
            this.pnl_islem.SuspendLayout();
            this.coms_form.SuspendLayout();
            this.pnl_istatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_adres)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.White;
            this.lbl_ad.Location = new System.Drawing.Point(12, 55);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(90, 20);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Tedarikçi Ad:";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.ForeColor = System.Drawing.Color.White;
            this.lbl_adres.Location = new System.Drawing.Point(12, 84);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(112, 20);
            this.lbl_adres.TabIndex = 2;
            this.lbl_adres.Text = "Tedarikçi Adres:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel.ForeColor = System.Drawing.Color.White;
            this.lbl_tel.Location = new System.Drawing.Point(12, 113);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(93, 20);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "Tedarikçi Tel:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.ForeColor = System.Drawing.Color.White;
            this.lbl_mail.Location = new System.Drawing.Point(12, 142);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(102, 20);
            this.lbl_mail.TabIndex = 4;
            this.lbl_mail.Text = "Tedarikçi Mail:";
            // 
            // txt_ad
            // 
            this.txt_ad.ContextMenuStrip = this.coms_text;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(125, 52);
            this.txt_ad.MaxLength = 30;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(150, 23);
            this.txt_ad.TabIndex = 4;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
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
            // txt_adres
            // 
            this.txt_adres.ContextMenuStrip = this.coms_text;
            this.txt_adres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(125, 81);
            this.txt_adres.MaxLength = 200;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(150, 23);
            this.txt_adres.TabIndex = 5;
            this.txt_adres.TextChanged += new System.EventHandler(this.txt_adres_TextChanged);
            // 
            // txt_tel
            // 
            this.txt_tel.ContextMenuStrip = this.coms_text;
            this.txt_tel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(125, 110);
            this.txt_tel.MaxLength = 11;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(150, 23);
            this.txt_tel.TabIndex = 6;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // txt_mail
            // 
            this.txt_mail.ContextMenuStrip = this.coms_text;
            this.txt_mail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(125, 139);
            this.txt_mail.MaxLength = 40;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(150, 23);
            this.txt_mail.TabIndex = 7;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(478, 5);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(191, 32);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Tedarikçi Ekle";
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
            this.btn_guncelle.Location = new System.Drawing.Point(478, 137);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(191, 32);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "     Tedarikçi Güncelle";
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
            this.btn_listele.Location = new System.Drawing.Point(478, 93);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(191, 32);
            this.btn_listele.TabIndex = 11;
            this.btn_listele.Text = "Tedarikçi Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.Location = new System.Drawing.Point(478, 181);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(191, 32);
            this.btn_ara.TabIndex = 13;
            this.btn_ara.Text = "Tedarikçi Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.ForeColor = System.Drawing.Color.White;
            this.lbl_ara.Location = new System.Drawing.Point(12, 173);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(96, 20);
            this.lbl_ara.TabIndex = 15;
            this.lbl_ara.Text = "Tedarikçi Ara:";
            // 
            // cmbx_ara
            // 
            this.cmbx_ara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_ara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_ara.FormattingEnabled = true;
            this.cmbx_ara.Items.AddRange(new object[] {
            "Seçiniz",
            "No\'ya Göre Ara",
            "Ada Göre Ara"});
            this.cmbx_ara.Location = new System.Drawing.Point(125, 168);
            this.cmbx_ara.Name = "cmbx_ara";
            this.cmbx_ara.Size = new System.Drawing.Size(150, 25);
            this.cmbx_ara.TabIndex = 8;
            this.cmbx_ara.SelectedIndexChanged += new System.EventHandler(this.cmbx_ara_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tNoDataGridViewTextBoxColumn,
            this.tAdDataGridViewTextBoxColumn,
            this.tAdresDataGridViewTextBoxColumn,
            this.tTelDataGridViewTextBoxColumn,
            this.tMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBL_TEDARIKCILERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(669, 212);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tNoDataGridViewTextBoxColumn
            // 
            this.tNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tNoDataGridViewTextBoxColumn.DataPropertyName = "T_No";
            this.tNoDataGridViewTextBoxColumn.HeaderText = "Tedarikçi No";
            this.tNoDataGridViewTextBoxColumn.Name = "tNoDataGridViewTextBoxColumn";
            this.tNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAdDataGridViewTextBoxColumn
            // 
            this.tAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tAdDataGridViewTextBoxColumn.DataPropertyName = "T_Ad";
            this.tAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.tAdDataGridViewTextBoxColumn.Name = "tAdDataGridViewTextBoxColumn";
            this.tAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAdresDataGridViewTextBoxColumn
            // 
            this.tAdresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tAdresDataGridViewTextBoxColumn.DataPropertyName = "T_Adres";
            this.tAdresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.tAdresDataGridViewTextBoxColumn.Name = "tAdresDataGridViewTextBoxColumn";
            this.tAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tTelDataGridViewTextBoxColumn
            // 
            this.tTelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tTelDataGridViewTextBoxColumn.DataPropertyName = "T_Tel";
            this.tTelDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.tTelDataGridViewTextBoxColumn.Name = "tTelDataGridViewTextBoxColumn";
            this.tTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tMailDataGridViewTextBoxColumn
            // 
            this.tMailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tMailDataGridViewTextBoxColumn.DataPropertyName = "T_Mail";
            this.tMailDataGridViewTextBoxColumn.HeaderText = "Mail Adresi";
            this.tMailDataGridViewTextBoxColumn.Name = "tMailDataGridViewTextBoxColumn";
            this.tMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBL_TEDARIKCILERBindingSource
            // 
            this.tBL_TEDARIKCILERBindingSource.DataMember = "TBL_TEDARIKCILER";
            this.tBL_TEDARIKCILERBindingSource.DataSource = this.ilkOtomasyonDataSet;
            // 
            // ilkOtomasyonDataSet
            // 
            this.ilkOtomasyonDataSet.DataSetName = "IlkOtomasyonDataSet";
            this.ilkOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_islem
            // 
            this.pnl_islem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.pnl_islem.ContextMenuStrip = this.coms_form;
            this.pnl_islem.Controls.Add(this.dataGridView1);
            this.pnl_islem.Controls.Add(this.btn_sifirla);
            this.pnl_islem.Controls.Add(this.txt_adres);
            this.pnl_islem.Controls.Add(this.btn_guncelle);
            this.pnl_islem.Controls.Add(this.btn_ara);
            this.pnl_islem.Controls.Add(this.txt_no);
            this.pnl_islem.Controls.Add(this.lbl_adres);
            this.pnl_islem.Controls.Add(this.lbl_no);
            this.pnl_islem.Controls.Add(this.btn_sil);
            this.pnl_islem.Controls.Add(this.lbl_mail);
            this.pnl_islem.Controls.Add(this.txt_mail);
            this.pnl_islem.Controls.Add(this.cmbx_ara);
            this.pnl_islem.Controls.Add(this.lbl_tel);
            this.pnl_islem.Controls.Add(this.btn_ekle);
            this.pnl_islem.Controls.Add(this.lbl_ara);
            this.pnl_islem.Controls.Add(this.lbl_ad);
            this.pnl_islem.Controls.Add(this.txt_ad);
            this.pnl_islem.Controls.Add(this.btn_listele);
            this.pnl_islem.Controls.Add(this.txt_tel);
            this.pnl_islem.Location = new System.Drawing.Point(-3, 40);
            this.pnl_islem.Name = "pnl_islem";
            this.pnl_islem.Size = new System.Drawing.Size(692, 452);
            this.pnl_islem.TabIndex = 20;
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
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifirla.FlatAppearance.BorderSize = 0;
            this.btn_sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifirla.Image = ((System.Drawing.Image)(resources.GetObject("btn_sifirla.Image")));
            this.btn_sifirla.Location = new System.Drawing.Point(261, 4);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sifirla.Size = new System.Drawing.Size(13, 16);
            this.btn_sifirla.TabIndex = 2;
            this.btn_sifirla.UseVisualStyleBackColor = true;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click_1);
            // 
            // txt_no
            // 
            this.txt_no.ContextMenuStrip = this.coms_text;
            this.txt_no.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_no.Location = new System.Drawing.Point(125, 23);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(150, 23);
            this.txt_no.TabIndex = 3;
            this.txt_no.TextChanged += new System.EventHandler(this.txt_no_TextChanged);
            this.txt_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_KeyPress);
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_no.ForeColor = System.Drawing.Color.White;
            this.lbl_no.Location = new System.Drawing.Point(12, 22);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(92, 20);
            this.lbl_no.TabIndex = 0;
            this.lbl_no.Text = "Tedarikçi No:";
            // 
            // btn_sil
            // 
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(478, 49);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(191, 32);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Tedarikçi Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // sgmt_tedarikciler
            // 
            this.sgmt_tedarikciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.sgmt_tedarikciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sgmt_tedarikciler.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sgmt_tedarikciler.Items = "İşlemler, İstatistikler";
            this.sgmt_tedarikciler.Location = new System.Drawing.Point(-3, -2);
            this.sgmt_tedarikciler.Name = "sgmt_tedarikciler";
            this.sgmt_tedarikciler.SegmentActiveTextColor = System.Drawing.Color.White;
            this.sgmt_tedarikciler.SegmentBackColor = System.Drawing.Color.Transparent;
            this.sgmt_tedarikciler.SegmentColor = System.Drawing.Color.White;
            this.sgmt_tedarikciler.SegmentInactiveTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.sgmt_tedarikciler.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.sgmt_tedarikciler.SelectedIndex = 0;
            this.sgmt_tedarikciler.Size = new System.Drawing.Size(677, 41);
            this.sgmt_tedarikciler.TabIndex = 1;
            this.sgmt_tedarikciler.IndexChanged += new System.EventHandler(this.sgmt_tedarikciler_IndexChanged);
            // 
            // pnl_istatistik
            // 
            this.pnl_istatistik.Controls.Add(this.chart1);
            this.pnl_istatistik.Controls.Add(this.lbl_aded);
            this.pnl_istatistik.Location = new System.Drawing.Point(691, 40);
            this.pnl_istatistik.Name = "pnl_istatistik";
            this.pnl_istatistik.Size = new System.Drawing.Size(672, 435);
            this.pnl_istatistik.TabIndex = 21;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 60);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(233, 163);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            // 
            // lbl_aded
            // 
            this.lbl_aded.AutoSize = true;
            this.lbl_aded.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aded.ForeColor = System.Drawing.Color.White;
            this.lbl_aded.Location = new System.Drawing.Point(3, 37);
            this.lbl_aded.Name = "lbl_aded";
            this.lbl_aded.Size = new System.Drawing.Size(226, 20);
            this.lbl_aded.TabIndex = 37;
            this.lbl_aded.Text = "Mağazada Kayıtlı Tedarikçi Sayısı:";
            // 
            // pnl_ayrac
            // 
            this.pnl_ayrac.BackColor = System.Drawing.Color.White;
            this.pnl_ayrac.Location = new System.Drawing.Point(335, -2);
            this.pnl_ayrac.Name = "pnl_ayrac";
            this.pnl_ayrac.Size = new System.Drawing.Size(3, 41);
            this.pnl_ayrac.TabIndex = 20;
            // 
            // error_no
            // 
            this.error_no.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_no.ContainerControl = this;
            // 
            // error_ad
            // 
            this.error_ad.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_ad.ContainerControl = this;
            // 
            // error_adres
            // 
            this.error_adres.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_adres.ContainerControl = this;
            // 
            // tBL_TEDARIKCILERTableAdapter
            // 
            this.tBL_TEDARIKCILERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Siparis_Urun_DetayTableAdapter = null;
            this.tableAdapterManager.TBL_KATEGORITableAdapter = null;
            this.tableAdapterManager.TBL_MUSTERİTableAdapter = null;
            this.tableAdapterManager.TBL_SIPARISTableAdapter = null;
            this.tableAdapterManager.TBL_TEDARIKCILERTableAdapter = this.tBL_TEDARIKCILERTableAdapter;
            this.tableAdapterManager.TBL_URUNTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(94)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(677, 478);
            this.ContextMenuStrip = this.coms_form;
            this.Controls.Add(this.pnl_ayrac);
            this.Controls.Add(this.pnl_istatistik);
            this.Controls.Add(this.sgmt_tedarikciler);
            this.Controls.Add(this.pnl_islem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_tedarikciler";
            this.Text = "Tedarikçiler";
            this.Load += new System.EventHandler(this.frm_tedarikciler_Load);
            this.coms_text.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TEDARIKCILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkOtomasyonDataSet)).EndInit();
            this.pnl_islem.ResumeLayout(false);
            this.pnl_islem.PerformLayout();
            this.coms_form.ResumeLayout(false);
            this.pnl_istatistik.ResumeLayout(false);
            this.pnl_istatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_adres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.ComboBox cmbx_ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_islem;
        private XanderUI.XUISegment sgmt_tedarikciler;
        private System.Windows.Forms.Panel pnl_istatistik;
        private System.Windows.Forms.Button btn_sifirla;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ContextMenuStrip coms_form;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_ayrac;
        private System.Windows.Forms.ContextMenuStrip coms_text;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tumunusectoolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_aded;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ErrorProvider error_no;
        private System.Windows.Forms.ErrorProvider error_ad;
        private System.Windows.Forms.ErrorProvider error_adres;
        private System.Windows.Forms.BindingSource tBL_TEDARIKCILERBindingSource;
        private WindowsFormsApp3.IlkOtomasyonDataSet ilkOtomasyonDataSet;
        private WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TBL_TEDARIKCILERTableAdapter tBL_TEDARIKCILERTableAdapter;
        private WindowsFormsApp3.IlkOtomasyonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMailDataGridViewTextBoxColumn;
    }
}