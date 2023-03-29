using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /*
    interface IOdprawa
    {
        void Odprawsie();
    }

    abstract class Osoba
    {
        public string Name { get; set; }
        public abstract void Odprawsie2();
    }

    class Kierownik : Osoba, IOdprawa 
    {
        public override void Odprawsie2()
        {
            Console.WriteLine(" ");
        }
        public void Odprawsie()
        {
            Console.WriteLine("kierownik");
        }
    }
    */

    interface IRemote
    {
        void Zdalnie();
    }

    interface IKeyless
    {
        void wejdz();
    }

    abstract class Auto
    {
        public string Model { get; set; }
        public virtual void jedz()
        {
            Console.WriteLine("brunm");
        }

    }

    class Audi : Auto, IRemote, IKeyless
    {
        
        public override void jedz()
        {
            base.jedz();
            Console.WriteLine("twoje audi: "+Model);
        }
        public void wejdz()
        {
            Console.WriteLine("w");
        }
        public void Zdalnie()
        {
            Console.WriteLine("z");
        }
    }

    class BMW : Auto, IRemote
    {
        public override void jedz()
        {
            base.jedz();
            Console.WriteLine("twoje BMW: " + Model);
        }
        public void Zdalnie()//z intefejsu jesli by nie bylo interfejsu to bylaby to metoda z tej klasy
        {
            Console.WriteLine("z");
        }
    }

    class Mercedes : Auto, IKeyless
    {
        public override void jedz()
        {
            base.jedz();
            Console.WriteLine("twoje mercedes: " + Model);
        }
        public void wejdz()
        {
            Console.WriteLine("w");
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Mercedes m = new Mercedes();
            m.Model = Console.ReadLine();
            Console.WriteLine($"twoj mercedes m:{m.Model}") ;
            m.wejdz() ;
            m.jedz() ;
        }
    }
}
