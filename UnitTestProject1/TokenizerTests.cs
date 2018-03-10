using NUnit.Framework;
using SQLSkaner;
using Assert = NUnit.Framework.Assert;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        
        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            var skaner = new Skaner("+");

            var result = skaner.TokenizeInput();
            Assert.IsTrue(result.Count == 1);
        }
    }
}