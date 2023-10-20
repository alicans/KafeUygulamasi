namespace KafeUygulamasi
{
    partial class GecmisSiparislerForm
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            dgvSiparisler = new DataGridView();
            label2 = new Label();
            dgvSiparisDetaylari = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylari).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dgvSiparisler);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(dgvSiparisDetaylari);
            splitContainer1.Size = new Size(672, 546);
            splitContainer1.SplitterDistance = 273;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(123, 29);
            label1.TabIndex = 1;
            label1.Text = "Siparişler";
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.AllowUserToAddRows = false;
            dgvSiparisler.AllowUserToDeleteRows = false;
            dgvSiparisler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiparisler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(3, 46);
            dgvSiparisler.MultiSelect = false;
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.ReadOnly = true;
            dgvSiparisler.RowHeadersVisible = false;
            dgvSiparisler.RowTemplate.Height = 25;
            dgvSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisler.Size = new Size(666, 224);
            dgvSiparisler.TabIndex = 0;
            dgvSiparisler.SelectionChanged += dgvSiparisler_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(207, 29);
            label2.TabIndex = 3;
            label2.Text = "Sipariş Detayları";
            // 
            // dgvSiparisDetaylari
            // 
            dgvSiparisDetaylari.AllowUserToAddRows = false;
            dgvSiparisDetaylari.AllowUserToDeleteRows = false;
            dgvSiparisDetaylari.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisDetaylari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiparisDetaylari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisDetaylari.Location = new Point(3, 40);
            dgvSiparisDetaylari.MultiSelect = false;
            dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            dgvSiparisDetaylari.ReadOnly = true;
            dgvSiparisDetaylari.RowHeadersVisible = false;
            dgvSiparisDetaylari.RowTemplate.Height = 25;
            dgvSiparisDetaylari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisDetaylari.Size = new Size(666, 219);
            dgvSiparisDetaylari.TabIndex = 2;
            // 
            // GecmisSiparislerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 546);
            Controls.Add(splitContainer1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "GecmisSiparislerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Geçmiş Siparişler";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylari).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private DataGridView dgvSiparisler;
        private Label label2;
        private DataGridView dgvSiparisDetaylari;
    }
}