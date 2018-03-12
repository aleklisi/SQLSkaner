using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class Agregators : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public Agregators()
        {
            MatchingRegex.Add("AVG");
            MatchingRegex.Add("SUM");
            MatchingRegex.Add("MIN");
            MatchingRegex.Add("MAX");
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
            return "Agregators";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: AntiqueWhite\">" + elementToBeWrapped +"</font>";
        }
    }
}
