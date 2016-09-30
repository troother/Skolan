using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] tal = new int[];

            int[] tal = new int[1501];

            for (int i = 500; i < tal.Length; i++)
            {
                tal[i] += i;
            }

            var s = tal;

            for (int i = 500; i <= 1500; i++)
            {
                if (tal[i] % 3 == 0)
                {
                    //summa += tal[i];

                    Console.WriteLine(tal[i]);

                }
            }


            Console.Read();
        }
    }
}
