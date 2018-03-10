using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSkaner
{
    class Star : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            return (input == "*") ;
        }

        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public string KeyWordName()
        {
            return "Star";
        }
    }
}
