using FluentAssertions;
using Xunit;
using FizzBuzz.ExtensionMethods;
using System.Linq;
using FizzBuzz.Handlers;

namespace FizzBuzz
{
    public class MethodExtensionsShould
    {
        [Theory]
        [InlineData(23, 2,true)]
        [InlineData(23, 5,false)]
        public void ContainsNumber_Should_Verify_Value(int number, int contains, bool assertion)
        {
            number.ContainsNumber(contains).Should().Be(assertion);
        }

        [Theory]
        [InlineData(6, 3, true)]
        [InlineData(23, 5, false)]
        public void IsDivisor_Should_Verify_Value(int number, int divisor, bool assertion)
        {
            number.IsDivisible(divisor).Should().Be(assertion);
        }
    }
}
