﻿using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class AliasingColumns : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public AliasingColumns()
        {
            matchingRegex.Add("AS");
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
            return "AliasingColumns";
        }
    }
}
