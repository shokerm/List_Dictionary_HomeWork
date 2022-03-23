using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Dictionary_HomeWork
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book()
        {

        }
        public Book(string title, string content, string author, string category) : this()
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }
        public override string ToString()
        {
            return this.Title;
        }

      
    }
}
