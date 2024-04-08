namespace GorselProgramlamaVızeOdevı
{
    partial class Emanet_İşlemleri
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
            KıtapAd1 = new Label();
            Yazar1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            OduncAl = new Button();
            SureyıUzat = new Button();
            TeslımEt = new Button();
            Ceza = new Label();
            CezaBox = new NumericUpDown();
            emanettablo = new DataGridView();
            emanetdosyadanoku = new Button();
            emanetdosyakaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)CezaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emanettablo).BeginInit();
            SuspendLayout();
            // 
            // KıtapAd1
            // 
            KıtapAd1.AutoSize = true;
            KıtapAd1.BackColor = Color.Moccasin;
            KıtapAd1.Location = new Point(28, 48);
            KıtapAd1.Name = "KıtapAd1";
            KıtapAd1.Size = new Size(74, 20);
            KıtapAd1.TabIndex = 0;
            KıtapAd1.Text = "Kitap Adı:";
            // 
            // Yazar1
            // 
            Yazar1.AutoSize = true;
            Yazar1.BackColor = Color.Moccasin;
            Yazar1.Location = new Point(55, 106);
            Yazar1.Name = "Yazar1";
            Yazar1.Size = new Size(47, 20);
            Yazar1.TabIndex = 1;
            Yazar1.Text = "Yazar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 6;
            // 
            // OduncAl
            // 
            OduncAl.BackColor = Color.Pink;
            OduncAl.Location = new Point(12, 269);
            OduncAl.Name = "OduncAl";
            OduncAl.Size = new Size(121, 28);
            OduncAl.TabIndex = 10;
            OduncAl.Text = "Ödünç Al";
            OduncAl.UseVisualStyleBackColor = false;
            OduncAl.Click += OduncAl_Click;
            // 
            // SureyıUzat
            // 
            SureyıUzat.BackColor = Color.Pink;
            SureyıUzat.Location = new Point(150, 269);
            SureyıUzat.Name = "SureyıUzat";
            SureyıUzat.Size = new Size(127, 28);
            SureyıUzat.TabIndex = 11;
            SureyıUzat.Text = "Süreyi Uzat";
            SureyıUzat.UseVisualStyleBackColor = false;
            // 
            // TeslımEt
            // 
            TeslımEt.BackColor = Color.Pink;
            TeslımEt.Location = new Point(293, 269);
            TeslımEt.Name = "TeslımEt";
            TeslımEt.Size = new Size(127, 28);
            TeslımEt.TabIndex = 12;
            TeslımEt.Text = "Teslim Et";
            TeslımEt.UseVisualStyleBackColor = false;
            // 
            // Ceza
            // 
            Ceza.AutoSize = true;
            Ceza.BackColor = Color.Moccasin;
            Ceza.Location = new Point(58, 173);
            Ceza.Name = "Ceza";
            Ceza.Size = new Size(44, 20);
            Ceza.TabIndex = 13;
            Ceza.Text = "Ceza:";
            // 
            // CezaBox
            // 
            CezaBox.Location = new Point(137, 173);
            CezaBox.Name = "CezaBox";
            CezaBox.Size = new Size(250, 27);
            CezaBox.TabIndex = 15;
            // 
            // emanettablo
            // 
            emanettablo.BackgroundColor = Color.White;
            emanettablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emanettablo.Location = new Point(426, 35);
            emanettablo.Name = "emanettablo";
            emanettablo.RowHeadersWidth = 51;
            emanettablo.Size = new Size(300, 286);
            emanettablo.TabIndex = 16;
            emanettablo.CellContentClick += emanettablo_CellContentClick;
            // 
            // emanetdosyadanoku
            // 
            emanetdosyadanoku.BackColor = Color.Pink;
            emanetdosyadanoku.Location = new Point(241, 324);
            emanetdosyadanoku.Name = "emanetdosyadanoku";
            emanetdosyadanoku.Size = new Size(173, 47);
            emanetdosyadanoku.TabIndex = 10;
            emanetdosyadanoku.Text = "Dosya oku";
            emanetdosyadanoku.UseVisualStyleBackColor = false;
            emanetdosyadanoku.Click += emanetdosyadanoku_Click;
            // 
            // emanetdosyakaydet
            // 
            emanetdosyakaydet.BackColor = Color.Pink;
            emanetdosyakaydet.Location = new Point(37, 324);
            emanetdosyakaydet.Name = "emanetdosyakaydet";
            emanetdosyakaydet.Size = new Size(167, 47);
            emanetdosyakaydet.TabIndex = 10;
            emanetdosyakaydet.Text = "Dosya Kaydet";
            emanetdosyakaydet.UseVisualStyleBackColor = false;
            emanetdosyakaydet.Click += emanetdosyakaydet_Click;
            // 
            // Emanet_İşlemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(738, 393);
            Controls.Add(emanettablo);
            Controls.Add(CezaBox);
            Controls.Add(Ceza);
            Controls.Add(TeslımEt);
            Controls.Add(SureyıUzat);
            Controls.Add(emanetdosyakaydet);
            Controls.Add(emanetdosyadanoku);
            Controls.Add(OduncAl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Yazar1);
            Controls.Add(KıtapAd1);
            Name = "Emanet_İşlemleri";
            Text = "Emanet_İşlemleri";
            ((System.ComponentModel.ISupportInitialize)CezaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)emanettablo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KıtapAd1;
        private Label Yazar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button OduncAl;
        private Button SureyıUzat;
        private Button TeslımEt;
        private Label Ceza;
        private NumericUpDown CezaBox;
        private DataGridView emanettablo;
        private Button emanetdosyadanoku;
        private Button emanetdosyakaydet;
    }
}