using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            
            Console.WriteLine("Upišite broj");
            int unos = int.Parse(Console.ReadLine());
            
            if (unos > b)
            {
                Console.WriteLine($"{unos} je iznad krajnje tocke {b} intervala");
            }
            else if (unos < a)
            {
                Console.WriteLine($"{unos} je ispod pocetne tocke {a} intervala");
            }
            else
            {
                Console.WriteLine($"{unos} je unutar intervala izmedu {a} i {b}");
            }
            Console.ReadKey();
        }
    }
}
