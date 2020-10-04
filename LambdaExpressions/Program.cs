using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(Square(7));

            Func<int, int> squareLambda = number => number * number;
            Console.WriteLine(squareLambda(11));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));
            */

            
            var books = new BookRepository().GetBooks();
            
            // Find cheap books without a lambda expression:
            
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            // Find cheap books using a lambda expression:

            var cheapBooksLambda = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooksLambda)
            {
                Console.WriteLine("Lambda Result: "+ book.Title);
            }




        }
        /*
        static int Square(int number)
        {
            return number * number;
        }
        */
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
