using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Finanse
    {
        public int Cena {  get; set; }
        private Random rand = new Random();
        double wartosc;
        public double Rabatuje10(int Cena)
        {
            return Cena*0.90;

        }

        public double RabatujeLosowy(int Cena, double wartosc)
        {
            return (1 - (wartosc / 100d))*Cena;

        }

        public double Marzuje20(int Cena)
        {
            wartosc = 0.20;
            return (1-wartosc)*Cena;

        }

        public double MarzujeLosowy(int Cena, double wartosc)
        {
            return (1 + (wartosc / 100d)) * Cena;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
