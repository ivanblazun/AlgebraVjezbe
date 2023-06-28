using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadratna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Izračunaj korijene (rješenja) kvadratne jednadžbe
            //
            //     2
            //	a*x + b*x + c = 0
            // 

            int a, b, c;
            double diskriminanta, x1, x2;

            Console.Write("\n\n");
            Console.WriteLine("============================================");
            Console.WriteLine("Izračunanavanje korijena kvadratne jednadžbe");
            Console.WriteLine("============================================");
            Console.Write("\n\n");

            Console.Write("Unesite vrijednost za kvadratni koeficijent a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite vrijednost za linearni koeficijent b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite vrijednost za slobodni koeficijent c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // uvjet kvadratne jednadžbe
            if (a != 0)
            {
                // korijeni (rješenja) su
                // x1, x2 = (-b +- Sqrt(b*b - 4*a*c)) / (2*a)

                diskriminanta = b * b - 4 * a * c;
                if (diskriminanta == 0)
                {
                    Console.WriteLine("Oba korijena su jednaka.");
                    x1 = -b / (2.0 * a);    // ili -b / (2 * (double)a)
                    x2 = x1;
                    Console.WriteLine("Prvi korijen, x1 = {0}", x1);
                    Console.WriteLine("Drugi korijen, x2 = {0}", x2);
                }
                else if (diskriminanta > 0)
                {
                    Console.WriteLine("Oba korijena su stvarna.");

                    x1 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(diskriminanta)) / (2 * a);

                    Console.WriteLine("Prvi korijen, x1 = {0}", x1);
                    Console.WriteLine("Drugi korijen, x2 = {0}", x2);
                }
                else
                {
                    Console.WriteLine("Korijeni su imaginarni.");
                    Console.WriteLine("Nema rješenja.");
                }
            }
            else
            {
                Console.WriteLine("Koeficijent a mora biti različit od 0.");
            }

            Console.ReadKey();
        }
    }
}
