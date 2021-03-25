using FizzBuzz.ExtensionMethods;
using System.Linq;

namespace FizzBuzz.Handlers
{
    public class DivisibleByFiveHandler : Handler
    {
        public DivisibleByFiveHandler(Handler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(int input, string currentValue = "") =>
            input.ManageDivisor(5, currentValue, currentValue.AppendIfNotContains("Buzz")).ManageHandler(nextHandler);
    }
}
