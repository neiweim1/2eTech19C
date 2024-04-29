using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    static class Matma
    {
        public static int bin2dec(string s)
        {
            int w = 0;
            for(int i = 0; i < s.Length; i++)
            {
                w = w + Convert.ToInt32(Math.Pow(2, i)) * (s[s.Length-i-1]-'0');
            }
            return w;
        }
    }
    interface ITemperatura
    {
        int WypiszMaxTemp();
        int WypiszMinTemp();
    }
    class Dane
    {
        public static Dictionary<string, string> odczyt { get; set; }

        public static void OdczytajDane()
        {
            FileStream fs = new FileStream("C:\\Users\\Student\\source\\repos\\ConsoleApp16\\dane\\dane_systemy1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] line = new string[2];
            odczyt = new Dictionary<string, string>();
            while(!sr.EndOfStream)
            {
                line = sr.ReadLine().Split();
                odczyt.Add(line[0], line[1]);
            }
            foreach(var item in odczyt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(odczyt);

        }
    }
    class Stacja : ITemperatura
    {
        Dane dane;
        public int WypiszMaxTemp()
        {
            string filePath = "decimalNumber.txt";
            using (StreamReader sr = new StreamReader(filePath))
            {
                string fileContent = sr.ReadToEnd();
                int decimalNumber = int.Parse(fileContent);
                int normalNumber = decimalNumber;
                return normalNumber;
            }
        }
        public int WypiszMinTemp()
        {
            return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dane.OdczytajDane();
            Console.WriteLine(Dane.odczyt);
            Console.ReadKey();
        }
    }
}
