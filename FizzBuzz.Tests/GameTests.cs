using FluentAssertions;
using Xunit;
using FizzBuzz.ExtensionMethods;
using System.Linq;
using FizzBuzz.Handlers;

namespace FizzBuzz
{
    public class GameTests
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

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void When_Number_Divisible_by_Three_Or_Five_Or_Both_Should_Be_Fizz_Or_Buzz_Or_Both(int divisor, string value)
        {
            var sut = new Game
                (new ContainsFiveHandler
                (new DivisibleByThreeHandler
                (new ContainsThreeHandler
                (new DivisibleByFiveHandler(null))
                )))
                .GetPlayAnswers(1,100);
            sut.Where((currentValue, i) => (i + 1).IsDivisible(divisor))
                .Should()
                .OnlyContain(x => x.Contains(value));
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        public void When_Number_Contains_Three_Or_Five_Should_Be_Fizz_Or_Buzz(int divisor, string value)
        {
            var sut = new Game
                (new ContainsThreeHandler
                (new ContainsFiveHandler
                (new DivisibleByThreeHandler
                (new DivisibleByFiveHandler(null))
                )))
                .GetPlayAnswers(1,100);
            sut.Where((currentValue, i) => (i + 1).ContainsNumber(divisor))
                .Should()
                .OnlyContain(x => x.Contains(value));
        }
    }
}
