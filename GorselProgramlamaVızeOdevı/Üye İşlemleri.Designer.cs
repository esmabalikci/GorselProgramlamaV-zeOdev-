namespace GorselProgramlamaVızeOdevı
{
    partial class UyeIslemleri1
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
            KullanıcıAd = new Label();
            KullanıcıSoyad = new Label();
            Cınsıyet = new Label();
            TC = new Label();
            TelNo = new Label();
            Maıl = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            Kadın = new RadioButton();
            Erkek = new RadioButton();
            UyeEkle = new Button();
            Guncelleme = new Button();
            UyeSıl = new Button();
            kullanıcıTablosu = new DataGridView();
            uyedosyayakaydet = new Button();
            button1 = new Button();
            uyedosyadanoku = new Button();
            ((System.ComponentModel.ISupportInitialize)kullanıcıTablosu).BeginInit();
            SuspendLayout();
            // 
            // KullanıcıAd
            // 
            KullanıcıAd.AutoSize = true;
            KullanıcıAd.BackColor = Color.Moccasin;
            KullanıcıAd.Location = new Point(44, 22);
            KullanıcıAd.Name = "KullanıcıAd";
            KullanıcıAd.Size = new Size(92, 20);
            KullanıcıAd.TabIndex = 0;
            KullanıcıAd.Text = "Kullanıcı Adı";
            KullanıcıAd.Click += KullanıcıAd_Click;
            // 
            // KullanıcıSoyad
            // 
            KullanıcıSoyad.AutoSize = true;
            KullanıcıSoyad.BackColor = Color.Moccasin;
            KullanıcıSoyad.Location = new Point(26, 77);
            KullanıcıSoyad.Name = "KullanıcıSoyad";
            KullanıcıSoyad.Size = new Size(110, 20);
            KullanıcıSoyad.TabIndex = 1;
            KullanıcıSoyad.Text = "Kullanıcı Soyad";
            KullanıcıSoyad.Click += KullanıcıSoyad_Click;
            // 
            // Cınsıyet
            // 
            Cınsıyet.AutoSize = true;
            Cınsıyet.BackColor = Color.Moccasin;
            Cınsıyet.Location = new Point(76, 122);
            Cınsıyet.Name = "Cınsıyet";
            Cınsıyet.Size = new Size(60, 20);
            Cınsıyet.TabIndex = 2;
            Cınsıyet.Text = "Cinsiyet";
            // 
            // TC
            // 
            TC.AutoSize = true;
            TC.BackColor = Color.Moccasin;
            TC.Location = new Point(104, 175);
            TC.Name = "TC";
            TC.Size = new Size(32, 20);
            TC.TabIndex = 3;
            TC.Text = "T.C.";
            // 
            // TelNo
            // 
            TelNo.AutoSize = true;
            TelNo.BackColor = Color.Moccasin;
            TelNo.Location = new Point(85, 220);
            TelNo.Name = "TelNo";
            TelNo.Size = new Size(51, 20);
            TelNo.TabIndex = 4;
            TelNo.Text = "Tel.No";
            TelNo.Click += label5_Click;
            // 
            // Maıl
            // 
            Maıl.AutoSize = true;
            Maıl.BackColor = Color.Moccasin;
            Maıl.Location = new Point(98, 263);
            Maıl.Name = "Maıl";
            Maıl.Size = new Size(38, 20);
            Maıl.TabIndex = 5;
            Maıl.Text = "Mail";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(151, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(151, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(151, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(151, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Location = new Point(151, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 27);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Kadın
            // 
            Kadın.AutoSize = true;
            Kadın.BackColor = Color.White;
            Kadın.Location = new Point(151, 120);
            Kadın.Name = "Kadın";
            Kadın.Size = new Size(68, 24);
            Kadın.TabIndex = 13;
            Kadın.TabStop = true;
            Kadın.Text = "Kadın";
            Kadın.UseVisualStyleBackColor = false;
            // 
            // Erkek
            // 
            Erkek.AutoSize = true;
            Erkek.BackColor = Color.White;
            Erkek.Location = new Point(268, 118);
            Erkek.Name = "Erkek";
            Erkek.Size = new Size(65, 24);
            Erkek.TabIndex = 14;
            Erkek.TabStop = true;
            Erkek.Text = "Erkek";
            Erkek.UseVisualStyleBackColor = false;
            // 
            // UyeEkle
            // 
            UyeEkle.BackColor = Color.Pink;
            UyeEkle.Cursor = Cursors.Help;
            UyeEkle.Location = new Point(26, 333);
            UyeEkle.Name = "UyeEkle";
            UyeEkle.Size = new Size(94, 29);
            UyeEkle.TabIndex = 15;
            UyeEkle.Text = "Üye Ekle";
            UyeEkle.UseVisualStyleBackColor = false;
            UyeEkle.Click += UyeEkle_Click;
            // 
            // Guncelleme
            // 
            Guncelleme.BackColor = Color.Pink;
            Guncelleme.Location = new Point(151, 333);
            Guncelleme.Name = "Guncelleme";
            Guncelleme.Size = new Size(103, 29);
            Guncelleme.TabIndex = 16;
            Guncelleme.Text = "Güncelle";
            Guncelleme.UseVisualStyleBackColor = false;
            Guncelleme.Click += button2_Click;
            // 
            // UyeSıl
            // 
            UyeSıl.BackColor = Color.Pink;
            UyeSıl.Location = new Point(273, 333);
            UyeSıl.Name = "UyeSıl";
            UyeSıl.Size = new Size(94, 29);
            UyeSıl.TabIndex = 17;
            UyeSıl.Text = "Üye Sil";
            UyeSıl.UseVisualStyleBackColor = false;
            // 
            // kullanıcıTablosu
            // 
            kullanıcıTablosu.BackgroundColor = Color.White;
            kullanıcıTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kullanıcıTablosu.Location = new Point(373, 22);
            kullanıcıTablosu.Name = "kullanıcıTablosu";
            kullanıcıTablosu.RowHeadersWidth = 51;
            kullanıcıTablosu.Size = new Size(398, 340);
            kullanıcıTablosu.TabIndex = 18;
            // 
            // uyedosyayakaydet
            // 
            uyedosyayakaydet.BackColor = Color.Pink;
            uyedosyayakaydet.Cursor = Cursors.Help;
            uyedosyayakaydet.Location = new Point(26, 392);
            uyedosyayakaydet.Name = "uyedosyayakaydet";
            uyedosyayakaydet.Size = new Size(193, 29);
            uyedosyayakaydet.TabIndex = 15;
            uyedosyayakaydet.Text = "Dosyaya Kaydet";
            uyedosyayakaydet.UseVisualStyleBackColor = false;
            uyedosyayakaydet.Click += UyeEkle_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Cursor = Cursors.Help;
            button1.Location = new Point(61, 448);
            button1.Name = "button1";
            button1.Size = new Size(193, 29);
            button1.TabIndex = 15;
            button1.Text = "Dosyaya Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += UyeEkle_Click;
            // 
            // uyedosyadanoku
            // 
            uyedosyadanoku.BackColor = Color.Pink;
            uyedosyadanoku.Location = new Point(258, 392);
            uyedosyadanoku.Name = "uyedosyadanoku";
            uyedosyadanoku.Size = new Size(166, 29);
            uyedosyadanoku.TabIndex = 16;
            uyedosyadanoku.Text = "Dosyadan Oku";
            uyedosyadanoku.UseVisualStyleBackColor = false;
            uyedosyadanoku.Click += button2_Click;
            // 
            // UyeIslemleri1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(kullanıcıTablosu);
            Controls.Add(UyeSıl);
            Controls.Add(uyedosyadanoku);
            Controls.Add(Guncelleme);
            Controls.Add(button1);
            Controls.Add(uyedosyayakaydet);
            Controls.Add(UyeEkle);
            Controls.Add(Erkek);
            Controls.Add(Kadın);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Maıl);
            Controls.Add(TelNo);
            Controls.Add(TC);
            Controls.Add(Cınsıyet);
            Controls.Add(KullanıcıSoyad);
            Controls.Add(KullanıcıAd);
            Name = "UyeIslemleri1";
            Text = "Üye İşlemleri";
            Load += UyeIslemleri1_Load;
            ((System.ComponentModel.ISupportInitialize)kullanıcıTablosu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KullanıcıAd;
        private Label KullanıcıSoyad;
        private Label Cınsıyet;
        private Label TC;
        private Label TelNo;
        private Label Maıl;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton Kadın;
        private RadioButton Erkek;
        private Button UyeEkle;
        private Button Guncelleme;
        private Button UyeSıl;
        private DataGridView dataGridView1;
        private DataGridView kullanıcıTablosu;
        private Button button1;
        private Button uyedosyayakaydet;
        private Button button2;
        private Button uyedosyadanoku;
    }
}