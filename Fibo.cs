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
        public static int Fibo(int n) 
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n > 2)
            {
                return 1;
            }
            return Fibo(n - 1)+Fibo(n-2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));
        }
    }
}
