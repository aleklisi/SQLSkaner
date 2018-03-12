using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class DataTypes : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public DataTypes()
        {
            MatchingRegex.Add("INTEGER");
            MatchingRegex.Add("FLOAT");
            MatchingRegex.Add("BOOLEAN");
            MatchingRegex.Add("CHARACTER");
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
            return "DataTypes";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Chartreuse\">" + elementToBeWrapped + "</font>";
        }
    }
}
