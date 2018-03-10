using System;
using System.Linq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace SQLSkaner.UnitTests.Services
{
    [TestFixture]
    public class MathematicalOperatorsTests
    {
        
        [TestCase("+", "MathematicalOperators")]
        [TestCase("-", "MathematicalOperators")]
        [TestCase("/", "MathematicalOperators")]
        [TestCase("(", "OpeningBracket")]
        [TestCase(")", "ClosingBracket")]
        [TestCase(" ", "WhiteSpaces")]
        [TestCase("\t", "WhiteSpaces")]
        [TestCase("\n", "WhiteSpaces")]
        [TestCase("\r", "WhiteSpaces")]
        public void TokenRecognizedCorrectly(string input, string tokenName)
        {
            var skaner = new Skaner(input);

            var result = skaner.TokenizeInput();
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.FirstOrDefault()?.getKeyWordName() == tokenName);
        }

        [TestCase("AVG", "Agregators")]
        [TestCase("avg", "Agregators")] 
        public void AgregatorTests(string input, string tokenName)
        {
            var skaner = new Skaner(input);

            var result = skaner.TokenizeInput();
            Assert.IsTrue(result.FirstOrDefault()?.getKeyWordName() == tokenName);
        }

        [TestCase("AV")]
        [TestCase("AVerage")]
        [TestCase("asdf")]
        [TestCase("")]
        public void incorrectInput(string input)
        {
            var skaner = new Skaner(input);

            Assert.Throws<Exception>(() => skaner.TokenizeInput());
        }

    }
}