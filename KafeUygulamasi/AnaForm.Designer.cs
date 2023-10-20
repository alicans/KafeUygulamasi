namespace KafeUygulamasi
{
    partial class AnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            menuStrip1 = new MenuStrip();
            tsmiUrunler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            lvwMasalar = new ListView();
            ilMasalar = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(666, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            tsmiUrunler.Name = "tsmiUrunler";
            tsmiUrunler.Size = new Size(58, 19);
            tsmiUrunler.Text = "Ürünler";
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(108, 19);
            tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            // 
            // lvwMasalar
            // 
            lvwMasalar.Dock = DockStyle.Fill;
            lvwMasalar.LargeImageList = ilMasalar;
            lvwMasalar.Location = new Point(0, 25);
            lvwMasalar.Margin = new Padding(5);
            lvwMasalar.Name = "lvwMasalar";
            lvwMasalar.Size = new Size(666, 403);
            lvwMasalar.TabIndex = 1;
            lvwMasalar.UseCompatibleStateImageBehavior = false;
            lvwMasalar.DoubleClick += lvwMasalar_DoubleClick;
            // 
            // ilMasalar
            // 
            ilMasalar.ColorDepth = ColorDepth.Depth8Bit;
            ilMasalar.ImageStream = (ImageListStreamer)resources.GetObject("ilMasalar.ImageStream");
            ilMasalar.TransparentColor = Color.Transparent;
            ilMasalar.Images.SetKeyName(0, "bos");
            ilMasalar.Images.SetKeyName(1, "dolu");
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 428);
            Controls.Add(lvwMasalar);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafe Otomasyonu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
        private ListView lvwMasalar;
        private ImageList ilMasalar;
    }
}