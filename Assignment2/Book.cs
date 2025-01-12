using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            this.Author = author;
            this.Title = title;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Book Details:\n" +
                $"Title: {this.Title}\n" +
                $"Author: {this.Author}\n");
        }
    }
}
