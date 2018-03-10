using System;
using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class BooleanValues : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public BooleanValues()
        {
            matchingRegex.Add("TRUE");
            matchingRegex.Add("FALSE");
        }

        public bool IsFullMatch(string input)
        {
            input = input.ToUpper();

            foreach (string regex in matchingRegex)
                if (regex == input)
                    return true;

            return false;
        }

        public bool IsPartialMatch(string input)
        {
            foreach (string regex in matchingRegex)
                if (PartialMatching.IsPartialMatchToRegex(regex, input)) return true;

            return false;
        }

        public string KeyWordName()
        {
            return "BooleanValues";
        }
    }
}
