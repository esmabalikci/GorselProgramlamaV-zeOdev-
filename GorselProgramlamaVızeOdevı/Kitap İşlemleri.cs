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

namespace GorselProgramlamaVızeOdevı
{
    public partial class Kitap_İşlemleri : Form
    {
        DataTable dtKitap;
        private List<kitap> Kitap;
        public Kitap_İşlemleri()
        {
            InitializeComponent();
            Kitap = new List<kitap>();
            dtKitap = new DataTable();
            dtKitap.Columns.Add("Kitap adı");
            dtKitap.Columns.Add("Yazar");
            dtKitap.Columns.Add("Barkod No");
            dtKitap.Columns.Add("Yayınevi");
            dtKitap.Columns.Add("Teslim Tarihi");


            KitaplarTablosu.DataSource = dtKitap;
        }



        private void button1_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(kitapAditxt.Text) || string.IsNullOrEmpty(kitapyazaritxt.Text) || string.IsNullOrEmpty(barkodno.Text) || string.IsNullOrEmpty(yayınevitxt.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz!");
                return;
            }


            kitap kitp = new kitap();
            kitp.Ad = kitapAditxt.Text;
            kitp.Yazar = kitapyazaritxt.Text;
            kitp.BarkodNo = barkodnotxt.Text;
            kitp.Yayınevi = yayınevitxt.Text;
            kitp.TeslimTarihi = dateTimePicker1.Text;
            kitap.kitaplar.Add(kitp);

            MessageBox.Show("Kitap kaydı yapıldı");

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
    }
}
