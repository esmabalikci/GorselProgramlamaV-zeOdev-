using Kitap;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanet
{
    public class emanet
    {

        public static List<emanet> emanetler = new List<emanet>();
        public string KitapAdı { get; set; }
        public string Yazar { get; set; }
        public string Ceza { get; set; }
        private int emanetId;
        private static int sayac = 1;

       

        public string? kitapAdı { get { return KitapAdı; } set { KitapAdı  = value; } }
      
        public string? KitapYazar { get { return Yazar; } set { Yazar = value; } }
        public string? ceza  { get { return ceza; } set { ceza= value; } }

        public int EmanetId { get { return emanetId; } set { emanetId = value; } }


        public emanet() { emanetId = sayac++; }

        public void tabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] { KitapAdı ,Yazar, Ceza});

        }

    }
}
