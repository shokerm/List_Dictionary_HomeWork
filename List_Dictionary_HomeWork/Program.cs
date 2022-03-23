using System;

namespace List_Dictionary_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(title: "harry potter and the philosopher's stone", content: "the first book", author: "j.k rolling", category: "fantazy");
            Book b2 = new Book(title: "harry potter and the chamber of secrets", content: "the secomd book", author: "j.k rolling", category: "fantazy");
            Book b3 = new Book(title: "the alchemist", content: "The Alchemist follows a young Andalusian shepherd in his journey to the pyramids of Egypt, after having a recurring dream of finding a treasure there", author: "Paulo Coelho", category: "fantazy");
            Book b4 = new Book(title: "The Fog ", content: "It is about a deadly fog that drives its victims insane when they come into contact with it", author: "James Herbert", category: "horror novel");

            MyLibary myLibary = new MyLibary();
            myLibary.AddBook(b4);
            myLibary.AddBook(b3);
            myLibary.AddBook(b1);
            myLibary.AddBook(b2);
           
           
            myLibary.GetBooksSortedByAuthorName();
            myLibary.GetBooksTitleSorted();
        }
    }
}
