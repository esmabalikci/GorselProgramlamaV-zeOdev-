using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap
{
    public class kitap
    {
        public static List<kitap> kitaplar = new List<kitap>();
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string BarkodNo {get;set;}
        public string Yayınevi { get; set; }
        public string TeslimTarihi {get; set; }

        public void tabloyaEkle(DataTable dt)
        {
            dt.Rows.Add(new Object[] {Ad});
            dt.Rows.Add(new Object[] {Yazar});
            dt.Rows.Add(new Object[] {BarkodNo});   
            dt.Rows.Add(new Object[] {Yayınevi});   
            dt.Rows.Add(new Object[] {TeslimTarihi});

          
        }

        internal void Add(kitap kitap)
        {
            throw new NotImplementedException();
        }
    }
}
