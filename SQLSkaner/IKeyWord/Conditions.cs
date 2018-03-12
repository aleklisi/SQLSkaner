using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Conditions : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public Conditions()
        {
            MatchingRegex.Add("WHERE");
            MatchingRegex.Add("DISTINCT");
            MatchingRegex.Add("ON");
            MatchingRegex.Add("LIMIT");
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
            return "Conditions";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: CadetBlue\">" + elementToBeWrapped + "</font>";
        }
    }
}
