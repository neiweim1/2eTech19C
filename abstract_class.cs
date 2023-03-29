using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /*abstract class Osoba //abstrakcyjjna!! klasa ma być klasą bazową innych klas, a nie tworzone samodzielnie. Składowe oznaczone jako abstrakcyjne muszą być implementowane przez klasy nie abstrakcyjne, które pochodzą z klasy abstrakcyjnej.
    {
        public string Name { get; set; } //prop skrót + tab
        private int id;
        public Osoba() { } //jak chcemy żeby działało przy abstract nie stosujesz tego!!1
        private Osoba(string name, int id) //aby zablokować dostęp do tworzenia Osoby ale sie nie poleca tego
        {
            Name = name;
            this.id = id;
        }
        
    }*/
    abstract class Osoba //jak tworzymy abstrakcyjna metode to musi tez byc klasa!
    {
        public abstract void Witaj();//metody abstrakcyjne nie maja klamr!! a zwykłe to musi mieć klamry
        public void Zegnaj()
        {
            Console.WriteLine("zegnaj");
        }

    }
    class Pracownik : Osoba
    {
        public override void Witaj() 
        {

        }
    }

    class Kierownik : Osoba
    {
        public override void Witaj()
        {
           
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
