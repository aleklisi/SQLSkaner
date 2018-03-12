using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class BooleanValues : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public BooleanValues()
        {
            MatchingRegex.Add("TRUE");
            MatchingRegex.Add("FALSE");
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
            return "BooleanValues";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Blue\">" + elementToBeWrapped + "</font>";
        }
    }
}
