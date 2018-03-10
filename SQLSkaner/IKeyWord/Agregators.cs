﻿using System.Collections.Generic;

namespace SQLSkaner
{
    class Agregators : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public Agregators()
        {
            matchingRegex.Add("AVG");
            matchingRegex.Add("SUM");
            matchingRegex.Add("MIN");
            matchingRegex.Add("MAX");
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
            return "Agregators";
        }
    }
}
