using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    interface IWagaOceny
    {
        void WagaOceny();
    }

    interface IUsprawiedliw
    {
        void Usprawiedliw();
    }

    interface IZwolnij
    {
        void Zwolnij();
    }

    abstract class Osoba
    {
        public abstract string imie { get; set; }
        public abstract void Przedstaw();
    }

    class Nauczyciel : Osoba
    {
        List<Ocena> Ocena;
        public override string imie { get; set; }
        public override void Przedstaw()
        {
            Console.WriteLine($"Nauczyciel: {imie}");
        }
        public void WystawOcene(Ocena ocena)
        {
            Ocena.Add(ocena);
        }
    }

    class Uczen : Osoba
    {
        public override string imie { get; set; }
        public override void Przedstaw()
        {
            Console.WriteLine($"Uczeń: {imie}");
        }
    }

    class Rodzic : Osoba, IUsprawiedliw
    {
        public override string imie { get; set; }
        public override void Przedstaw()
        {
            Console.WriteLine($"Rodzic: {imie}");
        }

        public void Usprawiedliw()
        {
            Console.WriteLine("usprawiedliwiam");
        }
    }

    abstract class Admin : Osoba
    {
  
    }

    class Dyrektor : Admin
    {
        public override string imie { get; set; }
        public override void Przedstaw()
        {
            Console.WriteLine("ma uprawnienia lol");
        }

    }

    class Wychowawca : Admin, IZwolnij
    {
        public override string imie { get; set; }
        public override void Przedstaw()
        {
            Console.WriteLine("uprawnienia jakies");
        }

        public void Zwolnij() 
        {
            Console.WriteLine("zwalniam");
        }
    }

    abstract class Ocena
    {
        public string Wartosc { get; set; }

    }

    class Stopien : Ocena, IWagaOceny
    {
        public void WagaOceny()
        {
            throw new NotImplementedException();
        }
    }
    class Opisowa : Ocena { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ocena oc1 = new Stopien();
            oc1.Wartosc = "6";
            oc1.
        }
    }
}
