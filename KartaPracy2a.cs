using System;
 
namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            
            /* zad1
            float a, b;
            Console.WriteLine("podaj a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            b = float.Parse(Console.ReadLine());
            float s = a + b;
            if (s % 2 == 0)
            {
                Console.WriteLine("jest parzysta");
            }
            else
            {
                Console.WriteLine("jest nieparzysta");
            }
            */

            /*zad2
            double a, g, arithmetic, geomatic;
            Console.WriteLine("podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj g: ");
            g = double.Parse(Console.ReadLine());
            double w = a + g;
            arithmetic = w / 2;
            geomatic = Math.Pow(w, 1 / 2);
            Console.WriteLine("średnia artymetyczna podanych liczb to:" + arithmetic);
            Console.WriteLine("średnia geometryczna podanych liczb to:" + geomatic);
            if (arithmetic > geomatic)
            {
                Console.WriteLine("artymetyczna jest większa od geometrycznej");
            }
            else
            {
                Console.WriteLine("geometryczna jest większa od artymetycznej");
            }
            */

            /*zad3
            float k, l, m;
            Console.WriteLine("podaj k: ");
            k = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj l: ");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj m: ");
            m = float.Parse(Console.ReadLine());

            if (k == l || m == k || l == m)
            {
                Console.WriteLine("są równe sobie");
            }
            else
            {
                Console.WriteLine("nie są równe sobie");
            }
            */

            /*zad4
            float a, b, c, d;
            Console.WriteLine("podaj a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj c: ");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj d: ");
            d = float.Parse(Console.ReadLine());
            if (a<b && a<c && a < d)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c && b < d)
            {
                Console.WriteLine(b);
            }
            else if (c < b && c < a && c < d)
            {
                Console.WriteLine(c);
            }
            else if (d < a && d < b && d < c)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("cos zle wpisales :((");
            }
            */

            /*zad5
            float a, b, c;
            Console.WriteLine("podaj a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj c: ");
            c = float.Parse(Console.ReadLine());
            if (a<b+c || b<a+c || c < a + b)
            {
                Console.WriteLine("podane boki spełniają nierówności trójkąta");
            }
            else
            {
                Console.WriteLine("podane boki nie spełniają nierówności trójkąta");
            }
            */

            /*zad6
            float a, b, c;
            Console.WriteLine("podaj bok a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj bok b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj bok c: ");
            c = float.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && c < a + b && a < b + c && b < a + c)
            {
                Console.WriteLine("podane boki budują trójkąt i jest on:");
                if (a * a + b * b > c * c) { Console.Write("ostrokątny"); }
                else if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) { Console.Write("prostokątny"); }
                else
                {
                    Console.Write("rozwartokątny");
                }
            }
            else
            {
                Console.WriteLine("niepoprawne boki, nie ma takiego trójkąta");

            }
            */
        }
    }
}
