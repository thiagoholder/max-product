namespace MaxProductProgram.Tests
{
    using MaxProductConsole;
    using System;
    using Xunit;

    public class MaxProductTest
    {
        [Fact]
        public void GivenASetOfNumbers_WithInvalidPairLength_ThrowArgumentException()
        {
            //arrange
            var arrayNumber = new int[] { 1 };
            var maxProduct = new MaxProduct(arrayNumber);

            //assert
            Assert.Throws<ArgumentException>(() => maxProduct.Pairs);
        }

        [Fact]
        public void GivenASetOfNumbers_WithValidTwoNumbersNotDivisibleForTree_ThrowException()
        {
            //arrange
            var arrayNumber = new int[] { 1, 2 };
            var maxProduct = new MaxProduct(arrayNumber);

            //assert
            Assert.Throws<Exception>(() => maxProduct.Pairs);
        }

        [Fact]
        public void GivenASetOfNumbers_WithvalidNumbers_TheResultProductIsDisibleForThree()
        {
            //arrange
            var arrayNumber = new int[] { 1, 2, 3 };
            var maxProduct = new MaxProduct(arrayNumber);

            var pairs = maxProduct.Pairs;

            //assert
            Assert.True(pairs.Item1 * pairs.Item2 == 6);
        }

        [Fact]
        public void GivenASetOfNumbers_WithvalidNumbers_TheResultProductPairIsNotTheSame()
        {
            //arrange
            var arrayNumber = new int[] { 1, 9, 2, 4 };
            var maxProduct = new MaxProduct(arrayNumber);

            var pairs = maxProduct.Pairs;

            //assert
            Assert.False(pairs.Item1 == pairs.Item2);
        }
    }
}