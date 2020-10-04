using System;
using System.Runtime.InteropServices;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var book = new Book { Isbn = "111", Title = "C# Advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
            */

            // Use the class with an int:
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Default value : " + number.GetValueOrDefault());

            // Use the class with a float:
            var okFloat = new Nullable<float>(3.14159265f);
            Console.WriteLine("Has Value ? " + okFloat.HasValue);
            Console.WriteLine("Value : " + okFloat.GetValueOrDefault());


            // Use the class with a Sting:
            // String does not work when T : hast to be value type (Nullable.cs)
            // String is a reference type
            //var okString = new Nullable<string>("ok");
            //Console.WriteLine("Has Value ? " + okString.HasValue);
            //Console.WriteLine("Value : " + okString.GetValueOrDefault());

            // Use the class without a value:
            var noValue = new Nullable<int>();
            Console.WriteLine("Has Value ? " + noValue.HasValue);
            Console.WriteLine("Value : " + noValue.GetValueOrDefault());
        }
    }
}
