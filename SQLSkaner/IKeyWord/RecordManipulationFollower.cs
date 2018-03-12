using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class RecordManipulationFollower : IKeyWords
    {
        private static readonly List<string> MatchingRegex = new List<string>();

        public RecordManipulationFollower()
        {
            MatchingRegex.Add("FROM");
            MatchingRegex.Add("SET");
            MatchingRegex.Add("VALUES");
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
            return "RecordManipulationFollower";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: DarkGoldenRod\">" + elementToBeWrapped + "</font>";
        }
    }
}
