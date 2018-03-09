namespace SQLSkaner
{
    class FoundKeyWord
    {
        internal string foundPattern;
        internal IKeyWords keyWordType;

        internal FoundKeyWord(string foundPattern, IKeyWords keyWordType)
        {
            this.foundPattern = foundPattern;
            this.keyWordType = keyWordType;
        }
    }
}