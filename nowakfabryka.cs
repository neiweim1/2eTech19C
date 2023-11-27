using System;
namespace AgataMeble
{
    //interfejsy serii mebli
    interface MebleKuchnia
    {
        //meble
    }
    interface MeblePokoj
    {
        //meble
    }
    interface MebleLazienka
    {
        //meble
    }

    //interfejsy które tyczą się tych czynności XD
    interface MeblujLa
    {
        void InstalujArmature();
    }

    interface MeblujKu
    {
        void AGD();
    }

    interface MeblujPo
    {
        void Mebluje();
    }


    //Konkeretne serie mebli, które wejdą w skład mebli mieszkania
    class Cytrynka : MebleKuchnia
    {
        //serie
    }
    class Pomaranczko : MebleKuchnia
    {
        //serie
    }

    class Bananik : MebleKuchnia
    {
        //serie
    }

    class Jasmin: MebleLazienka
    { 
        //serie
    }

    class Polysk : MebleLazienka
    {
        //serie
    }

    class Mat: MebleLazienka
    {
        //serie
    }

    class Piotr: MeblePokoj                                                                                                           
    {
        //serie
    }

    class Kasia : MeblePokoj
    {
        //serie
    }

    interface Fabryka
    {
        MebleLazienka UmeblujLazienke();
        MebleKuchnia UmeblujKuchnie();
        MeblePokoj UmeblujPokoj();
    }

    class Mieszkanie1 : Fabryka, MeblujPo, MeblujLa, MeblujKu
    {
        MebleKuchnia mk;
        MebleLazienka ml;
        MeblePokoj mp;
        public MebleKuchnia UmeblujKuchnie()
        {
            return new Cytrynka();
        }

        public MebleLazienka UmeblujLazienke()
        {
            return new Jasmin();
        }

        public MeblePokoj UmeblujPokoj()
        {
            return new Kasia();
        }

        Mieszkanie1(MebleLazienka ml, MebleKuchnia mk, MeblePokoj mp)
        {
            this.ml = ml;
            this.mk = mk;
            this.mp = mp;
        }

        public void Mebluje()
        {
            Console.WriteLine("posiadam");
        }

        public void InstalujArmature()
        {
            Console.WriteLine("posiadam Armature");
        }

        public void AGD()
        {
            Console.WriteLine("posiadam AGD");
        }

    }

    /*
    interface Fabryka: PodFabryka1, PodFabryka2
    {
        
        MeblePokoj MeblePokoj { get; set; }
        MebleKuchnia MebleKuchnia { get; set; }
        MebleLazienka MebleLazienka { get; set; }
        
    }

     interface PodKuchnia :  MeblujKu{ 
        //funkcja
    }

    interface PodLazienka : MeblujLa
    {
        //funkcja
    }

    interface PodPokoj : MeblujPo{

    }
    */
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
