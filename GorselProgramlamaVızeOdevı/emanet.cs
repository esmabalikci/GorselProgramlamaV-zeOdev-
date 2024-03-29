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
        public string KitapAdı { get; set; }
        public string Yazar { get; set; }
        public string Ceza { get; set; }


        public void tabloyaEkle(DataTable dt)
        {
            dt.Rows.Add(new Object[] { KitapAdı });
            dt.Rows.Add(new Object[] { Yazar});
            dt.Rows.Add(new Object[] { Ceza });
         

        }

    }
}
