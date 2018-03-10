namespace SQLSkaner
{
    public class FoundKeyWord
    {
        internal string FoundPattern;
        internal IKeyWords KeyWordType;

        public string getKeyWordName()
        {
            return KeyWordType.KeyWordName();
        }

        internal FoundKeyWord(string foundPattern, IKeyWords keyWordType)
        {
            FoundPattern = foundPattern;
            KeyWordType = keyWordType;
        }
    }
}