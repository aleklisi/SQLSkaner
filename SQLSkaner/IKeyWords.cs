namespace SQLSkaner
{
    interface IKeyWords
    {
        bool IsPartialMatch(string input);
        bool IsFullMatch(string input);
    }
}