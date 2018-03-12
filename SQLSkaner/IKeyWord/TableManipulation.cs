using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class TableManipulation : IKeyWords
    {
        private static readonly List<string> MatchingRegex = new List<string>();

        public TableManipulation()
        {
            MatchingRegex.Add("CREATE TABLE");
            MatchingRegex.Add("ALTER TABLE");
            MatchingRegex.Add("TRUNCATE TABLE");
            MatchingRegex.Add("DROP TABLE");
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
            return "TableManipulation";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: DarkKhaki\">" + elementToBeWrapped + "</font>";
        }
    }
}
