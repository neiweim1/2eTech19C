using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    class Dostawa
    {
        public int NumerPrzesyłki { get; set; }
        public virtual void Przygotuj()
        {
            Console.WriteLine("Paczka jest przygotowana :)");
        }
        public virtual void WyswietlSzczegoly()
        {
        }
    }

    class Poczta : Dostawa
    {
        public string Urząd_nadania { get; set; }
        public override void WyswietlSzczegoly()
        {
            base.WyswietlSzczegoly();
            Console.WriteLine("Urząd nadania: {0}", Urząd_nadania);
        }
    }
    class Paczkomat : Dostawa
    {
        public int Nr_paczkomatu { get; set; }
        public override void WyswietlSzczegoly()
        {
            base.WyswietlSzczegoly();
            Console.WriteLine("Numer Paczkomatu: {0}", Nr_paczkomatu);
        }
    }
    class Sprzedawca
    {
        public Faktura faktura { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public void ZatwierdzenieZamowienia()
        {
            Console.WriteLine("Potwierdzić zamówienie?");
            Console.WriteLine("1-TAK");
            Console.WriteLine("2-NIE");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Zamówienie potwierdzone");
            }
            else Console.WriteLine("Zamówienie odrzucone");
        }
        public void GenerowanieWysylki()
        {
            Console.WriteLine("Wysyłka została wygenerowana");
        }
        public void GenerowanieFaktury()
        {
            Console.WriteLine("Faktura do zamówienia została wygenerowana");
        }
        public void SetSprzedawca(Faktura faktura)
        {
            this.faktura = faktura;
        }
    }
    class Klient
    {
        public Zamowienie zamowienie { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public void ZamawianieCzesci()
        {
            Console.WriteLine("Zamówiłeś części");
        }
        public void SposobDostawy()
        {
            Console.WriteLine("Wybierz sposób dostawy:");
            Console.WriteLine("1-PACZKOMAT");
            Console.WriteLine("2-POCZTA");


        }
    }
    class Kurier : Dostawa
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Nr_tel { get; set; }
        public override void WyswietlSzczegoly()
        {
            base.WyswietlSzczegoly();
            Console.WriteLine("Numer telefonu: {0}, imie {1}, nazwisko {2}", Nr_tel, Imie, Nazwisko);
        }
    }
    class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public void PakowanieZamowienia()
        {
            Console.WriteLine("Zamówienie zostało spakowane");
        }
    }
    class Faktura : Dostawa
    {
        public Sprzedawca sprzedawca;

        public string Nr_faktury { get; set; }
        public void SetFaktura(Sprzedawca sprzedawca)
        {
            this.sprzedawca = sprzedawca;
        }
        public void GenerowanieFaktury()
        {
            Console.WriteLine("Faktura została wygenerowana");
        }

    }
    class Zamowienie
    {
        public Klient klient;
        public Sprzedawca sprzedawca;
        public int Nr_Zamowienia { get; set; }
        public void SetZamowienie(Klient klient, Sprzedawca sprzedawca)
        {
            this.klient = klient;
            this.sprzedawca = sprzedawca;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wybierz sposób dostawy:");
            Console.WriteLine("1-KURIER");
            Console.WriteLine("2-PACZKOMAT");
            Console.WriteLine("3-POCZTA");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Kurier kurier1 = new Kurier();
                        kurier1.Imie = "Mateusz";
                        kurier1.Nazwisko = "Xsowski";
                        kurier1.Nr_tel = 123;
                        kurier1.WyswietlSzczegoly();
                        kurier1.Przygotuj();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Paczkomat paczkomat = new Paczkomat();
                        Console.WriteLine("Podaj numer paczkomatu, do którego ma trafić twoja paczka");
                        paczkomat.Nr_paczkomatu = int.Parse(Console.ReadLine());
                        paczkomat.WyswietlSzczegoly();
                        paczkomat.Przygotuj();
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Poczta poczta = new Poczta();
                        Console.WriteLine("Podaj nazwę placówki, na którą ma trafić Twoja paczka");
                        poczta.Urząd_nadania = Console.ReadLine();
                        poczta.WyswietlSzczegoly();
                        poczta.Przygotuj();
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Podany numer jest nieprawidłowy");
                        Console.ReadKey();

                        break;
                    }
            }
        }

    }
}
