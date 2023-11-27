using System;

interface IHandel
{
    void Info();
}

class Animal : IHandel
{
    public void Info()
    {
        Console.WriteLine("Kot czy pies?");
        string pet = Console.ReadLine();
        if (pet == null) Console.WriteLine("miałeś coś wpisać lolu");
        else if (pet == "kot") Console.WriteLine(pet);
        else if (pet == "pies") Console.WriteLine(pet);
        else Console.WriteLine("nic?");
    }
}

class Gatunek : IHandel
{
    public void Info()
    {
        Console.WriteLine("jakaś rasa");
    }
}

class SpecialForces : IHandel
{
    public void Info()
    {
        Console.WriteLine("Wojska specjalne");
    }
}

interface ISchronisko
{
    IHandel CreateInfantry();
    IHandel CreateArmored();
    IHandel CreateSpecialForces();
}

class ArmyFactory : ISchronisko
{
    public IHandel CreateInfantry()
    {
        return new Infantry();
    }

    public IHandel CreateArmored()
    {
        return new Armored();
    }

    public IHandel CreateSpecialForces()
    {
        return new SpecialForces();
    }
}

class Program
{
    static void Main()
    {

        ISchronisko factory = new ArmyFactory();


        IHandel infantry = factory.CreateInfantry();
        IHandel armored = factory.CreateArmored();
        IHandel specialForces = factory.CreateSpecialForces();


        infantry.Info();
        armored.Info();
        specialForces.Info();

    }
}
