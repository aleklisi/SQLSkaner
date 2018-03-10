using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Comparator : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public Comparator()
        {
            matchingRegex.Add(">");
            matchingRegex.Add("<");
            matchingRegex.Add("=");
            matchingRegex.Add(">=");
            matchingRegex.Add("=<");
            matchingRegex.Add("<>");
            matchingRegex.Add("BETWEEN");
            matchingRegex.Add("LIKE");
            matchingRegex.Add("IN");
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
            return "Comparator";
        }
    }
}
