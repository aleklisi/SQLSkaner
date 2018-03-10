using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Interval : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public Interval()
        {
            matchingRegex.Add("YEAR");
            matchingRegex.Add("MONTH");
            matchingRegex.Add("DAY");
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
            return "Interval";
        }
    }
}
