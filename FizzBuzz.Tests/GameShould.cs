using FluentAssertions;
using Xunit;
using FizzBuzz.ExtensionMethods;
using System.Linq;
using FizzBuzz.Handlers;

namespace FizzBuzz
{
    public class GameShould
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void BeFizzOrBuzzOrBoth_WhenNumberISDivisibleByThreeOrFiveOrBoth(int divisor, string value)
        {
                new Game
                (new ContainsFiveHandler
                (new DivisibleByThreeHandler
                (new ContainsThreeHandler
                (new DivisibleByFiveHandler(null))
                )))
                .GetPlayAnswers(1,100).Where((currentValue, i) => (i + 1).IsDivisible(divisor))
                .Should()
                .OnlyContain(x => x.Contains(value));
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        public void BeFizzOrBuzz_WhenNumberContainsThreeOrFive(int divisor, string value)
        {
                new Game
                (new ContainsThreeHandler
                (new ContainsFiveHandler
                (new DivisibleByThreeHandler
                (new DivisibleByFiveHandler(null))
                )))
                .GetPlayAnswers(1,100)
                .Where((currentValue, i) => (i + 1).ContainsNumber(divisor))
                .Should()
                .OnlyContain(x => x.Contains(value));
        }
    }
}
