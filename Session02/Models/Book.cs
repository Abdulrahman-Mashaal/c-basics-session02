using System;
using System.Collections.Generic;
using System.Text;

namespace Session02.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}
