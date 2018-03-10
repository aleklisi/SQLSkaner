namespace SQLSkaner
{
    public class FoundKeyWord
    {
        internal string FoundPattern;
        internal IKeyWords KeyWordType;

        internal FoundKeyWord(string foundPattern, IKeyWords keyWordType)
        {
            FoundPattern = foundPattern;
            KeyWordType = keyWordType;
        }
    }
}