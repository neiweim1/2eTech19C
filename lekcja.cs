using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Herbata
    {
        public string krajpochodzenia;
        public string nazwa;
        public string aromat;
        public static void sparz()
        {
            Console.WriteLine("Sparz");
        }
    }
    class Termos
    {
        private int pojemnosc;
        private int waga;
        private float cena;
        private Herbata zawartosc;

        //poczatek getery i setery
        public int setpojemnosc()
        {
            return pojemnosc;
        }

        public void getpojemnosc(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }

        public int setwaga()
        {
            return waga;
        }

        public void getwaga(int waga)
        {
            this.waga = waga;
        }

        public float setcena()
        {
            return cena;
        }

        public void getcena(float cena)
        {
            this.cena = cena;
        }

        public Herbata setzawartosc()
        {
            return zawartosc;
        }

        public void getzawartosc(Herbata zawartosc)
        {
            this.zawartosc = zawartosc;
        }
        public Termos(Herbata aherbata)
        {
            this.zawartosc = aherbata;
        }

        //koniec getery i setery

        public static void polej()
        {
            Console.WriteLine("polej");
        }

        public static void umyj()
        {
            Console.WriteLine("umyj");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Herbata zielona = new Herbata();
            zielona.krajpochodzenia = "Kolumbia";
            Termos aha = new Termos(zielona);


        }
    }
}
