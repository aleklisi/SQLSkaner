using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Join : IKeyWords
    {
        private static readonly List<string> MatchingRegex = new List<string>();

        public Join()
        {
            MatchingRegex.Add("JOIN");
            MatchingRegex.Add("NATURAL JOIN");
            MatchingRegex.Add("INNER");
            MatchingRegex.Add("OUTER");
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
            return "Join";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Coral\">" + elementToBeWrapped + "</font>";
        }
    }
}
