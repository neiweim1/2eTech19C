using ConsoleApp13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    //adapter c#
    public interface AdapteeInterface 
    {
        string AdapteeInter();   
    }

    public class Adaptee
    {
        public void Adoptuje(string pet)
        {
            Console.WriteLine("Adoptuje "+pet);
        }
    }

    class Adapter : AdapteeInterface
    {
        Adaptee adaptee1 = new Adaptee();
        public Adapter(Adaptee adaptee)
        {
            this.adaptee1 = adaptee;
        }
        public string AdapteeInter()
        {
            Console.WriteLine("dawaj zwierze jakieś");
            return Console.ReadLine();
        }
    }
    

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee a = new Adaptee();
            AdapteeInterface target = new Adapter(a);
            a.Adoptuje(target.AdapteeInter());
        }
    }

