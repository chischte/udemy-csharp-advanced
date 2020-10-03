using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
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

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

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


