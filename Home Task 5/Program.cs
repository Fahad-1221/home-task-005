using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book OOP = new Book();
            OOP.Title = "OOP";
            OOP.Author = "Sir Abdul Qadeer";
            OOP.Genre = "Technology";
            OOP.PublicationYear = 2012;

            Book Book2 = new Book();
            Book2.Title = "PF";
            Book2.Author = "Sir Waqar";
            Book2.Genre = "CS";
            Book2.PublicationYear = 2022;

            Book Book3 = new Book();
            Book3.Title = "C#";
            Book3.Author = "Fahad";
            Book3.Genre = "CS";
            Book3.PublicationYear = 2020;

            Library Object = new Library();
            Object.AddBook(OOP);
            Object.AddBook(Book2);
            Object.AddBook(Book3);

            //Display All Books
            Object.BookList();

            //Search
            string Find = "OOP";
            Object.SearchBooks(Find);
        }
    }
}
