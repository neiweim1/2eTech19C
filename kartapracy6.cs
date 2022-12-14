using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    internal class Program
    {
        //zad1
        /*public static bool artymetyczny(int a, int b, int c)
        {
            if ((c-b == b - a)||(a-b==b-c)) return true;
            else return false;
        }

        public static bool geometryczny(int a, int b, int c)
        {
            if (((b/a) * b == c) || (c*(a/b)==b)) return true;
            else return false;

        }

        public static bool rosnie(int a, int b, int c)
        {
            if (a<b && b<c) return true;
            return false;
        }
        static void Main(string[] args)
        {
            int[] tab = new int[3];
            for(int i= 0; i < 3; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            if (rosnie(tab[0], tab[1], tab[2])) Console.WriteLine("rosnący");
            else Console.WriteLine("malejący");
            if (artymetyczny(tab[0], tab[1], tab[2])) Console.WriteLine("artymetyczny ciąg");
            if (geometryczny(tab[0], tab[1], tab[2])) Console.WriteLine("geometryczny ciąg");


        }*/

        
        /*static void Main(string[] args)
        {
            //zad2
            int s = 0;
            for (int i = 100; i < 1000; i++)
            {
                if(i%8==0 && i % 16 != 0)
                {   
                    s += i;
                    Console.WriteLine(i);
                }
                

            }
            Console.WriteLine(s);

        }*/

    }
}
