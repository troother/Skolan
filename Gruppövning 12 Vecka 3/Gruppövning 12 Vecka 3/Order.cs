using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_12_Vecka_3
{
    class Order
    {
        public List<Bok> Varukorg { get; set; }

        public void TaBortArtikel(Bok boken)
        {
            int? where = null;
            for (int i = 0; i < Varukorg.Count; i++)
            {
                if (Varukorg[i].Equals(boken))
                    where = i;
            }

            if(where != null)
                Varukorg.RemoveAt(where.Value);
        }
    }
}
