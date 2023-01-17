using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rower
    {
        string color;
        Material material; //agregacja
        Producent producent; //kompozycja
        Kurwa kurwo; //asocjacja 

        //agregacja biala - setery!! this!! void!!
        //kompozycja nigga - metody!! >zaden return i zaden static< i konstruktor!! wywoluje ta klase jako metode no konsturktor idioto
        //asocjacja strzalka ig - konstuktor ale uposledzony nwm

        public void jedz()
        {
            Console.WriteLine("brum brum");
        }

        public void setColor(string acolor) //setery maja this i sa void
        {
            this.color = acolor;
        }

        public string getColor(string color) //getery maja typ zmiennej i return
        {
            return color;
        }
        //!zaleznosci!
        public void setMaterial(Material amaterial)//agregacja
        {
            this.material= amaterial;
        }

        public Rower(Producent aproducent)//kompozycja
        {
           this.producent = aproducent;
        }
        
        public void maszKurwe(Kurwa kurwo)//asocjacja
        {
            this.kurwo = kurwo;
        }


    }

    class Material
    {
        string typ;
    }

    class Producent
    {
        string name;

    }

    class Kurwa
    {
        int uwu;
        
        public Kurwa(int uwu)
        {
            this.uwu = uwu;
        }
        
        
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Producent p1 = new Producent();
            Material m1 = new Material();
            Rower r1 = new Rower(p1);
            r1.setMaterial(m1);

        }
    }
}
