using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	public delegate string Dele(int a, int b);
	internal static class cos
	{
		public static string suma2(int a, int b)
		{
			return "wynik: " + Convert.ToString(a + b);
		}
	}
	internal class Program
	{
		public static int s=0;
		public static string suma(int a, int b)
		{
			s=s+a+b;
			return "wynik dodawania: "+Convert.ToString(a+b);
		}

		public static string iloczyn(int a, int b)
		{
			s = s + a * b;
			return "wynik mnozenia: " + Convert.ToString(a * b);
		}
		/*
		 * Delegat to typ reprezentujący odwołania do metod z określoną listą parametrów i zwracanym typem. Podczas tworzenia wystąpienia delegata można skojarzyć jego wystąpienie z dowolną metodą mającą zgodny podpis i zwracany typ. Za pośrednictwem wystąpienia delegata można wywołać metodę.
		 * Delegaty służą do przekazywania metod jako argumentów do innych metod. 
		 * Innymi słowy metoda musi mieć taki sam zwracany typ jak delegat.
		 * w zmiennych delegate są nazwy funkcji
		 */
		static void Main(string[] args)
		{
			Dele d1 = new Dele(suma);
			Dele d2 = new Dele(iloczyn);
			d1 = d1 + d2;
			d1(2, 3);
			Console.WriteLine(s);
			Dele d3 = new Dele (cos.suma2);
			Console.WriteLine(d3(4,5));

		}
	}
}
