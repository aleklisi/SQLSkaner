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
        public void TokenRecognizedCorrectly(string input, string tokenName)
        {
            var skaner = new Skaner(input);

            var result = skaner.TokenizeInput();
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.FirstOrDefault()?.getKeyWordName() == tokenName);
        }
    }
}