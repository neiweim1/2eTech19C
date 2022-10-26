using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*zad 1
        int n;
        Console.WriteLine("podaj n: ");
        n = int.Parse(Console.ReadLine());
        for (int i=1; i<=n; i++){
              Console.Write("*-|");
        }
        */
            /*tabliczka mnożenia
              for (int i=1; i<11; i++){
                    for (int j=1; j<=11; j++){
                      Console.Write(i*j+"\t");
                    }
                Console.WriteLine();*/
            //gwiazdki
            /*
            int n = 0;
            for (int i = 5; i > n; i--)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*" + "\t");
                }
                Console.WriteLine();
            }
            */
            //zad2
            /*
            int n;
            Console.WriteLine("podaj n:");
            n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("∗|| ∗ ∗ − − ∗ ∗ ∗");
            }
            */
            //trojkaty
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (n - i + 1 >= j) Console.WriteLine("*");
                    else Console.WriteLine(" ");
                }
                
            }
            Console.WriteLine();
            */
            //zad7
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    /*if  Console.WriteLine("*");
                    else Console.WriteLine(" ");*/
                    if (i == 1 || j == 1 || j == n || i == n || (i == n/2+1 && j==n/2+1)) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
