using System;
using System.Xml.Linq;
using System.Linq;

namespace LinqToXmlDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // load xml document
            XDocument xml = XDocument.Load("Books.xml");
            // get all book titles
            var bookTitles = from book in xml.Descendants("title")
                             select book.Value;

            // get all book titles the price is less than $40

            var bookTitles2 = from book in xml.Descendants("book")
                              where double.Parse(book.Element("price").Value) >= 40.0
                              select book.Element("title").Value;
            
            foreach (var item in bookTitles2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
