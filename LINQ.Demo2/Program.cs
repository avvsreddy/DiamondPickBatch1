using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9 };
            // get all evens

            // Deferred Exe
            // Immediate Exe - iterate the result
            var evens = (from n in numbers
                        where n % 2 == 0
                        select n).ToList();

            numbers.Add(10);

            foreach (var n in evens)
            {
                Console.WriteLine(n);
            }
        }
    }
}
