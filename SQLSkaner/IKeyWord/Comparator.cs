using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSkaner
{
    class Comparator : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            input = input.ToUpper();
            if ((input == ">") || (input == "<") || (input == "=") 
                || (input == ">=") || (input == "<=") || (input == "<>")
                || (input == "BETWEEN") || (input == "LIKE") || (input == "IN"))
                return true;
            return false;
        }

        public bool IsPartialMatch(string input)
        {
            input = input.ToUpper();
            if ((input == ">") || (input == "<") || (input == "="))
                return true;
            return false;
        }

        public string KeyWordName()
        {
            return "Comparator";
        }
    }
}
