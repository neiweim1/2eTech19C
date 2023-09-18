using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    interface Discount
    {

    }

    interface Shipment
    {

    }

    class Magazynier
    {
        public static void Magazynuje(string rzecz, string name, string surname)
        {
            Console.WriteLine($"Magazynier: {name} {surname} \nPrzedmiot: {rzecz}");
        }
    }

    internal class Towar
    {
        public static void Zamowienie(string rzecz, int ile)
        {
            Rodzaj z1 = new Rodzaj();
            if (z1.Kategoria(rzecz) == "") Console.WriteLine("błąd");
            else
            {
                Polka.Ilosc(ile, z1.Kategoria(rzecz));
                if (Seria.Kod(rzecz) > 0)
                {
                    Console.WriteLine("Zamówienie dostępne");
                    Console.WriteLine("kod: " + Seria.Kod(rzecz));
                    Magazynier.Magazynuje(z1.Kategoria(rzecz), "Bartosz", "Wancek");
                }
                else
                {
                    Console.WriteLine("niepoprawna wartość");
                }
            }
        }
    }

    class Rodzaj
    {
        public string Kategoria(string rzecz)
        {
            if (rzecz == "meble" || rzecz == "pościele" || rzecz == "kwiaty")
            {
                return rzecz;
            }
            else { return ""; }
        }
    }

    class Polka
    {
        public static void Ilosc(int ile, string rzecz)
        {
            if (ile <= 100 && ile > 0) Console.WriteLine("ilość: " + ile + " przedmiot:" + rzecz);
            else Console.WriteLine("niepoprawna ilość");
        }
    }

    class Seria
    {
        public static int Kod(string rzecz)
        {
            if (rzecz == "pościele") return 111;
            if (rzecz == "meble") return 333;
            if (rzecz == "kwiaty") return 222;
            else return 0;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Towar.Zamowienie("meble", 85);
            Towar.Zamowienie("uwu", 2);
            Towar.Zamowienie("kwiaty", 200);
            Towar.Zamowienie("pościele", 55);
        }
    }
}
