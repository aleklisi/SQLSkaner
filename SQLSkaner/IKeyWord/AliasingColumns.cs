namespace SQLSkaner.IKeyWord
{
    class AliasingColumns : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            return ((input.ToUpper()) == "AS");
        }

        public bool IsPartialMatch(string input)
        {
            return PartialMatching.IsPartialMatchToRegex("AS", input);
        }

        public string KeyWordName()
        {
            return "AliasingColumns";
        }
    }
}
