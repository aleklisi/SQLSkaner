using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Join : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public Join()
        {
            matchingRegex.Add("JOIN");
            matchingRegex.Add("NATURAL JOIN");
            matchingRegex.Add("INNER");
            matchingRegex.Add("OUTER");
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
            return "Join";
        }
    }
}
