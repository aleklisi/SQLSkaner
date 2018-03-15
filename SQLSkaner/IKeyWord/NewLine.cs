using System;
using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class NewLine : IKeyWords
    {
        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public bool IsFullMatch(string input)
        {
            if(input.Equals("\r"))
                return true;
            if (input.Equals("\n"))
                return true;
             
            return false;
        }

        public string KeyWordName()
        {
            return "NewLine";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<br />";
        }
    }
}
