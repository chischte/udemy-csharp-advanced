using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // 1st use of Linq
            var cheapBooks = books.Where(b => b.Price < 10);
            foreach(var book in cheapBooks)
            {
                Console.WriteLine("Bookprice < 10 only: " + book.Title + " Price:  " + book.Price);
            }

            // 2nd use of Linq
            books.OrderBy(b => b.Title);
            foreach (var book in books)
            {
                Console.WriteLine("Sorted by title: "+ book.Title + " " + book.Price);
            }

            // Chain linqs and select string only
            var cheapBooksTitles = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title); // Select string-only

            foreach(var book in cheapBooksTitles)
            {
                Console.WriteLine("String only : " + book);
            }


        }
    }
}
