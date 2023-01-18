using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sortowanie
    {
        public List<int> sortowanie(List<int> L)
        {
            for (int i=0; i<L.Count-1; i++)
            {
                for(int j=0; j<L.Count-1; i++)
                {
                    int tmp = L[j + 1];
                    L[j + 1] = L[j];
                    L[j] = tmp;
                }
            }
            return L;
        }
    }

    class Babelek : Sortowanie 
    {
        public List<int> sortuj(List<int> L)
        {
            for( int i=0;i<L.Count;i++)
            {

            }
            return L;
        }
    }

    class Debilizm : Sortowanie
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] D = new int[] { 4, 6, 7, 8, 2 };
            List<int> K = new List<int>() { 7, 3, 2, 5, 1};
            ArrayList A = new ArrayList() { 7, 3, 2, 5, 1 };
            for(int i=0; i<K.Count; i++)
            {
                Console.WriteLine(K[i]);
            }

            foreach (int i in D)
            {
                Console.WriteLine(i);
            }


        }
    }
}
