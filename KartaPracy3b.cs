using System;
 
namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            //zad 1
            /*
            Console.WriteLine("Dni listopada: ");
            for (int i=1; i<=30;i++) 
            {
                Console.Write(i + ", ");
            }
            */
            //zad 2
            /*
            int n;
            Console.WriteLine("Podaj liczbe: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i=i+2) { Console.WriteLine(i*i); }
            */
            //zad 3
            /*
            for (int i = 100; i < 1000; i=i++) 
            { 
                if (i%379==0){Console.WriteLine(i);} 
            }
            */
            //zad 4
            /*
            for (int i = 100; i <1000; i++)
            {
                if (i%5==0 || i%6==0 || i % 11 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //zad 5
            /*
            int n;
            int suma=0;
            Console.WriteLine("Podaj ile liczb chcesz podać: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int a;
                Console.WriteLine("Podaj liczbe: ");
                a = int.Parse(Console.ReadLine());
                suma += a;
            }
            Console.WriteLine(suma);
            */

            //zad 8
            /*
            Console.WriteLine("Podaj kwotę wejściową: ");
            double w0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ile trwa ten okres inwestycji: ");
            double l = double.Parse(Console.ReadLine())*12;
            while (true)
            {
                if (l - 12 >=0)
                {
                    w0 *= 1.06;
                    l -= 12;
                }
                else
                {
                    w0 *= 1.03;
                    break;

                }
            }
            Console.WriteLine($"Kwota wyjościowa {w0}");
            */
            //zad 9

            //zad 10
            /*
            for (int i = 1; i < 1000; i++)
            {
                if (Math.Sqrt(i)%1==0)
                {
                    Console.WriteLine(i);
                }
            }
            */
        }
    }
}
