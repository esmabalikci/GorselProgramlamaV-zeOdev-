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
            kitap kitp = new kitap();
            kitp.Ad = kitapAditxt.Text;
            kitp.Yazar = kitapyazaritxt.Text;
            kitp.BarkodNo = barkodnotxt.Text;
            kitp.Yayınevi = yayınevitxt.Text;
            kitp.TeslimTarihi = dateTimePicker1.Text;

            kitap.kitaplar.Add(kitp);



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BarkodNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void yayınevitxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
