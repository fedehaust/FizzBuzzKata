using FizzBuzz.ExtensionMethods;
using FizzBuzz.Handlers;
using FluentAssertions;
using System.Linq;
using Xunit;

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
            (new DivisibleByFiveHandler
            (new FinalHandler()))
            )))
            .GetPlayAnswers(1, 100).Where((currentValue, i) => (i + 1).IsDivisible(divisor))
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
            (new DivisibleByFiveHandler
            (new FinalHandler()))

            )))
            .GetPlayAnswers(1, 100)
            .Where((currentValue, i) => (i + 1).ContainsNumber(divisor))
            .Should()
            .OnlyContain(x => x.Contains(value));
        }
    }
}
