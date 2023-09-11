using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //fasada strukturalna
    //wzorzec projektowy
    //asocjacja xwy
    class LoginAvailable
    {
        public void LoginCheck()
        {
            Console.WriteLine("login dostepny");
        } 
    }

    class Database
    {
        public static void insert()
        {
            Console.WriteLine("dodano usera");
        }
    }

    internal class User //mini fasadka?? XDDD w skrócie dodawnie z innych klas metod żeby nie pisać tysiąc razy trgo samego
    {
        public static void registerUser()
        { 
            LoginAvailable log = new LoginAvailable();
            log.LoginCheck();
            Database.insert();
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User.registerUser();
        }
    }
}
