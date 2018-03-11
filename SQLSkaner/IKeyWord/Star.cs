namespace SQLSkaner.IKeyWord
{
    class Star : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            return (input == "*") ;
        }

        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public string KeyWordName()
        {
            return "Star";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: DarkGreen\">" + elementToBeWrapped + "</font>";
        }
    }
}
