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

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
