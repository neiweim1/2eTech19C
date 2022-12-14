using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Koszyk
    {
        private int id;
        private Produkt produkt; //kompozycja metoda/konstruktor
        private Uzytkownik uzytkownik;//agregacja setery

        public void getId(int id)
        {
            this.id = id;
        }

        public void operation()
        {
            Console.WriteLine("Operacja??");
        }

        public Koszyk(int id, Produkt produkt)
        {
            this.id = id;
            this.produkt = produkt;
            
        }

        public void setUzytkownik(Uzytkownik user)
        {
            this.uzytkownik = user;
        }
    }

    class Produkt
    {
        private string name;
        private double price;
        private string opis;

        public void getName(string name)
        {
            this.name = name;
        }

        public void getCena(double price)
        {
            this.price = price;
        }

        public void getOpis(string text)
        {
            this.opis = text;
        }

        

    }

    class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil; //kompozycja

        public void loguj()
        {
            Console.Write("login:" + login+"\n hasło:" + haslo);
        }

        public Uzytkownik(Profil profil, string login, string haslo)
        {
            this.profil = profil;
            this.login = login;
            this.haslo = haslo;
        }

    }

    class Profil
    {
        private string imie;
        private string drugieimie;
        private string nazwisko;

        public void getImie(string imie)
        {
            this.imie = imie;
        }
        public void getNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
