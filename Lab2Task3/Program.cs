using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("The Book", "Ben Zucker", "some text...");
            Console.ForegroundColor = ConsoleColor.Blue;
            book.CurrTitle.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            book.CurrAuthor.Show();
            Console.ForegroundColor = ConsoleColor.Magenta;
            book.CurrContent.Show();
            Console.ReadKey();
        }
    }
}
