﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLSkaner.IKeyWord;

namespace SQLSkaner
{
    public class Skaner
    {
        readonly List<IKeyWords> _allPossibleKeywordsList = new List<IKeyWords>
        {
            new Agregators(),
            new AliasingColumns(),
            new BooleanValues(),
            new ClosingBracket(),
            new Comma(),
            new Comparator(),
            new Conditions(),
            new DataTypes(),
            new Interval(),
            new LogicalOperators(),
            new MathematicalOperators(),
            new OpeningBracket(),
            new OrderingAndGrouping(),
            new RecordManipulation(),
            new RecordManipulationFollower(),
            new Star(),
            new TableManipulation(),
            new Join(),
            new Integers(),
            new Floats(),
            new Space(),
            new NewLine(),
            new Tabular(),
            new Semicolon(),
            new Dot(),
            new Identifier(),
            new Strings()
        };
        private string _input;


        public Skaner(string input)
        {
            _input = input;
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
            foreach (var keyWord in _allPossibleKeywordsList)
            {
                if (keyWord.IsFullMatch(currentInput)) return true;
            }
            return false;
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
            return reachedPosition >= _input.Length;
        }

        FoundKeyWord GetLongestFoundKeyWord(List<FoundKeyWord> foundKeyWords)
        {
            FoundKeyWord longesKeyWord = foundKeyWords.FirstOrDefault();
            foreach (var keyWord in foundKeyWords)
            {
                if (keyWord.FoundPattern.Length > longesKeyWord?.FoundPattern.Length) longesKeyWord = keyWord;
            }

            return longesKeyWord;

        }

        private static void ExitWithExeption(string errorMesage, int startChar)
        {
            StringBuilder message = new StringBuilder();
            message.Append("No match or potencial match for ");
            message.Append(errorMesage);
            message.Append(" starting on ");
            message.Append(startChar);
            message.Append(" position");
            throw new Exception(message.ToString());
        }

        public List<FoundKeyWord> TokenizeInput()
        {

            _input += " ";
            var result = new List<FoundKeyWord>();
            var startPosition = 0;

            while (startPosition < _input.Length)
            {
                var lengthOfCurrentWord = 1;
                var inputSubstring = _input.Substring(startPosition, lengthOfCurrentWord);
                var currentPossibleFoundKeywordsList = new List<FoundKeyWord>();

                if (IsEndOfInput(startPosition + lengthOfCurrentWord) ||
                    (!AnyFullMatch(inputSubstring) && !AnyPartilMatch(inputSubstring)))
                {
                    ExitWithExeption(inputSubstring, startPosition);
                }

                while (!IsEndOfInput(startPosition + lengthOfCurrentWord) &&
                       (AnyFullMatch(inputSubstring) || AnyPartilMatch(inputSubstring)))
                {
                    var fullMaches = GetAllFullMatches(inputSubstring);
                    currentPossibleFoundKeywordsList.AddRange(fullMaches);
                    lengthOfCurrentWord++;
                    if (IsEndOfInput(startPosition + lengthOfCurrentWord))
                    {
                        startPosition += lengthOfCurrentWord;
                        break;
                    }
                    inputSubstring = _input.Substring(startPosition, lengthOfCurrentWord);
                }

                startPosition += lengthOfCurrentWord - 1;
                var newFoundKeyWord = GetLongestFoundKeyWord(currentPossibleFoundKeywordsList);

                if (newFoundKeyWord == null) ExitWithExeption(inputSubstring, startPosition);

                result.Add(newFoundKeyWord);
            }

            return result;
        }
    }
}