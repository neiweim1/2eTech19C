using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Komputer
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public virtual void Wyswietl()
        {
            Console.WriteLine($"Marka = {Marka}, Model = {Model}");
        }
    }
    class PC : Komputer
    {
        public string Rodzaj_obudowy { get; set; }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Rodzaj obudowy = {Rodzaj_obudowy}");
        }
    }

    class Laptop : Komputer
    { 
        public float Dlugosc_przekatnej { get; set; } //najszybszy sposob
        private string kolor_obudowy;
        public string getKolor_obudowy() { return kolor_obudowy; } //ten dluzszy get
        public void setKolor_obudowy(string kolor) { this.kolor_obudowy = kolor; } //ten dluzszy set

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Długość przekątnej = {Dlugosc_przekatnej} , Kolor obudowy = {kolor_obudowy}");
        }
    }

    class Osoba
    {
        string name;
        public string Name { get => name; set => name = value; } //name musi byc wczesniej zadeklarowany jak chcemy takie setery/getery
    }


    class Opiekun : Osoba
    {

    }

    class Klient : Osoba
    {
        
    }

    class Serwisant : Osoba
    {

    }

    class Zlecenie
    {
        Komputer akomputer; //polimorfizm? w sensie nie trzeba dodawac jeszcze pc ani laptopa niepotrzebnie tylko komputer jako sprzet 
        //pan powiedzial ze nie musi byc komp albo laptop cokolwiek tam moze byc XDDD nie wiem nie kumam
        //agregacja jest lepsza
        Klient aklient;
        Opiekun aopiekun;

        public Zlecenie(Komputer akomputer, Klient aklient, Opiekun aopiekun)
        {
            this.akomputer = akomputer;
            this.aklient = aklient;
            this.aopiekun = aopiekun;
        }

        
        public Komputer GetKomputer() { return akomputer; }
        public void SetKomputer(Komputer akomputer) { this.akomputer = akomputer; }

        public Klient GetKlient() { return aklient; }
        public void SetKlient(Klient aklient) { this.aklient = aklient; }

        public Opiekun GetOpiekun() { return aopiekun; }
        public void SetOpiekun(Opiekun aopiekun) { this.aopiekun = aopiekun; }
        //kazdego get/set mozna uzyc na spr
    }

    class Naprawa
    {
        Zlecenie azlecenie { get; set; }
        Serwisant aserwisant { get; set; }
        public void Setzlecenie(Zlecenie azlecenie)
        {
            this.azlecenie = azlecenie;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            //proste banalne
            /*
            Laptop lap = new Laptop();
            lap.Marka = Console.ReadLine();
            lap.Model = Console.ReadLine();
            lap.Dlugosc_przekatnej = float.Parse(Console.ReadLine());
            lap.setKolor_obudowy(Console.ReadLine());

            Console.WriteLine($"{lap.Marka} + {lap.Model} + {lap.Dlugosc_przekatnej} + {lap.getKolor_obudowy()}"); //zapis jest zalezny od tego jakiego setera/getera uzyles ostatni to ten dluzszy np
            */
            //hard and creative
            bool b = true;
            while (b) {


                Console.Write("Co masz do naprawy? Laptop czy kloc?/ exit e");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "laptop":
                        Laptop lap = new Laptop();
                        lap.Marka = Console.ReadLine();
                        lap.Model = Console.ReadLine();
                        lap.Dlugosc_przekatnej = float.Parse(Console.ReadLine());
                        lap.setKolor_obudowy(Console.ReadLine());
                        lap.Wyswietl();
                        break;
                    case "komputer":
                        PC k = new PC();
                        k.Marka = Console.ReadLine();
                        k.Model = Console.ReadLine();
                        k.Rodzaj_obudowy = Console.ReadLine();
                        k.Wyswietl();
                        break;
                    case "e":
                        b = false;
                        break;
                    default: Console.WriteLine("błędna opcja, albo komputer albo laptop");
                        break;
                }
            }

        }
    }
}
