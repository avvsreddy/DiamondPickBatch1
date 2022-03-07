using System;
using System.Xml.Linq; // linq to xml
using System.Linq; // linq to objects


namespace LinqToXmlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"one","two","three","four","five","six" };
            // get all short words (<=3)
            // LINQ to Object
            var shortWords = from w in words
                             where w.Length <= 3
                             select w;

            // load xml document into memory
            // LINQ to XML
            XDocument xml = XDocument.Load("XMLFile1.xml");

            var shortWordsXml = from w in xml.Descendants("word")
                             where w.Value.Length <= 3
                             select w.Value;

            foreach (var item in shortWordsXml)
            {
                Console.WriteLine(item);
            }

        }
    }
}
