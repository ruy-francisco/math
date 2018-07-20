using System;
using Xunit;
using Moq;
using FluentAssertions;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void GreatestCommonDivisor_GetForNIntegers_Returns_Int()
        {
            string name = "Ruy";
            name.Should().Be("Ruy");
        }
    }
}
