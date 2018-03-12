using System;
using System.Collections.Generic;
using System.IO;

namespace SQLSkaner
{
    class Program
    {
        string ReadFromFile(string fileName)
        {
            try
            {   
                using (StreamReader sr = new StreamReader(fileName))
                {
                    String line = sr.ReadToEnd();
                    return line;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }
        static void Main()
        {
            // var testSkaner = new Skaner("++--/\t\n/-");
            var testSkaner = new Skaner("asdf");
            try
            {
                var result = testSkaner.TokenizeInput();
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
