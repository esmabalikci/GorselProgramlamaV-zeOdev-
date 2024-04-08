using Uyeler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Kitap;
using Json.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Data.SQLite;
using System.Data.SqlClient;


namespace GorselProgramlamaVızeOdevı
{
    public partial class UyeIslemleri1 : Form
    {
        SQLiteConnection baglanti; 
        DataTable dtUyeler;
        private List<kullanıcı> Uyeler;

        public UyeIslemleri1()
        {
            InitializeComponent();
            string baglanti = "Data Source=kütüphaneuygulaması.db;Version=3";
            Uyeler = new List<kullanıcı>();
            dtUyeler = new DataTable();
            dtUyeler.Columns.Add("Kullanıcı adı");
            dtUyeler.Columns.Add("Kullanıcı Soyadı");
            dtUyeler.Columns.Add("Cinsiyeti");
            dtUyeler.Columns.Add("TC ");
            dtUyeler.Columns.Add("Tel No");
            dtUyeler.Columns.Add("Mail ");

            kullanıcıTablosu.DataSource = dtUyeler;

           
            using (var baglan = new SqlConnection(baglanti)) 
            {
                try 
                { 
                    baglan.Open();
                    MessageBox.Show("Veri Tabanına bağlantı başarılı bir şekilde sağlandı.");
                
                } 
                catch (Exception hata)
                {
                    MessageBox.Show("Veri Tabanına bağlantı sağlanamadı.!\nHata Mesajı: "+hata.Message);



                }
            }


        }
        private void UyeEkle_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO kullanıcı (Kullanıcı Adı,Kullanıcı Soyadı ,Cinsiyet,TC,Tel No,Mail) VALUES(\"{KullanıcıAd.Text}\", \"{KullanıcıSoyad.Text}\", \"{Cınsıyet.Text}\", \"{TC.Text}\",\"{TelNo.Text}\",\"{Maıl.Text}\")";


            int eklenen_sayisi = komut.ExecuteNonQuery();
            if (eklenen_sayisi > 0)
                TabloGuncelle();

            KullanıcıAd.Text = "";
            KullanıcıSoyad.Text = "";
            Cınsıyet.Text = "";
            TC.Text = "";
            TelNo.Text = "";
            Maıl.Text = "";

        }

        private void TabloGuncelle()
        {
            throw new NotImplementedException();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void UyeSıl_Click(object sender, EventArgs e)
        {
            if (UyeSıl.SelectedIndex != -1)
            {
                Uyeler.RemoveAt(UyeSıl.SelectedIndex);


                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSon Dosyası|*.json";
                if (dialog.ShowDialog() == DialogResult.OK)

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı!");
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen bir üye seçiniz!");
            }
        }

        private void Listele()
        {
            throw new NotImplementedException();
        }

        private void dosyayakaydetuye_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonNet.Serialize(kullanıcı.Uyeler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void Dosyadanokuuye_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                kullanıcı.Uyeler = JsonNet.Deserialize<List<kullanıcı>>(data);
                foreach (var kullanıcı in kullanıcı.Uyeler)
                {
                    kullanıcı.tabloyaEkle(dtUyeler);
                }
            }
        }

        private void Guncelleme_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedIndex != -1)
            {
                kullanıcı Uye = Uyeler[listbox.SelectedIndex];

                textBox6.Text = Uye.KullanıcıAdı;
                textBox5.Text = Uye.Kullanıcısoyad;
                textBox1.Text = Uye.cinsiyet;
                textBox4.Text = Uye.TC;
                textBox3.Text = Uye.TelNo;
                textBox2.Text = Uye.Maıl;

                Uyeler.RemoveAt(listbox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen bir üye seçiniz");
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)



                MessageBox.Show("Güncelleme işlemini geçtiniz.");
        }

        private void kullanıcıTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KullanıcıAd.Text = kullanıcıTablosu.SelectedRows[0].Cells[1].Value.ToString();
                KullanıcıSoyad.Text = kullanıcıTablosu.SelectedRows[0].Cells[2].Value.ToString();
                Cınsıyet.Text = kullanıcıTablosu.SelectedRows[0].Cells[3].Value.ToString();
                TC.Text = kullanıcıTablosu.SelectedRows[0].Cells[4].Value.ToString();
                TelNo.Text = kullanıcıTablosu.SelectedRows[0].Cells[5].Value.ToString();
                Maıl.Text = kullanıcıTablosu.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }


}


