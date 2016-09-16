using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaC
{
    class Program
    {
        public static int[] Siffror = new int[] {1, 3, 6, 8, 5, 4, 3, 9, 8, 10, 4, 2};
        static void Main(string[] args)
        {
            var test = Siffror.Where(x => x > 2).ToArray();

            foreach (var siffra in test)
            {
                Console.WriteLine(siffra);
            }
            Console.ReadLine();
        }
    }
}
