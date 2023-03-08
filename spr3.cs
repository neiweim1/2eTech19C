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
    }
    class PC : Komputer
    {
        public string Rodzaj_obudowy { get; set; }
    }

    class Laptop : Komputer
    { 
        public float Dlugosc_przekatnej { get; set; } //najszybszy sposob
        private string kolor_obudowy;
        public string getKolor_obudowy() { return kolor_obudowy; } //ten dluzszy get
        public void setKolor_obudowy(string kolor) { this.kolor_obudowy = kolor; } //ten dluzszy set
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
    }

    class Naprawa
    {
        Zlecenie azlecenie { get; }
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
        }
    }
}
