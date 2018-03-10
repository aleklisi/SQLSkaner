using System;
using SQLSkaner;

public class WhiteSpaces : IKeyWords
{
    public bool IsPartialMatch(string input)
    {
        return false;
    }

    public bool IsFullMatch(string input)
    {
        if (input.Equals(" "))
            return true;
        if (input.Equals("\t"))
            return true;
        if (input.Equals("\n"))
            return true;
        if (input.Equals("\r"))
            return true;
        return false;
    }

    public string KeyWordName()
    {
        return "WhiteSpaces";
    }
}
