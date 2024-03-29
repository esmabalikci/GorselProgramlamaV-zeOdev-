using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyeler
{
    public class kullanıcı
    {
        public string KullanıcıAdı {  get; set; }   
        public string Kullanıcısoyad {  get; set; }
        public string cinsiyet {  get; set; }   
        public string TC {  get; set; }
        public string TelNo { get; set; }

        public string Maıl { get; set; }


        public void tabloyaEkle(DataTable dt)
        {
            dt.Rows.Add(new Object[] { KullanıcıAdı });
            dt.Rows.Add(new Object[] { Kullanıcısoyad });
            dt.Rows.Add(new Object[] { cinsiyet });
            dt.Rows.Add(new Object[] { TC });
            dt.Rows.Add(new Object[] { TelNo });
            dt.Rows.Add(new Object[] {Maıl });


        }

    }
}
