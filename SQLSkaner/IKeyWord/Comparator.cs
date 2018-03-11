using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Comparator : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public Comparator()
        {
            MatchingRegex.Add(">");
            MatchingRegex.Add("<");
            MatchingRegex.Add("=");
            MatchingRegex.Add(">=");
            MatchingRegex.Add("=<");
            MatchingRegex.Add("<>");
            MatchingRegex.Add("BETWEEN");
            MatchingRegex.Add("LIKE");
            MatchingRegex.Add("IN");
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
            return "Comparator";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: BurlyWood\">" + elementToBeWrapped + "</font>";
        }
    }
}
