using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    internal class ListaOsoba
    {
        public List<Osoba> Osobe { get; set; }

        public void DodajOsobu() 
        {   
            Osoba osoba = new Osoba();
            IspisString("Unesite ime osobe..");
            osoba.Ime = Console.ReadLine();
            IspisString("Unesite prezime osobe..");
            osoba.Prezime = Console.ReadLine();
            IspisString("Unesite dob osobe..");
            osoba.Godine = Convert.ToInt32(Console.ReadLine());
            IspisString($"Unijeli ste: Ime: {osoba.Ime}, Prezime: {osoba.Prezime}, Starost osobe: {osoba.Godine}");
            IspisString("Dali su podaci točni?");
            string odgovor = Console.ReadLine();
            if (odgovor.ToLower() == "da") 
            {
                Osobe.Add(osoba);
            }
            else if(odgovor.ToLower() == "ne")
            {
                IspisString("Doviđenja");
            }
            else
            {
                IspisString("Pokušajte sa novim unosom...");
                DodajOsobu();
            }
        }

        public void IzlistajOsobe()
        {
            foreach (Osoba o in Osobe)
            {
                if (o != null)
                {
                    IspisString($"Ime: {o.Ime}, Prezime: {o.Prezime}, Starost osobe: {o.Godine}");
                }
            }
        }

        private void IspisString(string recenica) 
        {
            foreach (char slovo in recenica)
            {
                Console.Write(slovo);
                Thread.Sleep(20);
            }
        }
    }
}
