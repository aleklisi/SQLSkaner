using System;
using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class RecordManipulationFollower : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public RecordManipulationFollower()
        {
            matchingRegex.Add("FROM");
            matchingRegex.Add("SET");
            matchingRegex.Add("VALUES");
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
            return "RecordManipulationFollower";
        }
    }
}
