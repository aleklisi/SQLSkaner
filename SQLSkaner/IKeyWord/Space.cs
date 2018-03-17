namespace SQLSkaner.IKeyWord
{
    class Space : IKeyWords
    {
        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public bool IsFullMatch(string input)
        {
            return (input.Equals(" "));
        }

        public string KeyWordName()
        {
            return "Space";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<html>&nbsp</html>";
        }
    }
}
