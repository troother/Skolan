using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzerian_Tobbe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzor = new List<Pizza>();

            var one = new Pizza() { Name = "calsone", Pris = 15 };
            var two = new Pizza() { Name = "bubbe", Pris = 10 };
            var three = new Pizza() { Name = "TobbeSpecial", Pris = 20 };

            pizzor.Add(one);
            pizzor.Add(two);
            pizzor.Add(three);

            int summa = 0;

            if (pizzor.Count > 2)
            {
                pizzor.Sort((x,y) => x.Pris.CompareTo(y.Pris));

                pizzor.ElementAt(0).Pris = 0;

                foreach (var pizza in pizzor)
                {
                    Console.WriteLine("Pizza: {0}, Pris: {1}", pizza.Name, pizza.Pris);
                    summa += pizza.Pris;
                }

                Console.WriteLine("Slutsumma för varukorgen: {0}", summa);

            }

            Console.ReadLine();

        }
    }


    class Pizza
    {
        public string Name { get; set; }
        public int Pris { get; set; }
    }
}
