using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mediumy!!!
            //zad4
            /*
            int ile=0;
            for (int i = 10; i < 100; i++)
            {
                int dziesiec = (i/10) % 10, jednosci = i % 10;
                if (dziesiec > jednosci*2) ile++;
                
            }
            Console.WriteLine(ile);
            */
            //zad5
            /*
            int sj = 0, sd = 0, s = 0, jednosci, setki, dziesiatki, tmp, ile=0; 
            Console.WriteLine("zad 5");
            for (int i=100; i < 1000; i++)
            {
                tmp = i;
                jednosci = tmp % 10;
                tmp/=10;
                dziesiatki = tmp % 10;
                tmp /= 10;
                setki = tmp % 10;
                Console.WriteLine(setki+","+dziesiatki+","+jednosci);
                if(setki>dziesiatki+jednosci)
                {
                    s += i;
                    ile += 1;
                }
                

            }
            Console.WriteLine("suma "+s+"\n ilosc "+ile);
            */

            //zad6
            /*
            int s = 0;
            int n = int.Parse(Console.ReadLine());
            for(int j=10; j<100; j++)
            {
                if (j % 19==0)
                {
                    Console.WriteLine(j+" liczby");
                    s += j;
                    n--;
                    if (n == 0) break;
                }
            }
            Console.WriteLine(s+" suma");
            */
            //zad7
            /*
            int s = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i=999; i>99; i--)
            {
                if (i % 37 == 0)
                {
                    Console.WriteLine(i+" liczby");
                    s += i;
                    n--;
                    if (n == 0) break;
                }
            }
            Console.WriteLine(s+" suma");
            */
            /*
            //zad8
            int s = 0, z = 2, x = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                s += z*x;
                Console.WriteLine($"{z},{x},{i}");
                z += 3;
                x *= -1;
                
            }
            Console.WriteLine(s+" suma");
            */
            //zad9
            /*
            int il = 1, z = 1, x = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                il *= z * x;
                Console.WriteLine($"{z},{x},{i}");
                z *= 2;
                x *= -1;

            }
            Console.WriteLine(il + " iloczyn");
            */
        }
    }
}
