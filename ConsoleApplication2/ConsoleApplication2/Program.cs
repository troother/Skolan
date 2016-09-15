using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Första loopen: {0}", i);
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine("Andra loopen: {0}");
                    for (int l = 0; l < 10; l++)
                    {
                        Console.WriteLine("Tredje loopen: {0}", l);
                    }
                }
            }
        }
    }
}
