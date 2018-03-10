using System.Collections.Generic;

namespace SQLSkaner.IKeyWord
{
    class DataTypes : IKeyWords
    {
        static readonly List<string> matchingRegex = new List<string>();

        public DataTypes()
        {
            matchingRegex.Add("INTEGER");
            matchingRegex.Add("FLOAT");
            matchingRegex.Add("BOOLEAN");
            matchingRegex.Add("CHARACTER");
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
            return "DataTypes";
        }
 
    }
}
