using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /* public static bool kp3z1(n)
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
         }*/
        public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();
            for (int i = 0; i <x+1; i++)
            {
                if (x%i == 0)
                {
                    alist.Add(i);
                }
            }
            return alist;
        }
        static void Main(string[] args)
        {
            ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach (int a in dzielniki)
            {
                Console.Write(a+" ")
            }
        }

    }
}
