namespace SQLSkaner.IKeyWord
{
    class MathematicalOperators : IKeyWords
    {

        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public bool IsFullMatch(string input)
        {
            if (input.Equals("+"))
                return true;
            if (input.Equals("-"))
                return true;
            if (input.Equals("/"))
                return true;
            return false;
        }

        public string KeyWordName()
        {
            return "MathematicalOperators";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Crimson\">" + elementToBeWrapped + "</font>";
        }
    }
}