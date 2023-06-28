using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostatak3i5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine("Upišite broj");
            int unos = int.Parse(Console.ReadLine());

            if (unos % a == 0)
            {
                Console.WriteLine($"Unos je diljeljiv sa {a}");
            }
            else
            {
                Console.WriteLine($"Unos nije dijeljiv sa {a}");
            }

            if (unos % b == 0)
            {
                Console.WriteLine($"Unos je dijeljiv sa {b}");
            }
            else
            {
                Console.WriteLine($"Unos nije dijeljiva sa {b}");
            }

            Console.ReadKey();
        }
    }
}
