using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BooksCatalogManagement
{
    public class BooksRepository
    {
        public List<Book> LoadBooksFromXML()
        {
            // linq to xml
            XDocument xml = XDocument.Load("Books.xml");
            List<Book> books = (from b in xml.Descendants("book")
                               select new Book 
                               {
                                   BookID = b.Attribute("id").Value,
                                   Author = b.Element("author").Value,
                                   Title = b.Element("title").Value,
                                   Genre = b.Element("genre").Value,
                                   Price = double.Parse(b.Element("price").Value),
                                   PublishDate = b.Element("publish_date").Value,
                                   Description = b.Element("description").Value

                               }).ToList();


            return books;

        }

        public int SaveBooksToDatabase(List<Book> books)
        {

            BooksDbContext db = new BooksDbContext();
            db.Books.AddRange(books);
            return db.SaveChanges();
            
        }
    }
}
