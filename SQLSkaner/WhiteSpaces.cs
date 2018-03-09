using System;

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
        return false;
    }

}
