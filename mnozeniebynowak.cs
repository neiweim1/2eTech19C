using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//KLASOWY!!!! ADAPTER JEST WAZNIEJSZY DLATEGO TAM WPISUJEMY RESZYE CZY COS TAM, NIE MAMY TWORZYC OBIEKTU KALKULATOR JAKO KLIENT / PROGRAM CHUJ WIE!!!!!!
namespace ConsoleApp1
{
    interface IKalkulator
    {
        int mnoz(int x, int y);
    }

    class Kalkulator : IKalkulator
    {
        public int mnoz(int a, int b)
        {
            return a * b;
        }
    }

    interface IPot
    {
        int pot(int z);
    }

    class Adapter : IPot, IKalkulator
    {
        public int mnoz(int a, int b)
        {
            return a * b;
        }

        public int pot(int a) 
        {
            return mnoz(a, a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPot pow = new Adapter();
            IKalkulator m = new Adapter();

            pow.pot(6);
            m.mnoz(8, 70);

        }
    }
}
