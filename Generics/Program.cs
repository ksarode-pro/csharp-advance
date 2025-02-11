using System;
using System.Collections.Concurrent;
namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenericCacheManager<Book> bookCache = new GenericCacheManager<Book>();
            
            bookCache.Add("b1", new Book{ 
                name = "the power of subconcious mind",
                author = "joseph murphy"
            });

            bookCache.Add("b2", new Book{ 
                name = "Art of war",
                author = "Tsu zu"
            });

            Book b1 = bookCache.Get("b1");
            System.Console.WriteLine(Convert.ToString(b1?.name));
            Book b2 = bookCache.Get("b2");
            System.Console.WriteLine(Convert.ToString(b2?.author));
            bookCache.Delete("b1");
            b1 = bookCache.Get("b1");
            System.Console.WriteLine(Convert.ToString(b1?.name));
            bookCache.DeleteAll();
            b2 = bookCache.Get("b2");
            System.Console.WriteLine(Convert.ToString(b2?.author));
        }
    }

    class Book
    {
        public string name;
        public string author;
    }
}

