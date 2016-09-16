using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_övning_5
{
    class Klassrum
    {
        public int AntalStolar { get; set; }
        public string Benamning { get; set; }
        public int Yta { get; set; }

        public List<Lektion> Lektioner { get; set; }

        public Klassrum()
        {
            Lektioner = new List<Lektion>();
        }
        public bool CheckSpace(int minYta)
        {
            if (minYta >= Yta)
                return true;
            else
                return false;
        }

        public bool CheckSeats(int seats)
        {
            if (seats >= AntalStolar)
                return true;
            else
                return false;
        }

        public List<Lektion> GetLessons(DateTime start, DateTime end)
        {
            List<Lektion> test = new List<Lektion>();

            foreach (var lektion in Lektioner)
            {
                if(lektion.StartTid >= start && lektion.StartTid <= end)
                    test.Add(lektion);
            }
            return test;
        }

        public bool KontrolleraLedigt(DateTime start, DateTime end)
        {
            var lektioner = GetLessons(start, end);
            if (lektioner.Capacity == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
