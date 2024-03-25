using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    interface ISekretariat
    {
        void DodajUczniaDoSzkoły();
        void UsuńUczniaZeSzkoły();
    }


    interface ITworzeniePlanu
    {
        void StwórzPlanLekcji();
    }

    interface IWdrozeniePlanu
    {
        void PrzypiszUczniówDoLekcji();
    }

    abstract class Osoba
    {
        public string name { get; set; }
        public string surname { get; set; }
    }
    class Sekretarka : Osoba { }
    class Nauczyciel : Osoba { }
    class Dyrektor : Osoba { }

    class Sekretariat : ISekretariat
    {
        public Osoba Pracownik { get; set; }
        public void DodajUczniaDoSzkoły()
        {
            Console.WriteLine("diodanto uyczbua");
        }
        public void UsuńUczniaZeSzkoły()
        {
            Console.WriteLine("usunieto ycznia");
        }
    }

    class Plan : ITworzeniePlanu, IWdrozeniePlanu
    {
        public Osoba Planista { get; set; }
        public void StwórzPlanLekcji()
        {
            Console.WriteLine("Stworz plan");
        }

        public void PrzypiszUczniówDoLekcji(){
            Console.WriteLine("Przypisz uczniow");
        }
    } 
    /*
    class ObsługaSzkołyPrzezNauczycielaISekretariat : ISzkolny
    {
        public void DodajUczniaDoSzkoły()
        {

            if ("rola sekretarka" == "yes")
            {
                Console.WriteLine("dodaje");
            }
        }

        public void PrzypiszUczniówDoLekcji()
        {
            throw new NotImplementedException();
        }

        public void StwórzPlanLekcji()
        {
            // to by robił nauczyciel specjalny od planu
            throw new NotImplementedException();
        }

        public void UsuńUczniaZeSzkoły()
        {
            // to by robił dyrektor
            throw new NotImplementedException();
        }
    }
    */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
