using System;
using Xunit;
using FluentAssertions;
using Service.Classes;

namespace Test
{
    public class GreatestCommonDivisorTest
    {
        [Theory]
        [InlineData(48, 18, 6)]
        [InlineData(48, 16, 16)]
        [InlineData(16, 136, 8)]
        [InlineData(55, 50, 5)]
        public void GreatestCommonDivisor_GetForTwoIntegers_Returns_Int(int first, int second, int expectedResult)
        {
            var gcdGenerator = new GreatestCommonDivisor();
            var result = gcdGenerator.GetForTwoIntegers(first, second);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new int[] { 48, 18 }, 6)]
        [InlineData(new int[] { 48, 18, 34 }, 2)]
        [InlineData(new int[] { 56,86,38,24 }, 2)]
        [InlineData(new int[] { 64,16,48 }, 16)]
        public void GreatestCommonDivisor_GetForNIntegers_Returns_Int(int[] input, int expectedResult)
        {
            var gcdGenerator = new GreatestCommonDivisor();
            var result = gcdGenerator.GetForNIntegers(input);
            result.Should().Be(expectedResult);
        }
    }
}
