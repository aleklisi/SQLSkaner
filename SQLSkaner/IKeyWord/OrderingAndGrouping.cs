using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class OrderingAndGrouping : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public OrderingAndGrouping()
        {
            matchingRegex.Add("GROUP BY");
            matchingRegex.Add("ORDER BY");
            matchingRegex.Add("ASC");
            matchingRegex.Add("DESC");
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
            return "OrderingAndGrouping";
        }
    }
}
