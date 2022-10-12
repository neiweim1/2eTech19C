using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool kp3z1(n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * i * i + 3 +" ");
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            kp3z1(n);
        }
    }
}
