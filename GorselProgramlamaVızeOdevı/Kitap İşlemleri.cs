using Kitap;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Data.SQLite;
using Uyeler;
using System.Data.SqlClient;

namespace GorselProgramlamaVızeOdevı
{
    public partial class Kitap_İşlemleri : Form
    {
        SQLiteConnection baglanti;
        DataTable dtKitap;
        private List<kitap> Kitap;
        public Kitap_İşlemleri()
        {
            InitializeComponent();
            string baglanti_metni = "Data Source=kitap.db;Version=3;";
            Kitap = new List<kitap>();
            dtKitap = new DataTable();
            dtKitap.Columns.Add("Kitap adı");
            dtKitap.Columns.Add("Yazar");
            dtKitap.Columns.Add("Barkod No");
            dtKitap.Columns.Add("Yayınevi");
            dtKitap.Columns.Add("Teslim Tarihi");


            KitaplarTablosu.DataSource = dtKitap;

            using (var baglan = new SqlConnection(baglanti))
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



        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO kitapişlemleri (Kullanıcı Adı,Kullanıcı Soyadı ,Cinsiyet,TC,Tel No,Mail) VALUES(\"{KıtapAd.Text}\", \"{Yazar.Text}\", \"{barkodnotxt.Text}\", \"{YayınEvı.Text}\",\"{TeslımTarıhı.Text}\")";


            int eklenen_sayisi = komut.ExecuteNonQuery();
            if (eklenen_sayisi > 0)
                TabloGuncelle();

            KıtapAd.Text = "";
            Yazar.Text = "";
            barkodnotxt.Text = "";
            YayınEvı.Text = "";
            TeslımTarıhı.Text = "";

            MessageBox.Show("Kitap kaydı yapıldı");

        }

        private void TabloGuncelle()
        {
            throw new NotImplementedException();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonNet.Serialize(kitap.kitaplar);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void dosyadanOkubtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                kitap.kitaplar = JsonNet.Deserialize<List<kitap>>(data);
                foreach (var kitap in kitap.kitaplar)
                {
                    kitap.tabloyaEkle(dtKitap);
                }
            }
        }

        private void Guncelle1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kitapAditxt.Text) && !string.IsNullOrEmpty(kitapyazaritxt.Text) && !string.IsNullOrEmpty(barkodno.Text) && !string.IsNullOrEmpty(yayınevitxt.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                kitap kitap = new kitap()
                {
                    Ad = KıtapAd.Text,
                    Yazar = kitapyazaritxt.Text,
                    BarkodNo = barkodno.Text,
                    Yayınevi = yayınevitxt.Text,
                    TeslimTarihi = dateTimePicker1.Text,

                };

                kitap.Add(kitap);




                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı!");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz!");
            }
        }

        private void Temizle()
        {
            throw new NotImplementedException();
        }

        private void Listele()
        {
            throw new NotImplementedException();
        }

        private void KitaplarTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KıtapAd.Text = KitaplarTablosu.SelectedRows[0].Cells[1].Value.ToString();
                Yazar.Text = KitaplarTablosu.SelectedRows[0].Cells[2].Value.ToString();
                barkodnotxt.Text = KitaplarTablosu.SelectedRows[0].Cells[3].Value.ToString();
                Yayınevı.Text = KitaplarTablosu.SelectedRows[0].Cells[4].Value.ToString();
                TeslımTarıhı.Text = KitaplarTablosu.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
