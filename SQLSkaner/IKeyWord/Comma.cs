namespace SQLSkaner.IKeyWord
{
    class Comma : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            return (input == ",");
        }

        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public string KeyWordName()
        {
            return "Comma";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Brown\">" + elementToBeWrapped + "</font>";
        }
    }
}