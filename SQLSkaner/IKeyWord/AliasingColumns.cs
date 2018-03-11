using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class AliasingColumns : IKeyWords
    {
        static readonly List<string> MatchingRegex = new List<string>();

        public AliasingColumns()
        {
            MatchingRegex.Add("AS");
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
            return "AliasingColumns";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Aqua\">" + elementToBeWrapped + "</font>";
        }
    }
}
