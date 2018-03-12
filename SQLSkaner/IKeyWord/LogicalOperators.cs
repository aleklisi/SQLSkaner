using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class LogicalOperators : IKeyWords
    {
        private static readonly List<string> MatchingRegex = new List<string>();

        public LogicalOperators()
        {
            MatchingRegex.Add("AND");
            MatchingRegex.Add("OR");
            MatchingRegex.Add("NOT");
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
            return "LogicalOperators";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: CornflowerBlue\">" + elementToBeWrapped + "</font>";
        }
    }
}
