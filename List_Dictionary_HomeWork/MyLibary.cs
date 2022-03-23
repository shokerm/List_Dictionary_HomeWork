using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace List_Dictionary_HomeWork
{
    internal class MyLibary
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        public int Counter { get; }
        public MyLibary()
        {

        }

        public bool AddBook(Book book)
        {
            if (books.ContainsKey(book.Title))
            {
                Console.WriteLine("The book is already in the list..");
                return true;
            }
            books.Add(book.Title, book);
            return false;
        }

        public bool RemoveBook(string bookKey)
        {
            if (books.ContainsKey(bookKey))
            {
                books.Remove(bookKey);
                return true;
            }
            return false;

        }

        public bool HaveThisBook(string bookKey)
        {
            if (books.ContainsKey(bookKey))
            {
                return true;

            }
            return false;

        }

        public Book GetBook(string bookKey)
        {
            foreach (KeyValuePair<string, Book> book in books)
            {
                if (books.ContainsKey(bookKey))
                    return book.Value;
            }
            return null;

        }

        public Book GetBookByAuthor(string authorName)
        {
            foreach (KeyValuePair<string, Book> book in books)
            {
                if (book.Value.Author == authorName)
                    return book.Value;
            }
            return null;

        }

        public void Clear()
        {
            books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> AuthorList = new List<string>();
            foreach (KeyValuePair<string, Book> book in books)
            {
                AuthorList.Add(book.Value.Author);
            }
            return AuthorList;

        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> myAuthorizedList = new List<Book>(books.Values);
            IEnumerable<Book> mybook = myAuthorizedList.OrderBy(Book => Book.Author);
            return mybook as List<Book>;
            
            
        }

        public List<string> GetBooksTitleSorted()
        {
            List<Book> myTitledList = new List<Book>(books.Values);
            IEnumerable<Book> myTitle = myTitledList.OrderBy(Book => Book.Title);
            return myTitle as List<string>;

        }
        public int Count()
        {
            return books.Count();
        }
        public override string ToString()
        {
            foreach (KeyValuePair<string, Book> book in books)
            {
                return (book.Value.Title);

            }
            return "\n";
        }
    }

}
