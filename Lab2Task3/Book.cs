using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task3
{
    class Book
    {
        public Title CurrTitle { get; }
        public Author CurrAuthor { get; }
        public Content CurrContent { get; }
        public Book(string title, string author, string content)
        {
            CurrTitle = new Title();
            CurrAuthor = new Author();
            CurrContent = new Content();
            CurrTitle.title = title;
            CurrAuthor.author = author;
            CurrContent.content = content;
        }
        public Book()
        {
            CurrTitle = new Title();
            CurrAuthor = new Author();
            CurrContent = new Content();
        }
        public class Title
        {
            public string title = "";
            public void Show()
            {
                Console.WriteLine("Title: " + title);
            }
        }
        public class Author
        {
            public string author= "";
            public void Show()
            {
                Console.WriteLine("Author: " + author);
            }
        }
        public class Content
        {
            public string content = "";
            public void Show()
            {
                Console.WriteLine("Content: " + content);
            }
        }
    }
}
