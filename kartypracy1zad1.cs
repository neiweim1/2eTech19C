using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool kp2z2(int a)
        {
            return a >= 100 && a < 1000 && a % 17 == 0 ? true : false;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (kp2z2(a))
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
        }
    }
}
