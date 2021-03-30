using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class ContainsThreeHandler : Handler
    {
        public ContainsThreeHandler(IHandler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(int input, string currentValue = "") =>
            input.ContainsValue(3, currentValue, currentValue.PrependIfNotContains("Fizz"))
            .ManageHandler(nextHandler);
    }
}
