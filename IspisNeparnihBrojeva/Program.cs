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
            int[,] nizBrojeviBrojac = new int[2,1];
            
            Console.WriteLine("Unesite interval brojeva i dobi cete ispisane neparne brojeve...");

            int pocetniUnos = UnosBroja(nizBrojeviBrojac);
            int zadnjiUnos = UnosBroja(nizBrojeviBrojac);

            //IspisIntervala(brojevi);

            Console.ReadLine();


        }
        private static int UnosBroja(int[,] nizBrojeviBrojac)
        {
            nizBrojeviBrojac[0, nizBrojeviBrojac[1, 0] - 1] = Convert.ToInt32(Console.ReadLine());
            nizBrojeviBrojac[1, 0] += 1;
            Console.WriteLine(nizBrojeviBrojac[0, nizBrojeviBrojac[1, 0 ] - 1]);
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
