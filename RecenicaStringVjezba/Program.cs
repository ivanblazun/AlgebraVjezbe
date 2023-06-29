using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecenicaStringVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu");
            Console.WriteLine("\n");
            string recenica = Console.ReadLine();
            if (recenica.Length < 3)
            {
                Console.WriteLine("Minimalno 3 slova morate upisati");
                Console.ReadLine();
            }
            else
            {
                string rijec;

                recenica.ToLower();
                recenica.Trim();

                int duzinaRecenice = recenica.Length - 1;
                int trecinaRecenice = (recenica.Length - 1) / 3;
                int dvijeTrecine = (trecinaRecenice * 2) - 1;

                char umjestA = 'b', umjestE = 'c', ujestI = 'd', umjestO = 'f', umjestoU = 'g';     


                Console.WriteLine("Ispis recenice Velika/Mala/Velika");
                Console.WriteLine("\n");
                Console.WriteLine(recenica.Substring(0, (duzinaRecenice + 1) / 3).ToUpper() +

                                  recenica.Substring((duzinaRecenice + 1) / 3, dvijeTrecine).ToLower() +

                                  recenica.Substring(trecinaRecenice * 2, duzinaRecenice - dvijeTrecine).ToUpper()

                        );
                Console.WriteLine("Upisite rijec iz recenice, dobit cete poziciju te rijeci");
                Console.WriteLine("\n");
                rijec= Console.ReadLine();

                int pocetnaPozicija = recenica.IndexOf(rijec[0]);
          
                Console.WriteLine($"Pocetna pozicija rijeci {rijec} je na {pocetnaPozicija}");
                Console.WriteLine("\n");

                ///////////////////////////////////////////////////////////
                Console.WriteLine("Zamjena suglasnika za samoglasnike");

         
                Console.ReadLine();

            }
            

        }
    }
}
