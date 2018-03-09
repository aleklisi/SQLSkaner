using System;
using System.Collections.Generic;

namespace SQLSkaner
{
    class Program
    {
        static void Main(string[] args)
        {
            var testSkaner = new Skaner("++-//");
            var result = testSkaner.TokenizeInput();
            PrintResults(result);
            Console.ReadKey();
        }

        static void PrintResults(IEnumerable<FoundKeyWord> keyWords)
        {
            foreach (var keyWord in keyWords)
            {
                Console.WriteLine("Pattern is: " + keyWord.FoundPattern + " tokanized as: " + keyWord.KeyWordType.KeyWordName());
            }
        }
    }
}
