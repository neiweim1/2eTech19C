using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class User
    {
        string Name;
        int Id;
        public void Verify()
        {
            Console.WriteLine("User: Verify");

        }
        public void CheckAccount()
        {
            Console.WriteLine("User: CheckAccount");
        }

        public void get_book_info()
        {
            Console.WriteLine("User: get_book_info");
        }
    }

    internal class Account
    {
        string no_bb, no_rb, no_reb, no_lb;
        int fine_amount;

        public void Caclute_fine()
        {
            Console.WriteLine("Account: Caclute_Fine");
        }
    }

    internal class Book
    {
        string title, author, Publication;
        double isbn;

        public void Show_duedt()
        {
            Console.WriteLine("Book: Show_duedt");
        }

        public void Resevartion_status()
        {
            Console.WriteLine("Book: Resevartion_Status");
        }

        public void Feedback()
        {
            Console.WriteLine("Book: Feedback");
        }

        public void Book_request()
        {
            Console.WriteLine("Book: Book_request");
        }

        public void renw_info()
        {
            Console.WriteLine("Book: renw_info");
        }
    }

    internal class Librarian
    {
        public Book book;
        string Name, Password, SearchString;
        int ID;

        public void Verify_librarian()
        {
            Console.WriteLine("Librarian: Verify_librarian");
        }

        public void Search()
        {
            Console.WriteLine("Librarian: Search");
        }
    }

    internal class Library_database
    {
        public List<string> List_Of_Books = new List<string>();
        public Librarian Data;
        public void Add()
        {
            Console.WriteLine("Librabry_database: Add");
        }

        public void Delete()
        {
            Console.WriteLine("Librabry_database: Delete");
        }


        public void Update()
        {
            Console.WriteLine("Librabry_database: Update");
        }

        public void Display()
        {
            Console.WriteLine("Librabry_database: Display");
        }

        public void Search()
        {
            Console.WriteLine("Librabry_database: Search");
        }

    }

    internal class Library_Management_System
    {
        string UserType, Username, Password;

        public void Login()
        {
            Console.WriteLine("Librabry_Management_System: Login");
        }
        public void Register()
        {
            Console.WriteLine("Librabry_Management_System: Register");
        }
        public void Logout()
        {
            Console.WriteLine("Librabry_Management_System: Logout");
        }
    }

    class Program
    {
        static void Main()
        {
            Library_database library_Database = new Library_database();
            library_Database.Data = new Librarian();

            Librarian l = new Librarian();
            l.book = new Book();

        }
    }
}
