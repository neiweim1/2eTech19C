using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Auto
    {
        abstract public string model { get; set; }
    }

    class Audi : Auto
    {
        private string amodel;
        public override string model {
            get { return amodel; }
            set { amodel = value; } 
        }

    }

    class Mercedes : Auto
    {
        public override string model { get; set; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            audi.model = Console.ReadLine();
            Console.WriteLine(audi.model);

            
        }
    }
}
