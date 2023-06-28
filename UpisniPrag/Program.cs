using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpisniPrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int umnozitelj = 3;
            int inf, mat, fiz, zbroj;
            int prag = 25;

            Console.WriteLine("Upišite ocijenu fizike");
            fiz = int.Parse(Console.ReadLine());

            Console.WriteLine("Upišite ocijenu matematike");
            mat = int.Parse(Console.ReadLine());

            Console.WriteLine("Upišite ocijenu informatike");
            inf = int.Parse(Console.ReadLine());

            zbroj = (inf * umnozitelj) + (mat * umnozitelj) + (fiz * umnozitelj);

            if (zbroj > 45)
            {
                Console.WriteLine("upisana ocijena nemoze biti veca od 5");
                Console.ReadLine();
            }
            else
            {
                if (inf < 2 || mat < 2 || fiz < 2)
                {
                    Console.WriteLine("Predmeti ne smiju biti ocijenjeni kao nedovoljan, niste zadovoljili uvjete upisa");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Vaš zbroj bodova je {zbroj.ToString()}");

                    if (zbroj < prag)
                    {
                        Console.WriteLine($"nazalost, nemate dovoljno bodova za upis");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Imate dovoljno bodova za upis");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
