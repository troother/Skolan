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

            var one = new Pizza() { Name = "Kebabpizza", Pris = 90 };
            var two = new Pizza() { Name = "Calzone", Pris = 90 };
            var three = new Pizza() { Name = "TobbeSpecial", Pris = 90 };

            pizzor.Add(one);
            pizzor.Add(two);
            pizzor.Add(three);

            int summa = 0;

            if (pizzor.Count > 2)
            {
                var ny = pizzor.OrderBy(o => o.Pris).ToList();

                ny.RemoveAt(0);

                foreach (var pizza in ny)
                {
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
