using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch2_Samoglasnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char slovo = Convert.ToChar(Console.ReadLine().ToLower());
            switch (slovo)
            {
                case 'a':
                    {
                        Console.WriteLine("Samoglasnik");
                        Console.ReadLine();
                    }
                    break;
                case 'o':
                    {
                        Console.WriteLine("Samoglasnik");
                        Console.ReadLine();
                    }
                    break;
                case 'e':
                    {
                        Console.WriteLine("Samoglasnik");
                        Console.ReadLine();

                    }
                    break;
                case 'u':
                    {
                        Console.WriteLine("Samoglasnik");
                        Console.ReadLine();
                    }
                    break;
                case 'i':
                    {
                        Console.WriteLine("Samoglasnik");
                        Console.ReadLine();
                    }

                    break;
                default:
                    Console.WriteLine("Suglasnik");
                    Console.ReadLine();
                    break;
            }

            switch (slovo)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    {
                        Console.WriteLine("Samoglasnik");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Suglasnik");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
