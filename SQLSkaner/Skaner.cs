using System.Collections.Generic;
using System.Linq;

namespace SQLSkaner
{
    class Skaner
    {
        List<IKeyWords> _allPossibleKeywordsList = new List<IKeyWords> { new MathematicalOperators() };
        private string input;


        public Skaner(string input)
        {
            this.input = input;
        }
        bool AnyPartilMatch(string currentInput)
        {
            foreach (var keyWord in _allPossibleKeywordsList)
            {
                if (keyWord.IsPartialMatch(currentInput)) return true;
            }
            return false;
        }

        bool AnyFullMatch(string currentInput)
        {
            return GetAllFullMatches(currentInput).Count > 0;
        }

        List<FoundKeyWord> GetAllFullMatches(string currentInput)
        {
            var result = new List<FoundKeyWord>();
            foreach (var keyWord in _allPossibleKeywordsList)
            {
                if (keyWord.IsFullMatch(currentInput))
                {
                    result.Add(new FoundKeyWord(currentInput, keyWord));
                }
            }
            return result;
        }

        bool IsEndOfInput(int reachedPosition)
        {
            return reachedPosition >= input.Length;
        }

        FoundKeyWord GetLongestFoundKeyWord(List<FoundKeyWord> foundKeyWords)
        {
            FoundKeyWord longesKeyWord = foundKeyWords.FirstOrDefault();
            foreach (var keyWord in foundKeyWords)
            {
                if (keyWord.FoundPattern.Length > longesKeyWord.FoundPattern.Length) longesKeyWord = keyWord;
            }

            return longesKeyWord;

        }

        internal List<FoundKeyWord> TokenizeInput()
        {
            var result = new List<FoundKeyWord>();
            var startPosition = 0;
            while (startPosition < input.Length)
            {
                var lengthOfCurrentWord = 1;
                //if (IsEndOfInput(startPosition + lengthOfCurrentWord)) break;
                var inputSubstring = input.Substring(startPosition, lengthOfCurrentWord);
                var currentPossibleFoundKeywordsList = new List<FoundKeyWord>();

                while (!IsEndOfInput(startPosition + lengthOfCurrentWord) &&
                       (AnyFullMatch(inputSubstring) || AnyPartilMatch(inputSubstring)))
                {
                    currentPossibleFoundKeywordsList.AddRange(GetAllFullMatches(inputSubstring));
                    lengthOfCurrentWord++;
                    if (IsEndOfInput(startPosition + lengthOfCurrentWord))
                    {
                        startPosition += lengthOfCurrentWord;
                        break;
                    }
                    inputSubstring = input.Substring(startPosition, lengthOfCurrentWord);
                }

                startPosition += lengthOfCurrentWord - 1;
                var newFoundKeyWord = GetLongestFoundKeyWord(currentPossibleFoundKeywordsList);
                result.Add(newFoundKeyWord);
            }

            return result;
        }
    }
}