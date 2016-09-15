using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_övning_2_Calle
{
    class Kurs
    {
        public string Namn { get; set; }
        public int Poäng { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }






        public double BeräknaAntalKursDagar()
        {
            TimeSpan antalDagar = SlutDatum - StartDatum;

            double antalDagarDouble = double.Parse(antalDagar.TotalDays.ToString());

            return antalDagarDouble;
        }

        public float PoängPerKursdag()
        {
            float ppk = float.Parse(BeräknaAntalKursDagar().ToString());
            ppk = Poäng/ppk;

            return ppk;
        }


    }
}
