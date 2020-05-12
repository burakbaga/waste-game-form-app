namespace ndpodev
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yeni_oyun = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.organik_bosalt = new System.Windows.Forms.Button();
            this.organik_btn = new System.Windows.Forms.Button();
            this.kagit_btn = new System.Windows.Forms.Button();
            this.kagit_bosalt = new System.Windows.Forms.Button();
            this.cam_btn = new System.Windows.Forms.Button();
            this.cam_bosalt = new System.Windows.Forms.Button();
            this.metal_btn = new System.Windows.Forms.Button();
            this.metal_bosalt = new System.Windows.Forms.Button();
            this.puan = new System.Windows.Forms.TextBox();
            this.organik_progress = new System.Windows.Forms.ProgressBar();
            this.kagit_progress = new System.Windows.Forms.ProgressBar();
            this.cam_progress = new System.Windows.Forms.ProgressBar();
            this.metal_progress = new System.Windows.Forms.ProgressBar();
            this.organik_list = new System.Windows.Forms.ListBox();
            this.kagit_list = new System.Windows.Forms.ListBox();
            this.cam_list = new System.Windows.Forms.ListBox();
            this.metal_list = new System.Windows.Forms.ListBox();
            this.sure = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SÜRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "PUAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Atık Kutuları";
            // 
            // yeni_oyun
            // 
            this.yeni_oyun.Location = new System.Drawing.Point(13, 169);
            this.yeni_oyun.Name = "yeni_oyun";
            this.yeni_oyun.Size = new System.Drawing.Size(140, 40);
            this.yeni_oyun.TabIndex = 9;
            this.yeni_oyun.Text = "YENİ OYUN";
            this.yeni_oyun.UseVisualStyleBackColor = true;
            this.yeni_oyun.Click += new System.EventHandler(this.yeni_oyun_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(13, 375);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(140, 40);
            this.cikis.TabIndex = 10;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // organik_bosalt
            // 
            this.organik_bosalt.Location = new System.Drawing.Point(354, 207);
            this.organik_bosalt.Name = "organik_bosalt";
            this.organik_bosalt.Size = new System.Drawing.Size(121, 30);
            this.organik_bosalt.TabIndex = 11;
            this.organik_bosalt.Text = "BOŞALT";
            this.organik_bosalt.UseVisualStyleBackColor = true;
            this.organik_bosalt.Click += new System.EventHandler(this.organik_bosalt_Click);
            // 
            // organik_btn
            // 
            this.organik_btn.Location = new System.Drawing.Point(353, 43);
            this.organik_btn.Name = "organik_btn";
            this.organik_btn.Size = new System.Drawing.Size(121, 30);
            this.organik_btn.TabIndex = 12;
            this.organik_btn.Text = "ORGANİK ATIK";
            this.organik_btn.UseVisualStyleBackColor = true;
            this.organik_btn.Click += new System.EventHandler(this.organik_btn_Click);
            // 
            // kagit_btn
            // 
            this.kagit_btn.Location = new System.Drawing.Point(538, 43);
            this.kagit_btn.Name = "kagit_btn";
            this.kagit_btn.Size = new System.Drawing.Size(121, 30);
            this.kagit_btn.TabIndex = 15;
            this.kagit_btn.Text = "KAĞIT";
            this.kagit_btn.UseVisualStyleBackColor = true;
            this.kagit_btn.Click += new System.EventHandler(this.kagit_btn_Click);
            // 
            // kagit_bosalt
            // 
            this.kagit_bosalt.Location = new System.Drawing.Point(538, 207);
            this.kagit_bosalt.Name = "kagit_bosalt";
            this.kagit_bosalt.Size = new System.Drawing.Size(121, 30);
            this.kagit_bosalt.TabIndex = 14;
            this.kagit_bosalt.Text = "BOŞALT";
            this.kagit_bosalt.UseVisualStyleBackColor = true;
            this.kagit_bosalt.Click += new System.EventHandler(this.kagit_bosalt_Click);
            // 
            // cam_btn
            // 
            this.cam_btn.Location = new System.Drawing.Point(354, 243);
            this.cam_btn.Name = "cam_btn";
            this.cam_btn.Size = new System.Drawing.Size(121, 30);
            this.cam_btn.TabIndex = 18;
            this.cam_btn.Text = "CAM";
            this.cam_btn.UseVisualStyleBackColor = true;
            this.cam_btn.Click += new System.EventHandler(this.cam_btn_Click);
            // 
            // cam_bosalt
            // 
            this.cam_bosalt.Location = new System.Drawing.Point(354, 408);
            this.cam_bosalt.Name = "cam_bosalt";
            this.cam_bosalt.Size = new System.Drawing.Size(121, 30);
            this.cam_bosalt.TabIndex = 17;
            this.cam_bosalt.Text = "BOŞALT";
            this.cam_bosalt.UseVisualStyleBackColor = true;
            this.cam_bosalt.Click += new System.EventHandler(this.cam_bosalt_Click);
            // 
            // metal_btn
            // 
            this.metal_btn.Location = new System.Drawing.Point(538, 243);
            this.metal_btn.Name = "metal_btn";
            this.metal_btn.Size = new System.Drawing.Size(121, 30);
            this.metal_btn.TabIndex = 21;
            this.metal_btn.Text = "METAL";
            this.metal_btn.UseVisualStyleBackColor = true;
            this.metal_btn.Click += new System.EventHandler(this.metal_btn_Click);
            // 
            // metal_bosalt
            // 
            this.metal_bosalt.Location = new System.Drawing.Point(538, 408);
            this.metal_bosalt.Name = "metal_bosalt";
            this.metal_bosalt.Size = new System.Drawing.Size(121, 30);
            this.metal_bosalt.TabIndex = 20;
            this.metal_bosalt.Text = "BOŞALT";
            this.metal_bosalt.UseVisualStyleBackColor = true;
            this.metal_bosalt.Click += new System.EventHandler(this.metal_bosalt_Click);
            // 
            // puan
            // 
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.Location = new System.Drawing.Point(32, 316);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(100, 45);
            this.puan.TabIndex = 27;
            this.puan.Text = "0";
            this.puan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // organik_progress
            // 
            this.organik_progress.Location = new System.Drawing.Point(354, 178);
            this.organik_progress.Name = "organik_progress";
            this.organik_progress.Size = new System.Drawing.Size(121, 23);
            this.organik_progress.TabIndex = 28;
            // 
            // kagit_progress
            // 
            this.kagit_progress.Location = new System.Drawing.Point(538, 178);
            this.kagit_progress.Name = "kagit_progress";
            this.kagit_progress.Size = new System.Drawing.Size(121, 23);
            this.kagit_progress.TabIndex = 29;
            // 
            // cam_progress
            // 
            this.cam_progress.Location = new System.Drawing.Point(354, 379);
            this.cam_progress.Name = "cam_progress";
            this.cam_progress.Size = new System.Drawing.Size(121, 23);
            this.cam_progress.TabIndex = 30;
            // 
            // metal_progress
            // 
            this.metal_progress.Location = new System.Drawing.Point(538, 379);
            this.metal_progress.Name = "metal_progress";
            this.metal_progress.Size = new System.Drawing.Size(121, 23);
            this.metal_progress.TabIndex = 31;
            // 
            // organik_list
            // 
            this.organik_list.FormattingEnabled = true;
            this.organik_list.ItemHeight = 16;
            this.organik_list.Location = new System.Drawing.Point(354, 79);
            this.organik_list.Name = "organik_list";
            this.organik_list.Size = new System.Drawing.Size(120, 100);
            this.organik_list.TabIndex = 32;
            // 
            // kagit_list
            // 
            this.kagit_list.FormattingEnabled = true;
            this.kagit_list.ItemHeight = 16;
            this.kagit_list.Location = new System.Drawing.Point(539, 79);
            this.kagit_list.Name = "kagit_list";
            this.kagit_list.Size = new System.Drawing.Size(120, 100);
            this.kagit_list.TabIndex = 33;
            // 
            // cam_list
            // 
            this.cam_list.FormattingEnabled = true;
            this.cam_list.ItemHeight = 16;
            this.cam_list.Location = new System.Drawing.Point(355, 273);
            this.cam_list.Name = "cam_list";
            this.cam_list.Size = new System.Drawing.Size(120, 100);
            this.cam_list.TabIndex = 34;
            // 
            // metal_list
            // 
            this.metal_list.FormattingEnabled = true;
            this.metal_list.ItemHeight = 16;
            this.metal_list.Location = new System.Drawing.Point(539, 273);
            this.metal_list.Name = "metal_list";
            this.metal_list.Size = new System.Drawing.Size(120, 100);
            this.metal_list.TabIndex = 35;
            // 
            // sure
            // 
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.Location = new System.Drawing.Point(32, 240);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(100, 45);
            this.sure.TabIndex = 36;
            this.sure.Text = "60";
            this.sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.metal_list);
            this.Controls.Add(this.cam_list);
            this.Controls.Add(this.kagit_list);
            this.Controls.Add(this.organik_list);
            this.Controls.Add(this.metal_progress);
            this.Controls.Add(this.cam_progress);
            this.Controls.Add(this.kagit_progress);
            this.Controls.Add(this.organik_progress);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.metal_btn);
            this.Controls.Add(this.metal_bosalt);
            this.Controls.Add(this.cam_btn);
            this.Controls.Add(this.cam_bosalt);
            this.Controls.Add(this.kagit_btn);
            this.Controls.Add(this.kagit_bosalt);
            this.Controls.Add(this.organik_btn);
            this.Controls.Add(this.organik_bosalt);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.yeni_oyun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yeni_oyun;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button organik_bosalt;
        private System.Windows.Forms.Button organik_btn;
        private System.Windows.Forms.Button kagit_btn;
        private System.Windows.Forms.Button kagit_bosalt;
        private System.Windows.Forms.Button cam_btn;
        private System.Windows.Forms.Button cam_bosalt;
        private System.Windows.Forms.Button metal_btn;
        private System.Windows.Forms.Button metal_bosalt;
        private System.Windows.Forms.TextBox puan;
        private System.Windows.Forms.ProgressBar organik_progress;
        private System.Windows.Forms.ProgressBar kagit_progress;
        private System.Windows.Forms.ProgressBar cam_progress;
        private System.Windows.Forms.ProgressBar metal_progress;
        private System.Windows.Forms.ListBox organik_list;
        private System.Windows.Forms.ListBox kagit_list;
        private System.Windows.Forms.ListBox cam_list;
        private System.Windows.Forms.ListBox metal_list;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.Timer timer2;
    }
}

