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
        public static int Kp4z2(int n) 
        {
            int suma=0;
            int c;
            while (n > 0)
            {
                c = n % 10;
                suma += c;
                n = n / 10;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Kp4z2(n));
        }
    }
}
