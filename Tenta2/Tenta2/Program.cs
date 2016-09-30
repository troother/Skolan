using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fest fest = new Fest();
            //Deltagare deltagare = new Deltagare();

            //fest.Vard = deltagare;

            var vard = new Deltagare
            {
                Fornamn = "isabella",
                Efternamn = "Alstrom",
                Alder = 25
            };
            var deltagare1 = new Deltagare
            {
                Fornamn = "Carl",
                Efternamn = "Schele",
                Alder = 35
            };
            var deltagare2 = new Deltagare
            {
                Fornamn = "Marcus",
                Efternamn = "Hult",
                Alder = 27
            };

            //Fest fest = new Fest("Tentapub", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 3000, "Humlegarden", vard);

            //fest.Deltagare = new List<Deltagare>();

            Forfest forfest = new Forfest("Tentapub", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 3000, "Humlegarden", vard);
            forfest.NyDeltagare(deltagare1);
            forfest.NyDeltagare(deltagare2);
            //forfest.Lokalkostnad = 2000;
            forfest.intrade();


            Halloweenfest halloweenfest = new Halloweenfest("Tentapub", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 3000, "Humlegarden", vard);
            halloweenfest.NyDeltagare(deltagare1);
            halloweenfest.NyDeltagare(deltagare2);
            //halloweenfest.Lokalkostnad = 5000;
            halloweenfest.intrade();


            //fest.NyDeltagare(deltagare1);
            //fest.NyDeltagare(deltagare2);

            //fest.AntalDeltagare();
        }
    }
}
