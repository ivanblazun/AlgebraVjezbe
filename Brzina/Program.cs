using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brzina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                // unos puta
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Unesite udaljenost u kilometrima => ");
                double put;
                bool putIsDouble = Double.TryParse(Console.ReadLine(), out put);
                while (!putIsDouble)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("unos mora biti sa numerickim vrijednostima!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Unesite udaljenost u kilometrima => ");
                    putIsDouble = Double.TryParse(Console.ReadLine(), out put);
                }

                // unos vremena
                Console.Write("Unesite vrijeme putovanja => ");
                double vrijeme;
                bool vrijemeIsDouble = Double.TryParse(Console.ReadLine(), out vrijeme);
                while (!vrijemeIsDouble)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("unos mora biti sa numerickim vrijednostima!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Unesite udaljenost u kilometrima => ");
                    vrijemeIsDouble = Double.TryParse(Console.ReadLine(), out vrijeme);
                }

                // izracun
                double brzinaKm = put / vrijeme;
                double brzinaM = (brzinaKm / 1.6);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Krećete se brzinom od: " + Math.Round(brzinaKm, 2).ToString() + " Km/h");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Također, krećete se brzinom od: " + Math.Round(brzinaM, 2).ToString() + " mil/h");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zelite li izaci iz programa (Esc) ? ili jednostavno pritisnite bilo koju tipku za nastavak...");

                // izlaz iz petlje
                if (Console.ReadKey().KeyChar == 27)
                {
                    isRunning = false;
                }
            }
        }
    }
}
