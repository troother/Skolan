using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2
{
    class Halloweenfest : Fest
    {
        public bool Utkladnad { get; set; }

        public Halloweenfest(string namn, string beskrivning, DateTime starttid, DateTime sluttid, double lokalkostnad, string plats, Deltagare vard) : base(namn, beskrivning, starttid, sluttid, lokalkostnad, plats, vard)
        {
        }

        public override double intrade()
        {
            return Lokalkostnad * 1.15;
        }
    }
}
