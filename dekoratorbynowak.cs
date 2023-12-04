using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rower
    {
        public string name { get; set; }
        public void Jedz()
        {
            Console.WriteLine("jade" + name);
        }
    }

    class ERower
    {
        public Rower r { get; set; } //dekorator
        public void Laduj()
        {
            Console.WriteLine("laduje sie lol");
        }

        public void getRowerE()
        {
            Console.WriteLine(r.name);
        }

        public Rower GetRower()
        {
            return r;
        }

        public void getname(Rower r)
        {
            Console.WriteLine(r.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           ERower elektrycznyr = new ERower();
            Rower r1 = new Rower();
            elektrycznyr.r = r1;
            elektrycznyr.getname(elektrycznyr.GetRower());

        }
    }
}
