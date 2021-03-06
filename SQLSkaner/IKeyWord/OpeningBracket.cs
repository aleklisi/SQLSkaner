﻿namespace SQLSkaner.IKeyWord
{
    class OpeningBracket : IKeyWords
    {
        public bool IsFullMatch(string input)
        {
            return input == "(";
        }

        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public string KeyWordName()
        {
            return "OpeningBracket";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Cyan\">" + elementToBeWrapped + "</font>";
        }
    }
}
