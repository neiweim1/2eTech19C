using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    interface IRomb
    {
        double Pole();
        int E { get; set; }
        int F { get; set; }
    }

    interface IRombzobwd
    {
        double Obw();
    }
    class Romb : IRomb
    {
        public int E { get; set; }
        public int F { get; set; }

        public double Pole()
        {
            return E * F / 2d;
        }

        public Romb(int e = 6, int f=8) 
        {
            E = e;
            F = f;
        }
    }

    class RombObw:IRombzobwd
    {
        public double Obw()
        {
            IRomb r = new Romb();
            double a = Math.Sqrt((r.E/2)*(r.E/2) + Math.Pow((r.F/2),2));
            return 4*a;
        }
    }

    class RombObwKlasowy : IRomb, IRombzobwd
    {
        public int E { get; set; }
        public int F { get; set; }
        public double Pole()
        {
            
            return 0d;
        }

        public RombObwKlasowy(int e = 2, int f = 5)
        {
            E = e;
            F = f;
        }

        public double Obw()
        {
            return 0d;
        }
}
    internal class Program
    {
        static void Main(string[] args)
        { 
            Romb romb = new Romb();
            Console.WriteLine(romb.Pole());


            RombObw rombObw = new RombObw();
            Console.WriteLine(rombObw.Obw());


            RombObwKlasowy k = new RombObwKlasowy();
            Console.WriteLine(k.Obw());

        }
    }
}

