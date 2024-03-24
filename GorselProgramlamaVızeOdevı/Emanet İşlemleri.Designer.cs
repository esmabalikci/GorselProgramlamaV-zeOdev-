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
            ((System.ComponentModel.ISupportInitialize)CezaBox).BeginInit();
            SuspendLayout();
            // 
            // KıtapAd1
            // 
            KıtapAd1.AutoSize = true;
            KıtapAd1.BackColor = Color.Moccasin;
            KıtapAd1.Location = new Point(123, 55);
            KıtapAd1.Name = "KıtapAd1";
            KıtapAd1.Size = new Size(74, 20);
            KıtapAd1.TabIndex = 0;
            KıtapAd1.Text = "Kitap Adı:";
            // 
            // Yazar1
            // 
            Yazar1.AutoSize = true;
            Yazar1.BackColor = Color.Moccasin;
            Yazar1.Location = new Point(150, 113);
            Yazar1.Name = "Yazar1";
            Yazar1.Size = new Size(47, 20);
            Yazar1.TabIndex = 1;
            Yazar1.Text = "Yazar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 6;
            // 
            // OduncAl
            // 
            OduncAl.BackColor = Color.Pink;
            OduncAl.Location = new Point(137, 269);
            OduncAl.Name = "OduncAl";
            OduncAl.Size = new Size(122, 47);
            OduncAl.TabIndex = 10;
            OduncAl.Text = "Ödünç Al";
            OduncAl.UseVisualStyleBackColor = false;
            // 
            // SureyıUzat
            // 
            SureyıUzat.BackColor = Color.Pink;
            SureyıUzat.Location = new Point(317, 269);
            SureyıUzat.Name = "SureyıUzat";
            SureyıUzat.Size = new Size(115, 47);
            SureyıUzat.TabIndex = 11;
            SureyıUzat.Text = "Süreyi Uzat";
            SureyıUzat.UseVisualStyleBackColor = false;
            // 
            // TeslımEt
            // 
            TeslımEt.BackColor = Color.Pink;
            TeslımEt.Location = new Point(500, 269);
            TeslımEt.Name = "TeslımEt";
            TeslımEt.Size = new Size(121, 47);
            TeslımEt.TabIndex = 12;
            TeslımEt.Text = "Teslim Et";
            TeslımEt.UseVisualStyleBackColor = false;
            TeslımEt.Click += TeslımEt_Click;
            // 
            // Ceza
            // 
            Ceza.AutoSize = true;
            Ceza.BackColor = Color.Moccasin;
            Ceza.Location = new Point(153, 173);
            Ceza.Name = "Ceza";
            Ceza.Size = new Size(44, 20);
            Ceza.TabIndex = 13;
            Ceza.Text = "Ceza:";
            // 
            // CezaBox
            // 
            CezaBox.Location = new Point(249, 166);
            CezaBox.Name = "CezaBox";
            CezaBox.Size = new Size(250, 27);
            CezaBox.TabIndex = 15;
            // 
            // Emanet_İşlemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(738, 393);
            Controls.Add(CezaBox);
            Controls.Add(Ceza);
            Controls.Add(TeslımEt);
            Controls.Add(SureyıUzat);
            Controls.Add(OduncAl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Yazar1);
            Controls.Add(KıtapAd1);
            Name = "Emanet_İşlemleri";
            Text = "Emanet_İşlemleri";
            ((System.ComponentModel.ISupportInitialize)CezaBox).EndInit();
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
    }
}