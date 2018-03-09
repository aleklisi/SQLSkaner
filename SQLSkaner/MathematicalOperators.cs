namespace SQLSkaner
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
    }
}