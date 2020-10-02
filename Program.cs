using System;
using System.Runtime.InteropServices;

namespace udemy_csharp_advanced_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "111", Title = "C# Advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);


        }
    }
}
