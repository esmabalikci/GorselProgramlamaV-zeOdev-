using Emanet;
using Json.Net;
using Kitap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using Uyeler;
using System.Security.Cryptography.X509Certificates;

namespace GorselProgramlamaVızeOdevı
{
    public partial class Emanet_İşlemleri : Form
    {
        SQLiteConnection baglantii;
        DataTable dtEmanet;
        private List<emanet> Emanet;
        private object Cells;

        public Emanet_İşlemleri()
        {

            InitializeComponent();
            string baglantii = "Data Source=emanet.db;Version=3";
            Emanet = new List<emanet>();
            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Kitap adı");
            dtEmanet.Columns.Add("Yazar");
            dtEmanet.Columns.Add("Ceza");


            emanettablo.DataSource = dtEmanet;


            using (var baglan = new SqlConnection(baglantii))
            {
                try
                {
                    baglan.Open();
                    MessageBox.Show("Veri Tabanına bağlantı başarılı bir şekilde sağlandı.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veri Tabanına bağlantı sağlanamadı.!\nHata Mesajı: " + hata.Message);



                }
            }
            private void Emanet_İşlemleri_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (baglantii != null && baglantii.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        baglantii.Close();
                        MessageBox.Show("SQLite bağlantısı sonlandırıldı.");

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("SQLite bağlantısı sonlandırılamadı.");

                    }


                }
            }





        }

        private void emanetdosyakaydet_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonNet.Serialize(emanet.emanetler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void emanetdosyadanoku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                emanet.emanetler = JsonNet.Deserialize<List<emanet>>(data);
                foreach (var emanet in emanet.emanetler)
                {
                    emanet.tabloyaEkle(dtEmanet);
                }
            }
        }

        private void OduncAl_Click(object sender, EventArgs e)
        {
            emanet emt = new emanet();
            emt.KitapAdı = KıtapAd1.Text;
            emt.Yazar = Yazar1.Text;
            emt.Ceza = Ceza.Text;


            emanet.emanetler.Add(emt);
            MessageBox.Show("Emanet işlemi başarıyla gerçekleşti.");
        }



        private void TeslımEt_Click(object sender, EventArgs e, SQLiteConnection baglantii)
        {

            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglantii;
            komut.CommandText = $"INSERT INTO emanetişlemleri (KitapAdı,Yazar,Ceza) VALUES(\"{KıtapAd1.Text}\", \"{Yazar1.Text}\", \"{CezaBox.Text}\")";


            int eklenen_sayisi = komut.ExecuteNonQuery();
            if (eklenen_sayisi > 0)
                TabloGuncelle();

            KıtapAd1.Text = "";
            Yazar1.Text = "";
            CezaBox.Text = "";

            MessageBox.Show("Emanet işlemi başarıyla silindi!");

        }

        private void TabloGuncelle()
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglantii;
            komut.CommandText = "SELECT * FROM Emanet_İşlemleri ";

            DataTable emanet = new DataTable();
            emanet.Columns.Add("Kitap Adı");
            emanet.Columns.Add("Yazar");
            emanet.Columns.Add("Ceza");

            SQLiteDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                emanet.Rows.Add(new object[] { okuyucu.GetInt32(0),
                                               okuyucu.GetInt32(1),
                                               okuyucu.IsDBNull(4) ? " " : okuyucu.GetInt32(2) });
            }


            emanettablo.DataSource = emanet;


        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(emanettablo.SelectedRows[0], Cells[0].Value);

                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglantii;
                komut.CommandText = $"UPDATE emanet SET KıtapAd1=\"{textBox1.Text}\",Yazar1=\"{textBox2.Text}\",Ceza=\"{CezaBox.Text}\" WHERE ID = { ID }";

                int eklenen_sayisi = komut.ExecuteNonQuery();
                if (eklenen_sayisi > 0)
                    TabloGuncelle();  


            }
            catch(Exception hata) 
            {

            }
        }
    }

    private void emanettablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KıtapAd1.Text = emanettablo.SelectedRows[0].Cells[1].Value.ToString();
                Yazar1.Text = emanettablo.SelectedRows[0].Cells[2].Value.ToString();
                CezaBox.Text = emanettablo.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

      
    }





}
