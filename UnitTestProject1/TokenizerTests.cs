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
        [TestCase("AVG", "Agregators")]
        [TestCase("Avg", "Agregators")]
        [TestCase("AvG", "Agregators")]
        [TestCase("avg", "Agregators")]
        [TestCase("AVg", "Agregators")]
        [TestCase("aVg", "Agregators")]
        [TestCase("SUM", "Agregators")]
        [TestCase("MIN", "Agregators")]
        [TestCase("MAX", "Agregators")]
        [TestCase("AS", "AliasingColumns")]
        [TestCase("as", "AliasingColumns")]
        [TestCase("TRUE", "BooleanValues")]
        [TestCase("FALSE", "BooleanValues")]
        [TestCase(",", "Comma")]
        [TestCase(">","Comparator")]
        [TestCase("<","Comparator")]
        [TestCase("=", "Comparator")]
        [TestCase(">=", "Comparator")]
        [TestCase("=<", "Comparator")]
        [TestCase("<>", "Comparator")]
        [TestCase("BETWEEN", "Comparator")]
        [TestCase("LIKE", "Comparator")]
        [TestCase("IN", "Comparator")]
        [TestCase("WHERE", "Conditions")]
        [TestCase("DISTINCT", "Conditions")]
        [TestCase("ON", "Conditions")]
        [TestCase("LIMIT", "Conditions")]
        [TestCase("INTEGER", "DataTypes")]
        [TestCase("FLOAT", "DataTypes")]
        [TestCase("BOOLEAN", "DataTypes")]
        [TestCase("CHARACTER", "DataTypes")]
        [TestCase("YEAR", "Interval")]
        [TestCase("MONTH", "Interval")]
        [TestCase("DAY", "Interval")]
        [TestCase("JOIN", "Join")]
        [TestCase("NATURAL JOIN", "Join")]
        [TestCase("INNER", "Join")]
        [TestCase("OUTER", "Join")]
        [TestCase("AND", "LogicalOperators")]
        [TestCase("OR", "LogicalOperators")]
        [TestCase("NOT", "LogicalOperators")]
        [TestCase("GROUP BY", "OrderingAndGrouping")]
        [TestCase("ORDER BY", "OrderingAndGrouping")]
        [TestCase("ASC", "OrderingAndGrouping")]
        [TestCase("DESC", "OrderingAndGrouping")]
        [TestCase("SELECT", "RecordManipulation")]
        [TestCase("INSERT INTO", "RecordManipulation")]
        [TestCase("UPDATE", "RecordManipulation")]
        [TestCase("DELETE FROM", "RecordManipulation")]
        [TestCase("FROM", "RecordManipulationFollower")]
        [TestCase("SET", "RecordManipulationFollower")]
        [TestCase("VALUES", "RecordManipulationFollower")]
        [TestCase("*", "Star")]
        [TestCase("CREATE TABLE", "TableManipulation")]
        [TestCase("ALTER TABLE", "TableManipulation")]
        [TestCase("TRUNCATE TABLE", "TableManipulation")]
        [TestCase("DROP TABLE", "TableManipulation")]
        [TestCase("1234", "Integer")]
        [TestCase("0", "Integer")]
        [TestCase("001123", "Integer")]

        public void TokenRecognizedCorrectly(string input, string tokenName)
        {
            var skaner = new Skaner(input);

            var result = skaner.TokenizeInput();
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.FirstOrDefault()?.getKeyWordName() == tokenName);
        }

        [TestCase("sumdf ")]
        public void IncorrectInput(string input)
        {
            var skaner = new Skaner(input);

            Assert.Throws<Exception>(() => skaner.TokenizeInput());
        }

    }
}