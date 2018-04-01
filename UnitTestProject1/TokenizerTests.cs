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
        [TestCase(" ", "Space")]
        [TestCase("\t", "Tabular")]
        [TestCase("\n", "NewLine")]
        [TestCase("\r\n", "NewLine")]
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
        [TestCase(">", "Comparator")]
        [TestCase("<", "Comparator")]
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
        [TestCase("1234.9", "Float")]
        [TestCase("0.21", "Float")]
        [TestCase("0.00", "Float")]
        [TestCase("12.54", "Float")]
        [TestCase("absd", "Identifier")]
        [TestCase("avge", "Identifier")]
        [TestCase("asum", "Identifier")]
        [TestCase("\"\"", "Strings")]
        [TestCase("\"asdfghADF  123\"", "Strings")]
        [TestCase("\"12345\"", "Strings")]
        [TestCase("\"       \"", "Strings")]
        [TestCase("\"++--=-=\"", "Strings")]
        [TestCase(";", "Semicolon")]
        [TestCase(".", "Dot")]

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

        [TestCase("")]
        [TestCase(".01 ")]
        [TestCase("0.0.1")]
        [TestCase("0.1.")]
        [TestCase("\"")]
        [TestCase("\"124")]
        [TestCase("\"gf  w")]
        public void IncorrectInput(string input)

        {
            var skaner = new Skaner(input);

            Assert.Throws<Exception>(() => skaner.TokenizeInput());
        }

    }
}