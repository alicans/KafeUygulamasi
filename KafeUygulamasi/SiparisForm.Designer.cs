namespace KafeUygulamasi
{
    partial class SiparisForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            btnDetayEkle = new Button();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            nudAdet = new NumericUpDown();
            cmbUrun = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            lblOdemeTutari = new Label();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnaSayfa = new Button();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 12;
            label1.Text = "Ürün";
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetayEkle.Location = new Point(422, 36);
            btnDetayEkle.Margin = new Padding(6, 5, 6, 5);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(98, 31);
            btnDetayEkle.TabIndex = 2;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            btnDetayEkle.Click += btnDetayEkle_Click;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dgvDetaylar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dgvDetaylar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(15, 77);
            dgvDetaylar.Margin = new Padding(6, 5, 6, 5);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(505, 393);
            dgvDetaylar.TabIndex = 8;
            dgvDetaylar.KeyDown += dgvDetaylar_KeyDown;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün Adı";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle6.Format = "c2";
            Column2.DefaultCellStyle = dataGridViewCellStyle6;
            Column2.HeaderText = "Birim Fiyatı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // nudAdet
            // 
            nudAdet.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAdet.Location = new Point(288, 37);
            nudAdet.Margin = new Padding(7, 6, 7, 6);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(129, 31);
            nudAdet.TabIndex = 1;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbUrun
            // 
            cmbUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrun.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(15, 37);
            cmbUrun.Margin = new Padding(6, 5, 6, 5);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(267, 31);
            cmbUrun.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(541, 286);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 10;
            label2.Text = "Ödeme Tutarı:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(585, 9);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 14;
            label3.Text = "Masa No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(288, 9);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 13;
            label4.Text = "Adet";
            // 
            // cmbMasaNo
            // 
            cmbMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMasaNo.FormattingEnabled = true;
            cmbMasaNo.Location = new Point(585, 37);
            cmbMasaNo.Name = "cmbMasaNo";
            cmbMasaNo.Size = new Size(121, 31);
            cmbMasaNo.TabIndex = 3;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaTasi.Location = new Point(715, 37);
            btnMasaTasi.Margin = new Padding(6, 5, 6, 5);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(98, 31);
            btnMasaTasi.TabIndex = 4;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(686, 286);
            lblOdemeTutari.Margin = new Padding(6, 0, 6, 0);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(65, 23);
            lblOdemeTutari.TabIndex = 11;
            lblOdemeTutari.Text = "₺0,00";
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.BackColor = Color.DarkRed;
            btnSiparisIptal.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisIptal.ForeColor = SystemColors.Control;
            btnSiparisIptal.Location = new Point(541, 318);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(133, 78);
            btnSiparisIptal.TabIndex = 5;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = false;
            btnSiparisIptal.Click += btnSiparisIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.ForestGreen;
            btnOdemeAl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = SystemColors.Control;
            btnOdemeAl.Location = new Point(680, 318);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(133, 78);
            btnOdemeAl.TabIndex = 6;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnaSayfa.BackColor = Color.DarkGoldenrod;
            btnAnaSayfa.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnaSayfa.ForeColor = SystemColors.Control;
            btnAnaSayfa.Location = new Point(541, 402);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(273, 68);
            btnAnaSayfa.TabIndex = 7;
            btnAnaSayfa.Text = "ANASAYFAYA DÖN";
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Verdana", 50F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.ButtonHighlight;
            lblMasaNo.Location = new Point(541, 77);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(272, 200);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.Text = "03";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 482);
            Controls.Add(lblMasaNo);
            Controls.Add(btnAnaSayfa);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(lblOdemeTutari);
            Controls.Add(btnMasaTasi);
            Controls.Add(cmbMasaNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbUrun);
            Controls.Add(nudAdet);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayEkle);
            Controls.Add(label1);
            Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            MinimumSize = new Size(781, 507);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDetayEkle;
        private DataGridView dgvDetaylar;
        private NumericUpDown nudAdet;
        private ComboBox cmbUrun;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbMasaNo;
        private Button btnMasaTasi;
        private Label lblOdemeTutari;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnaSayfa;
        private Label lblMasaNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}