using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        #region CanGetFactorial
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        //[Fact]
        //public void CanGetFactorial()
        //{
        //    Assert.Equal(string.Empty, Algorithms.GetFactorial(0));
        //}

        //[Fact]
        //public void CanGetFactorial()
        //{
        //    Assert.Equal(24, Algorithms.GetFactorial(4));
        //}

        //[Fact]
        //public void CanGetFactorial()
        //{
        //    Assert.Equal(24, Algorithms.GetFactorial(4));
        //}
        #endregion

        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }
    }
}