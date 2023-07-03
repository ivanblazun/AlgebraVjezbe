using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramidaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 10;
            int razmak = broj;

            for (int i = 0; i <= broj; i++)
            {
                razmak--;

                for (int j = 0; j <= razmak; j++)
                {
                    Console.Write(" ");

                }

                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");
                }

                for (int x = 0; x <= i; x++)
                {

                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
