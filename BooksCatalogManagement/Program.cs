using System;

namespace BooksCatalogManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read all books information from given books.xml file and store into BooksDb using EF core Code First Approach

            // Duration : 30min

            BooksRepository repo = new BooksRepository();
            var books = repo.LoadBooksFromXML();
            repo.SaveBooksToDatabase(books);

            Console.WriteLine("done");
        }
    }
}
