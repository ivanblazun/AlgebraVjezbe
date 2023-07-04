using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzracunBrojevaKrozMetodeIPetlje
{
    internal class Program
    {
      
        //Napraviti kalkulator(s cijelim brojevima), a računske operacije napraviti u metodama Zbroj, Produkt, Razlika, Kvocijent, Kvadrat, Ostatak.
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva zeljena brojeva...");
            int[] brojevi = UnosBrojeva();
            Console.WriteLine("Unesite zeljene operaciju");
            IspisRezultata(Izracun(brojevi));
            Console.ReadLine();
        }

        private static void IspisRezultata(string rijesenje)
        {
            Console.WriteLine(rijesenje);
        }

        private static string Izracun(int[] unos)
        {
            char operacija = Convert.ToChar(Console.ReadLine());
            string odgovor = $"Unosi: {unos[0]} {Convert.ToString(operacija)} {unos[1]} = ";
            switch (operacija)
            {
                case '+':
                    return odgovor + Convert.ToString(unos[0] + unos[1]);
                case '-':
                    return odgovor + Convert.ToString(unos[0] - unos[1]);
                case '*':
                    return odgovor + Convert.ToString(unos[0] * unos[1]);
                case '/':
                    if (unos[1] == 0)
                    {
                        return ($"Nedijeljivo sa 0");
                    }
                    else
                    {
                        return odgovor + Convert.ToString(unos[0] / unos[1]);
                    }
                default:
                    break;
            }
            return null;
        }

        private static int[] UnosBrojeva()
        {
            int[] unos = new int[2];
            int brojac = 0;
            while (brojac < 2)
            {
                unos[brojac] = Convert.ToInt32(Console.ReadLine());
                brojac++;
                Console.WriteLine($"{brojac}. broj je {unos[brojac - 1]}");
            }
            return unos;
        }
    }
}

