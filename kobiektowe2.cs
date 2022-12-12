using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Koszyk
    {
        private int id;
        private Produkt(produkt); //kompozycja
        private Uzytkownik uzytkownik //agregacja

        public void getId(int id){
            this.id = id;
        }

        public void operation(){
            Console.WriteLine("Operacja??")
        }
    }

    class Produkt
    {
        private string name;
        private double cena;
        private string opis;

        public void getNazwa(string name)
        {
            this.nazwa = name;
        }

        public void getCena(double price){
            this.cena = price;
        }

        public void getOpis(string text){
            this.opis = text;
        }

        public Produkt(string name, double price, string text){
            return name, price, text;
        }

    }

    class Uzytkownik
    {
        private string login;
        private string haslo;
        private profil //kompozycja

        public void loguj(){
            Console.Write("login:"+login"\n hasło:"+haslo)
        } 

    }

    class Profil
    {
        private string imie;
        private string drugieimie;
        private string nazwsiko;
        
        public void getImie(){
            this.imie = aimie;
        }
        public void getNazwisko(){
            this.nazwisko = surname;
        }

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
