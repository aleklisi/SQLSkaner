﻿using System.Collections.Generic;

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
            return MatchingService.IsFullMatch(matchingRegex, input);
        }

        public bool IsPartialMatch(string input)
        {
            return MatchingService.IsPartialMatch(matchingRegex, input);
        }

        public string KeyWordName()
        {
            return "BooleanValues";
        }
    }
}
