namespace SQLSkaner
{
    class NotMachingAnyExpression : IKeyWords
    {
        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public bool IsFullMatch(string input)
        {
            return true;
        }

        public string KeyWordName()
        {
            return "NotMachingAnyExpression";
        }
    }
}