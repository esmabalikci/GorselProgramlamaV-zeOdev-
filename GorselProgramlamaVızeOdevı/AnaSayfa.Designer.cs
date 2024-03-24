namespace GorselProgramlamaVızeOdevı
{
    partial class AnaSayfa
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
            UyeIslemlerı = new Button();
            KıtapIslemlerı = new Button();
            EmanetIslemlerı = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UyeIslemlerı
            // 
            UyeIslemlerı.BackColor = Color.Moccasin;
            UyeIslemlerı.Location = new Point(12, 21);
            UyeIslemlerı.Name = "UyeIslemlerı";
            UyeIslemlerı.Size = new Size(129, 29);
            UyeIslemlerı.TabIndex = 0;
            UyeIslemlerı.Text = "Üye İşlemleri";
            UyeIslemlerı.UseVisualStyleBackColor = false;
            UyeIslemlerı.Click += UyeIslemlerı_Click;
            // 
            // KıtapIslemlerı
            // 
            KıtapIslemlerı.BackColor = Color.Moccasin;
            KıtapIslemlerı.Location = new Point(168, 21);
            KıtapIslemlerı.Name = "KıtapIslemlerı";
            KıtapIslemlerı.Size = new Size(162, 29);
            KıtapIslemlerı.TabIndex = 1;
            KıtapIslemlerı.Text = "Kitap İşlemleri";
            KıtapIslemlerı.UseVisualStyleBackColor = false;
            KıtapIslemlerı.Click += button2_Click;
            // 
            // EmanetIslemlerı
            // 
            EmanetIslemlerı.BackColor = Color.Moccasin;
            EmanetIslemlerı.Location = new Point(371, 21);
            EmanetIslemlerı.Name = "EmanetIslemlerı";
            EmanetIslemlerı.Size = new Size(145, 29);
            EmanetIslemlerı.TabIndex = 2;
            EmanetIslemlerı.Text = "Emanet İşlemleri";
            EmanetIslemlerı.UseVisualStyleBackColor = false;
            EmanetIslemlerı.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 307);
            dataGridView1.TabIndex = 3;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(EmanetIslemlerı);
            Controls.Add(KıtapIslemlerı);
            Controls.Add(UyeIslemlerı);
            Name = "AnaSayfa";
            Text = "Form1";
            Load += AnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UyeIslemlerı;
        private Button KıtapIslemlerı;
        private Button EmanetIslemlerı;
        private DataGridView dataGridView1;
    }
}