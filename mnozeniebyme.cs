using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IKalkulator
    {
        int A { get; set; }
        int B { get; set; }
        double M { get; set; }
        void Mnozenie(int A, int B);
    }

    interface IPotegowanie
    {
        double P { get; set; }
        void Potegowanie();
    }

    class Kalkulator : IKalkulator
    {
        public int A { get; set; }
        public int B { get; set; }
        public double M { get; set; }
        public void Mnozenie(int a = 5, int b=9) 
        {
            this.A = a;
            this.B = b;
            this.M = this.A*this.B;
            Console.WriteLine($"Mnożenie:\n{this.A}*{this.B}={this.M}");
        }

        public int GetA()
        {
            return this.A;
        }
    }

    class Adapter : IPotegowanie
    {
        Kalkulator k = new Kalkulator();
        public double P { get; set; }
        public void Mnozenie(int a, int b) 
        {
            k.Mnozenie(a, b);
        }
        
        public void Potegowanie()
        {
            int a = k.GetA();
            P = a * a;
            Console.WriteLine($"Potęgowanie:\n{a}^2={P}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            adapter.Mnozenie(x, y);
            adapter.Potegowanie();

        }
    }
}
