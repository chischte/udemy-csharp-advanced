using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book 1 st", Price = 1.1f},
                new Book() {Title = "Book 3 rd", Price = 3},
                new Book() {Title = "Book 5 th", Price = 8},
                new Book() {Title = "Book 6 th", Price = 20},
                new Book() {Title = "Book 4 th", Price = 3},
                new Book() {Title = "Book 2 nd", Price = 22}
            };
        }
    }
}
