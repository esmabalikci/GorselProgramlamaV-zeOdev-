﻿using Emanet;
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

namespace GorselProgramlamaVızeOdevı
{
    public partial class Emanet_İşlemleri : Form
    {
        DataTable dtEmanet;
        private List<emanet> Emanet;
        public Emanet_İşlemleri()
        {

            InitializeComponent();
            Emanet = new List<emanet>();
            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Kitap adı");
            dtEmanet.Columns.Add("Yazar");
            dtEmanet.Columns.Add("Ceza");


            emanettablo.DataSource = dtEmanet;

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

       

        private void TeslımEt_Click(object sender, EventArgs e)
        {
            
            string KitapAdı = KıtapAd1.Text;
            string Yazar = Yazar1.Text;
            string Ceza = CezaBox.Text;


            Remove(KitapAdı, Yazar, Ceza);

            MessageBox.Show("Emanet işlemi başarıyla silindi!");

        }
        private void Remove(string kitapAdı, string yazar, string ceza)
        {
            throw new NotImplementedException();
        } 
        
    }





}
