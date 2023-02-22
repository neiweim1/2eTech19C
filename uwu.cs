using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Student
    {
        public string imie;
        public int numer;
    }
    
    class Student2
    {
        private int num;
        private string name;

        public int GetNum()
        {
            return num;
        }

        public void setNum(int num)
        {
            this.num = num;
        }

        public string GetName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }
    class Student3
    {
        private string name;
        private int num;
        private int wiek;
        public string Name { get => name; set => name = value; }
        public int Num {
            get 
            {
                return this.num;
            }
            set
            {
                this.num = value;
            } 
        }

        public int Wiek { get => wiek;set => wiek = value; }
    }

    class Student4
    {
        public int Num { get; set; }
        public string Name { get; set; }
    }

    class Animal
    {
        public string Name { get; set; }
        public bool Domestic { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine("how how");
        }
    }

    class Pies : Animal
    {
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine(Name+" How from doggie");
        }
    }

    class Wilk : Animal
    {
        public override void Introduce()
        {
            Console.WriteLine(Name + " woo od wilka");
        }
    }

    class Firma
    {
        protected string nip;
        public virtual string Nip
        {
            get
            {
                return nip + " - to nip firmy";
            }
            
        }

        public Firma(string nip)
        {
            this.nip = nip;
        }
    }

    class Polska : Firma
    {
        public override string Nip
        {
            get
            {
                return "PL " + base.Nip;
            }
        }

        public Polska(string nip) : base(nip)
        {
            
        }
    }

    class Deutschland: Firma
    {
        public override string Nip
        {
            get
            {
                return "DE " + base.Nip;
            }
        }

        public Deutschland(string nip) : base(nip)
        {

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //pierwsza klasa taka banalna
            Student s1 = new Student();
            s1.imie = "Bolesława";
            s1.numer= 1;
            Console.WriteLine("klasa student banalna " + s1.numer + " " + s1.imie);

            //druga klasa z seterami i geterami więcej pisania
            Student2 s2= new Student2();
            s2.setNum(6);
            s2.setName("Sławomir");
            Console.WriteLine("klasa seterami i geterami " + s2.GetName() + " " + s2.GetNum());

            //trzecia klasa te szybsze (set;get;)
            Student3 s3 = new Student3();
            s3.Name = "Bartek";
            s3.Num = 2;
            s3.Wiek= 10;
            Console.WriteLine("klasa ta trzecia no " + s3.Name + ", " + s3.Num+", wiek: "+s3.Wiek);

            //czwarta co jest XD
            Student4 s4 = new Student4();
            s4.Num = 99;
            s4.Name = "Dawid Jasper";
            Console.WriteLine("XD "+s4.Num+" "+s4.Name);
            */
            /*
            Pies p = new Pies();
            p.Name = "test";
            p.Introduce();
            Wilk w = new Wilk();
            w.Name = "uwu";
            w.Introduce();
            */
            Polska pol = new Polska("123-123-321");
            Console.WriteLine(pol.Nip);
            Deutschland de = new Deutschland("666-666-666");
            Console.WriteLine(de.Nip);
            
        }
    }
}
