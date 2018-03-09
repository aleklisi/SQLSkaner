using System;
using System.Collections.Generic;

namespace SQLSkaner
{
    class Program
    {
        static void Main()
        {
            var testSkaner = new Skaner("+avgsum/ ");
            List<FoundKeyWord> result = new List<FoundKeyWord>();
            try
            {
                result = testSkaner.TokenizeInput();
                PrintResults(result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
