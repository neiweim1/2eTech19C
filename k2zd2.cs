using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool kp2z6(int a, int p)
        {
            return p%2==0 ? true:false;
        }

        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            if (kp2z6(a, p) == false) { Console.WriteLine($"nie"); }
            else { Console.WriteLine($"tak"); }
        }
    }
}
