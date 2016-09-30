using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int number = 0;
            int count = 0;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] += i;

                if (i%2 == 0)
                {
                    number += i;
                    count++;
                }
            }
            Console.WriteLine(number/count);
        }
    }
}
