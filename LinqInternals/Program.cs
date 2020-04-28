using System;
using System.Linq;

namespace LinqInternals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = numbers.Where(x => x % 2 == 0);
            var evenNumbers = numbers.MyWhere(x => x % 2 == 0);
            //The execution doesn't happen in the above statement.
            //WHERE executes when we loop through evenNumbers
            //or when we do evenNumbers.ToList()
            //or evenNumbers.ToArray()
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            //Let's see if this works. Fingers-Crossed.
            //See how is the flow of execution.
            //Check the item variable.

            //So we've successfully implemented our WHERE method.
        }
    }
}
