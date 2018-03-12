using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SQLSkaner
{
    class Program
    {
        static string WrapTokenizedResult(List<FoundKeyWord> ListOfKeyWords)
        {
            var htmlStart =
                "<!DOCTYPE html><head> <meta http-equiv=\"Content - Type\" content=\"text / html; charset = \"iso-8859-2\" />" +
                "<title> Result page </title></head>" +
                "<body>";
            var htmlEnd = "</body>\r\n</html>";
            StringBuilder resultWebpageBuilder = new StringBuilder();
            resultWebpageBuilder.Append(htmlStart);
            foreach (var keyWord in ListOfKeyWords)
            {
                resultWebpageBuilder.Append(keyWord.GetTokenWrappedWithHtml());
            }

            resultWebpageBuilder.Append(htmlEnd);
            return resultWebpageBuilder.ToString();
        }
        static string ReadFromFile(string fileName)
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
<<<<<<< HEAD
            // var testSkaner = new Skaner("++--/\t\n/-");
            var testSkaner = new Skaner("asdf");
=======
            var textFromFile = ReadFromFile(@"C:\Users\alekl\source\repos\SQLSkaner\SQLSkaner\testFile.sql");
            var testSkaner = new Skaner(textFromFile);
>>>>>>> master
            try
            {
                var result = testSkaner.TokenizeInput();
                //PrintResults(result);
                var text = WrapTokenizedResult(result);
                File.WriteAllText(@"C:\Users\alekl\source\repos\SQLSkaner\SQLSkaner\\WriteText.html", text);
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
