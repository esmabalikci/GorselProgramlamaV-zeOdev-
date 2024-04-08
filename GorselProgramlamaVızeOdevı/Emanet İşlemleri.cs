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

namespace GorselProgramlamaVızeOdevı
{
    public partial class Emanet_İşlemleri : Form
    {
        SQLiteConnection baglantii;
        DataTable dtEmanet;
        private List<emanet> Emanet;
       
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
            throw new NotImplementedException();
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
