using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string recenice = "Danas je lijep dan";
            //char[] slova = new char[recenice.Length];

            //for (int i = 0; i < recenice.Length; i++)
            //{   
                
            //    slova[i] = recenice[i];
            //    bool isEmpty = slova[i] == ' ';
            //    if (isEmpty)
            //    {
            //        continue;
            //    }
            //    if (slova[i] == 'p') {
            //        break;
            //    }
            //    Console.WriteLine(slova[i]);
            //}

            //List<int> list = new List<int>();

            //for(var i = 0; i <= 20; i++)
            //{
            //    list.Add(i);
            //}

            //for(var i = 0;i <= 20; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            
            int counter = 0;
            do { counter++; Console.WriteLine(counter); } while (counter < 10);
            Console.WriteLine("\n");
            counter++;
            do {counter--; Console.WriteLine(counter);} while (counter >1);

            Console.ReadLine();
        }
    }
}
