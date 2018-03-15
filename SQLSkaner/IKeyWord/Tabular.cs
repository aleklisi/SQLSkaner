namespace SQLSkaner.IKeyWord
{
    class Tabular : IKeyWords
    {
        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public bool IsFullMatch(string input)
        {
            return (input.Equals("\t"));
        }

        public string KeyWordName()
        {
            return "Tabular";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<html>&nbsp &nbsp &nbsp</html>";
        }
    }
}
