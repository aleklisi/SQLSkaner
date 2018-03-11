using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Interval : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public Interval()
        {
            MatchingRegex.Add("YEAR");
            MatchingRegex.Add("MONTH");
            MatchingRegex.Add("DAY");
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
            return "Interval";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Chocolate\">" + elementToBeWrapped + "</font>";
        }
    }
}
