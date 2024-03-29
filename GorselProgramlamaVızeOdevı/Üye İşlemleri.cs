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

namespace GorselProgramlamaVızeOdevı
{
    public partial class UyeIslemleri1 : Form
    {
        DataTable dtUyeler;
        private List<kullanıcı> Uyeler;

        public UyeIslemleri1()
        {
            InitializeComponent();
            Uyeler = new List<kullanıcı>();
            dtUyeler = new DataTable();
            dtUyeler.Columns.Add("Kullanıcı adı");
            dtUyeler.Columns.Add("Kullanıcı Soyadı");
            dtUyeler.Columns.Add("Cinsiyeti");
            dtUyeler.Columns.Add("TC ");
            dtUyeler.Columns.Add("Tel No");
            dtUyeler.Columns.Add("Mail ");

            kullanıcıTablosu.DataSource = dtUyeler;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            kullanıcı kullanıcı = new kullanıcı();
            kullanıcı.KullanıcıAdı = KullanıcıAd.Text;
            kullanıcı.Kullanıcısoyad = KullanıcıSoyad.Text;
            kullanıcı.cinsiyet = Cınsıyet.Text;
            kullanıcı.TC = TC.Text;
            kullanıcı.TelNo = TelNo.Text;
            kullanıcı.Maıl = Maıl.Text;



            kullanıcı.Uyeler.Add(kullanıcı);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void UyeIslemleri1_Load(object sender, EventArgs e)
        {

        }

        private void KullanıcıAd_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox6.Text))) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox6.Text);
            if (Erkek == null)
            {
                //    MessageBox.Show("hoşgeldiniz Hanımefendi");

            }
            else
            {


            }


            MessageBox.Show("Lütfen kullanıcı bilgilerini giriniz. ");
            return;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KullanıcıSoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
