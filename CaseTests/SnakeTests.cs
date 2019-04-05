using System;
using NUnit.Framework;

namespace CaseTests
{
    [TestFixture]
    public class SnakeTests
    {
        [TestCase("this_is_snake_case", "ThisIsSnakeCase")]
        [TestCase("thisislikeonewordinsnakecase", "Thisislikeonewordinsnakecase")]
        [TestCase("PascalCase", "Pascalcase")]
        [TestCase("_weird_case_", "WeirdCase")]
        [TestCase("Garbag%$#432String_Li23So+_bad", "Garbag%$#432StringLi23so+Bad")]
        [TestCase("", "")]
        [TestCase(null,"")]
        public void ToPascal(string input, string expected)
        {
            var result = Case.Converter.ToPascal(input);
            Assert.AreEqual(expected, result);
        }

    }
}
