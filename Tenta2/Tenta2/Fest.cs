using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2
{
    public abstract class Fest

    {
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public DateTime StarTid { get; set; }
        public DateTime SlutTid { get; set; }
        public double Lokalkostnad { get; set; }
        public string Plats { get; set; }
        public Deltagare Vard { get; set; }
        public List<Deltagare> Deltagare { get; set; }

        public Fest(string namn, string beskrivning, DateTime starttid, DateTime sluttid, double lokalkostnad, string plats, Deltagare vard)
        {
            Namn = namn;
            Beskrivning = beskrivning;
            StarTid = starttid;
            SlutTid = sluttid;
            Lokalkostnad = lokalkostnad;
            Plats = plats;
            Vard = vard;
        }

        public void NyDeltagare(Deltagare deltagare)
        {
            Deltagare.Add(deltagare);            
        }

        public int AntalDeltagare()
        {
            return Deltagare.Count;
        }

        public abstract void intrade();
    }
}
