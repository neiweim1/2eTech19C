using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rower
    {
        
        private string color;
        public string material; // agregacja
        public Producent producent; // kompozycja
        public Producent(name Lukasz, nip 123){
            this.name = Lukasz;
            this.nip = 123;
        }

        public void setMaterial(Material cos){
            this.material = cos;
        }

        public void jedz(){
            Console.WriteLine("jadę");
        }

        public string setColor(){
            return color;
        }

        public void getColor(string kolor){
            this.color = kolor;
        }

    }

    class Producent
    {
        private string name;
        private string nip;
        
        public string setNazwa(){
            return name;
        }
        public void getNazwar(string nazwa){
            this.name = nazwa;
        }

        public void getNip(string nip){
            this.nip = nip;
        }
    }

    class Material
    {
        private string typ;
        private int id;
        private double cena;

        public string setTyp(){
            return typ;
        }

        public void getTyp(string typ){
            this.typ = typ;
        }

        public void getCena(double price){
            this.cena = price;
        }

        public int setId(){
            return id;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
