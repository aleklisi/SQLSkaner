﻿using System.Collections.Generic;

namespace SQLSkaner
{
    class MatchingService
    {
        private static bool IsPartialMatchToRegex(string regex, string input)
        {
            input = input.ToUpper();
            regex = regex.ToUpper();

            if (input.Length >= regex.Length || input == "")
                return false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == regex[i])
                    continue;

                    return false;
            }
            return true;
        }

        public static bool IsFullMatch(List<string> regexLists, string input)
        {
            input = input.ToUpper();

            foreach (string regex in regexLists)
                if (regex == input)
                    return true;

            return false;
        }

        public static bool IsPartialMatch(List<string> regexLists, string input)
        {
            foreach (string regex in regexLists)
                if (IsPartialMatchToRegex(regex, input)) return true;
            return false;
        }

    }
}
