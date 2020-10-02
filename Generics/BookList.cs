using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_csharp_advanced_generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public BookList this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class GenericList<T>
    {
        public void Add(T value)
        {
            Console.WriteLine("HAUDI");

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}


