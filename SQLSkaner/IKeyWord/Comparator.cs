namespace SQLSkaner.IKeyWord
{
    class Comparator : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            input = input.ToUpper();
            if (input == ">")
                return true;
            if (input == "<")
                return true;
            if (input == "=")
                return true;
            if (input == ">=")
                return true;
            if (input == "<=")
                return true;
            if (input == "<>")
                return true;
            if (input == "BETWEEN") 
                return true;
           if  (input == "LIKE")
                return true;
            if (input == "IN")
                return true;

            return false;
        }

        public bool IsPartialMatch(string input)
        {
            input = input.ToUpper();
            if (input == ">")
                return true;
            if (input == "<")
                return true;
            if (input == "=")
                return true;
            if (PartialMatching.IsPartialMatchToRegex("BETWEEN", input))
                return true;
            if (PartialMatching.IsPartialMatchToRegex("LIKE", input))
                return true;
            if (PartialMatching.IsPartialMatchToRegex("IN", input))
                return true;
            return false;
        }

        public string KeyWordName()
        {
            return "Comparator";
        }
    }
}
