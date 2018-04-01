namespace SQLSkaner.IKeyWord
{
    class Semicolon : IKeyWords
    {
        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public bool IsFullMatch(string input)
        {
            return (input.Equals(";"));
        }

        public string KeyWordName()
        {
            return "Semicolon";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Black\">" + elementToBeWrapped + "</font>";
        }
    }
}
