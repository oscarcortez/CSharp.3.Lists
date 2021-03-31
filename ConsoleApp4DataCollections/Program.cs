using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var algo = new List<string> { "hola", "como", "ESTAS" };

            foreach(var al in algo)
            {
                Console.WriteLine(al);
            }

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            names.Sort();

            Console.WriteLine("fsadfasdd");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


            Console.WriteLine("------------------------------");
            var fibonacciNumbers = new List<int> { 1, 1 };

            int counterFibo = 0;
            for(int i = 1; i<=18; i++)
            {
                counterFibo = fibonacciNumbers.Count();
                fibonacciNumbers.Add(fibonacciNumbers[counterFibo-1] + fibonacciNumbers[counterFibo-2]);
            }

            int order = 1;
            foreach(var fn in fibonacciNumbers)
            {
                
                Console.WriteLine($"{order++}: {fn}");
            }

            Double x = .1d;
            Console.WriteLine(x);
            Double result = 10 * x;
            Double result2 = x + x + x + x + x + x + x + x + x + x;
            Console.WriteLine("{0} - {1}", result, result2);
        }
    }
}
