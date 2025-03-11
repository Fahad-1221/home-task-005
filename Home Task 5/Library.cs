using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_5
{
    class Library
    {
        //Data Members
        private Book[] Books;//Array of Books or user defined data type
        private int numbooks;//Builtin data type


        public Library()
        {
            Books = new Book[20];
            numbooks = 0;
        }
        //Methods
        public void AddBook (Book OOP)
        {
            Books[numbooks] = OOP;
            numbooks++;    //increment
            Console.WriteLine("Book Added Successfully ");
        }
        public void BookList()   //Method
        {
            Console.WriteLine("Books Available in Library: ");
            for(int i = 0;i<numbooks ;i++)
            {
                Console.WriteLine($"Title: {Books[i].Title}");
                Console.WriteLine($"Author: {Books[i].Author}" );
                Console.WriteLine($"Genre: { Books[i].Genre}" );
                Console.WriteLine($"Publication Year: {Books[i].PublicationYear}" );
            }
        }
       public void SearchBooks(string Search)   //Method
        {
            Console.WriteLine($"Search a book in Library{Search}");
            for(int i = 0; i < numbooks ; i++)
            {
                if (Books[i].Title == Search || Books[i].Author == Search || Books[i].Genre == Search) ;
                Console.WriteLine($"Title: {Books[i].Title}");
                Console.WriteLine($"Author: {Books[i].Author}");
                Console.WriteLine($"Genre: {Books[i].Genre}");
                Console.WriteLine($"Publication Year: {Books[i].PublicationYear}");
                break;
            }
        }
        }
    }

