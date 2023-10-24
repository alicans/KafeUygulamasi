namespace KafeUygulamasi
{
    partial class UrunlerForm
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
            txtUrunAd = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            nudBirimFiyat = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(15, 37);
            txtUrunAd.Margin = new Padding(6, 5, 6, 5);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(232, 31);
            txtUrunAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 4;
            label1.Text = "Ürün Adı";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(405, 37);
            btnEkle.Margin = new Padding(6, 5, 6, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(119, 31);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(15, 82);
            dgvUrunler.Margin = new Padding(6, 5, 6, 5);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(509, 387);
            dgvUrunler.TabIndex = 3;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.DecimalPlaces = 2;
            nudBirimFiyat.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudBirimFiyat.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudBirimFiyat.Location = new Point(252, 37);
            nudBirimFiyat.Margin = new Padding(11, 8, 11, 8);
            nudBirimFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBirimFiyat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(148, 31);
            nudBirimFiyat.TabIndex = 1;
            nudBirimFiyat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(246, 9);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 5;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 479);
            Controls.Add(label2);
            Controls.Add(nudBirimFiyat);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(txtUrunAd);
            Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAd;
        private Label label1;
        private Button btnEkle;
        private DataGridView dgvUrunler;
        private NumericUpDown nudBirimFiyat;
        private Label label2;
    }
}