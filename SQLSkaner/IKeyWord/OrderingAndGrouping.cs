using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class OrderingAndGrouping : IKeyWords
    {
        private static readonly List<string> MatchingRegex = new List<string>();

        public OrderingAndGrouping()
        {
            MatchingRegex.Add("GROUP BY");
            MatchingRegex.Add("ORDER BY");
            MatchingRegex.Add("ASC");
            MatchingRegex.Add("DESC");
        }

        public bool IsFullMatch(string input)
        {
            return MatchingService.IsFullMatch(MatchingRegex, input);
        }

        public bool IsPartialMatch(string input)
        {
            return MatchingService.IsPartialMatch(MatchingRegex, input);
        }

        public string KeyWordName()
        {
            return "OrderingAndGrouping";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: DarkBlue\">" + elementToBeWrapped + "</font>";
        }
    }
}
