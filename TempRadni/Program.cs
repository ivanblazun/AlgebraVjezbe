using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Switch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int rezultat;
            int operacija = int.Parse(Console.ReadLine()); 
            switch (operacija)
            {
                case 1:
                    {
                        Console.WriteLine( rezultat = a+b);
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(rezultat= a - b);
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    {
                        
                        if(b == 0 && a == 0)  
                        {
                            Console.WriteLine("Nemoguce djeljenje nulom");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine(rezultat = a / b);
                            Console.ReadLine();

                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine(rezultat = a * b);
                        Console.ReadLine();
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Izlaz");
                        Console.ReadLine();
                    }
                    break;
                default:
                    // code block
                    break;
            }
        }
    }
}
