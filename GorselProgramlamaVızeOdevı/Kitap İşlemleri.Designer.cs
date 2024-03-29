namespace GorselProgramlamaVızeOdevı
{
    partial class Kitap_İşlemleri
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
            KıtapAd = new Label();
            kitapAditxt = new TextBox();
            Ekle1 = new Button();
            Guncelle1 = new Button();
            Sıl1 = new Button();
            Yazar = new Label();
            kitapyazaritxt = new TextBox();
            KitaplarTablosu = new DataGridView();
            barkodnotxt = new Label();
            YayınEvı = new Label();
            TeslımTarıhı = new Label();
            textBox2 = new TextBox();
            yayınevitxt = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnDosyaKaydet = new Button();
            dosyadanOkubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)KitaplarTablosu).BeginInit();
            SuspendLayout();
            // 
            // KıtapAd
            // 
            KıtapAd.AutoSize = true;
            KıtapAd.BackColor = Color.Moccasin;
            KıtapAd.Location = new Point(29, 31);
            KıtapAd.Name = "KıtapAd";
            KıtapAd.Size = new Size(74, 20);
            KıtapAd.TabIndex = 0;
            KıtapAd.Text = "Kitap Adı:";
            // 
            // kitapAditxt
            // 
            kitapAditxt.Location = new Point(128, 24);
            kitapAditxt.Name = "kitapAditxt";
            kitapAditxt.Size = new Size(250, 27);
            kitapAditxt.TabIndex = 3;
            kitapAditxt.TextChanged += textBox1_TextChanged;
            // 
            // Ekle1
            // 
            Ekle1.BackColor = Color.Pink;
            Ekle1.Location = new Point(12, 311);
            Ekle1.Name = "Ekle1";
            Ekle1.Size = new Size(110, 41);
            Ekle1.TabIndex = 6;
            Ekle1.Text = "Ekle";
            Ekle1.UseVisualStyleBackColor = false;
            Ekle1.Click += button1_Click;
            // 
            // Guncelle1
            // 
            Guncelle1.BackColor = Color.Pink;
            Guncelle1.Location = new Point(164, 311);
            Guncelle1.Name = "Guncelle1";
            Guncelle1.Size = new Size(119, 41);
            Guncelle1.TabIndex = 7;
            Guncelle1.Text = "Güncelle";
            Guncelle1.UseVisualStyleBackColor = false;
            // 
            // Sıl1
            // 
            Sıl1.BackColor = Color.Pink;
            Sıl1.Location = new Point(310, 311);
            Sıl1.Name = "Sıl1";
            Sıl1.Size = new Size(121, 41);
            Sıl1.TabIndex = 8;
            Sıl1.Text = "Sil";
            Sıl1.UseVisualStyleBackColor = false;
            Sıl1.Click += button1_Click_1;
            // 
            // Yazar
            // 
            Yazar.BackColor = Color.Moccasin;
            Yazar.Location = new Point(29, 73);
            Yazar.Name = "Yazar";
            Yazar.Size = new Size(74, 25);
            Yazar.TabIndex = 9;
            Yazar.Text = "Yazar:";
            // 
            // kitapyazaritxt
            // 
            kitapyazaritxt.Location = new Point(128, 73);
            kitapyazaritxt.Name = "kitapyazaritxt";
            kitapyazaritxt.Size = new Size(250, 27);
            kitapyazaritxt.TabIndex = 10;
            // 
            // KitaplarTablosu
            // 
            KitaplarTablosu.BackgroundColor = Color.White;
            KitaplarTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KitaplarTablosu.Location = new Point(450, 12);
            KitaplarTablosu.Name = "KitaplarTablosu";
            KitaplarTablosu.RowHeadersWidth = 51;
            KitaplarTablosu.Size = new Size(338, 363);
            KitaplarTablosu.TabIndex = 11;
            // 
            // barkodnotxt
            // 
            barkodnotxt.AutoSize = true;
            barkodnotxt.BackColor = Color.Moccasin;
            barkodnotxt.Location = new Point(20, 125);
            barkodnotxt.Name = "barkodnotxt";
            barkodnotxt.Size = new Size(83, 20);
            barkodnotxt.TabIndex = 12;
            barkodnotxt.Text = "Barkod No:";
            barkodnotxt.Click += BarkodNo_Click;
            // 
            // YayınEvı
            // 
            YayınEvı.AutoSize = true;
            YayınEvı.BackColor = Color.Moccasin;
            YayınEvı.Location = new Point(38, 174);
            YayınEvı.Name = "YayınEvı";
            YayınEvı.Size = new Size(65, 20);
            YayınEvı.TabIndex = 13;
            YayınEvı.Text = "Yayınevi:";
            // 
            // TeslımTarıhı
            // 
            TeslımTarıhı.AutoSize = true;
            TeslımTarıhı.BackColor = Color.Moccasin;
            TeslımTarıhı.Location = new Point(10, 225);
            TeslımTarıhı.Name = "TeslımTarıhı";
            TeslımTarıhı.Size = new Size(93, 20);
            TeslımTarıhı.TabIndex = 14;
            TeslımTarıhı.Text = "Teslim Tarihi:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 15;
            // 
            // yayınevitxt
            // 
            yayınevitxt.Location = new Point(128, 171);
            yayınevitxt.Name = "yayınevitxt";
            yayınevitxt.Size = new Size(250, 27);
            yayınevitxt.TabIndex = 16;
            yayınevitxt.TextChanged += yayınevitxt_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(128, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // btnDosyaKaydet
            // 
            btnDosyaKaydet.BackColor = Color.Pink;
            btnDosyaKaydet.Location = new Point(20, 376);
            btnDosyaKaydet.Name = "btnDosyaKaydet";
            btnDosyaKaydet.Size = new Size(148, 29);
            btnDosyaKaydet.TabIndex = 18;
            btnDosyaKaydet.Text = "Dosyaya kaydet";
            btnDosyaKaydet.UseVisualStyleBackColor = false;
            btnDosyaKaydet.Click += btnDosyaKaydet_Click;
            // 
            // dosyadanOkubtn
            // 
            dosyadanOkubtn.BackColor = Color.Pink;
            dosyadanOkubtn.Location = new Point(199, 378);
            dosyadanOkubtn.Name = "dosyadanOkubtn";
            dosyadanOkubtn.Size = new Size(126, 29);
            dosyadanOkubtn.TabIndex = 19;
            dosyadanOkubtn.Text = "Dosyadan Oku";
            dosyadanOkubtn.UseVisualStyleBackColor = false;
            dosyadanOkubtn.Click += dosyadanOkubtn_Click;
            // 
            // Kitap_İşlemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(dosyadanOkubtn);
            Controls.Add(btnDosyaKaydet);
            Controls.Add(dateTimePicker1);
            Controls.Add(yayınevitxt);
            Controls.Add(textBox2);
            Controls.Add(TeslımTarıhı);
            Controls.Add(YayınEvı);
            Controls.Add(barkodnotxt);
            Controls.Add(KitaplarTablosu);
            Controls.Add(kitapyazaritxt);
            Controls.Add(Yazar);
            Controls.Add(Sıl1);
            Controls.Add(Guncelle1);
            Controls.Add(Ekle1);
            Controls.Add(kitapAditxt);
            Controls.Add(KıtapAd);
            Name = "Kitap_İşlemleri";
            Text = "Kitap_İşlemleri";
            ((System.ComponentModel.ISupportInitialize)KitaplarTablosu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KıtapAd;
        private Label barkodnotxt;
        private TextBox kitapAditxt;
        private TextBox textBox2;
        private TextBox yayınevitxt;
        private Button OduncAl;
        private Button SureyıUzat;
        private Button GerıVer;
        private Label Yazar;
        private TextBox kitapyazaritxt;
        private Label TeslımTarıhı;
        private Label Yayınevı;
        private DateTimePicker dateTimePicker1;
        private Button Ekle1;
        private Button Guncelle1;
        private Button Sıl1;
        private DataGridView KitaplarTablosu;
        
        private Label YayınEvı;
        private Button btnDosyaKaydet;
        private Button dosyadanOkubtn;
    }
}