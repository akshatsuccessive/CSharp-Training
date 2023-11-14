using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public struct Books
    {
        private string _title;
        private string _author;
        private string _subject;
        private int _bookId;

        public Books(string title, string author, string subject, int bookId)
        {
            _title = title;
            _author = author;
            _subject = subject;
            _bookId = bookId;
        }

        /*
        public Books()
        {
            _author = "Test author";
            _subject = "Test subject";
        }
        */

        public void PrintBooks()
        {
            Console.WriteLine("Book Id : {0}, Title : {1}, Author : {2}, Subject : {3}", _bookId, _title, _author, _subject);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Books b1 = new Books("My title", "Akshat", "Test Subject", 7);
            b1.PrintBooks();
            Console.ReadKey();
        }
    }
}
