using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract public class MenuComponent//kompozytor
    {
        public string name { get; set; }
        public void addComponent(MenuComponent mc) { }
        public abstract void Display();
    }

    public class MenuItem : MenuComponent//leaf#1
    {
        public MenuItem(string name) 
        {
            this.name = name;
        }
        public override void Display()
        {
            Console.WriteLine("nazwa: "+name);
        }
    }

    public class MenuComposite : MenuComponent 
    {
        List<MenuComponent> LMC = new List<MenuComponent>();

        public override void Display()
        {
            Console.WriteLine("Wyświetl komponenty:"+LMC); ;
        }

        public new void addComponent(MenuComponent mc)
        {
            LMC.Add(mc);
        }

        public void MenuComposit()
        {

        }
    }

    public class Menu
    {

    }

    internal class Program
    {
        

        
        static void Main(string[] args)
        {

        }
    }
}
