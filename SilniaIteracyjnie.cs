using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int Silnia(int n) 
        {
            /*if (n == 0)
            {
                return 1;
            }
            return n * Silnia(n - 1);*/
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik *= i;
            }
            return wynik;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Silnia(n));
        }
    }
}
