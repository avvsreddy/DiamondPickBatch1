﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ to Objects - In Memory Objects

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // extract all even numbers into another list
            // old way
            List<int> evenNumbers = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    evenNumbers.Add(item);
            }

            // numbers -  number 
            // sql select - select number from numbers where number mod 2 = 0;

            // LINQ Expression - 
            var evenNumbers2 = from number in numbers 
                               where number % 2 == 0 
                               select number;


            // LINQ Extensions

            Func<int, bool> predicate = new Func<int, bool>(IsEven);

            var evenNumbers3 = numbers.Where(predicate);


            foreach (var item in evenNumbers3)
            {
                Console.WriteLine(item);
            }

        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
