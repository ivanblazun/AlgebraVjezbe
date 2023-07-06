using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspisNeparnihBrojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nizBrojeviBrojac = new int[2,2];
            
            Console.WriteLine("Unesite interval brojeva i dobi cete ispisane neparne brojeve...");

            int pocetniUnos = UnosBroja(nizBrojeviBrojac);
            Console.WriteLine(pocetniUnos);
            int zadnjiUnos = UnosBroja(nizBrojeviBrojac);
            Console.WriteLine();
            //IspisIntervala(brojevi);

            Console.ReadLine();


        }
        private static int UnosBroja(int[,] nizBrojeviBrojac)
        {
            nizBrojeviBrojac[1, 0]++;
            nizBrojeviBrojac[0, nizBrojeviBrojac[1, 0]-1] = Convert.ToInt32(Console.ReadLine());
            return nizBrojeviBrojac[0, nizBrojeviBrojac[1, 0]-1];

        }

        private static void IspisIntervala(int[] brojevi) 
        { 
            for (int i = brojevi[0]; i <= brojevi[1]; i++)
            {
                
                    Console.WriteLine(i);
                
            }
        }
    }
}
