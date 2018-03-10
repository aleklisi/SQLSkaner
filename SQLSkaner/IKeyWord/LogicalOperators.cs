using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class LogicalOperators : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public LogicalOperators()
        {
            matchingRegex.Add("AND");
            matchingRegex.Add("OR");
            matchingRegex.Add("NOT");
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
            return "LogicalOperators";
        }
    }
}
