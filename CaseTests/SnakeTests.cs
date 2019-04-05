using System;
using NUnit.Framework;

namespace CaseTests
{
    [TestFixture]
    public class SnakeTests
    {
        [TestCase("asdf_sf", true)]
        [TestCase("asdf_sf_sdf", true)]
        [TestCase("asdfsf_", true)]
        [TestCase("_asdfsf", true)]
        public void SnakeCaseDetection(string input, bool expected)
        {
            var result = Case.Snake.IsSnakeCase(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase("this_is_snake_case", "ThisIsSnakeCase")]
        [TestCase("thisislikeonewordinsnakecase", "Thisislikeonewordinsnakecase")]
        [TestCase("PascalCase", "Pascalcase")]
        [TestCase("_weird_case_", "WeirdCase")]
        public void SnakeConversion(string input, string expected)
        {
            var snake = new Case.Snake();
            var result = snake.ToPascal(input);
            Assert.AreEqual(expected, result);
        }
    }
}
