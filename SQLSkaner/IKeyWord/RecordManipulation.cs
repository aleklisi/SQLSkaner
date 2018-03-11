using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class RecordManipulation : IKeyWords
    {
        private static readonly List<string> MatchingRegex = new List<string>();

        public RecordManipulation()
        {
            MatchingRegex.Add("SELECT");
            MatchingRegex.Add("INSERT INTO");
            MatchingRegex.Add("UPDATE");
            MatchingRegex.Add("DELETE FROM");
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
            return "RecordManipulation";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: DarkCyan\">" + elementToBeWrapped + "</font>";
        }
    }
}
