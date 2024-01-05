using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void GetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void GetFactorialWithNegativeNumber()
        {
            Assert.Throws<ArgumentException>(() => Algorithms.GetFactorial(-1));
        }

        [Fact]
        public void FormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }

        [Fact]
        public void FormatSeparatorsWithOneLetter()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
        }

        [Fact]
        public void FormatSeparatorsWithEmptyArray()
        {
            Assert.Equal(string.Empty, Algorithms.FormatSeparators());
        }

        [Fact]
        public void FormatSeparatorsWithTwoItems()
        {
            Assert.Equal("a and b", Algorithms.FormatSeparators("a", "b"));
        }

        [Fact]
        public void FormatSeparatorsWithThreeItems()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }
    }
}