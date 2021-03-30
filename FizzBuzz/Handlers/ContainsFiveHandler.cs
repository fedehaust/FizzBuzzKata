using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class ContainsFiveHandler : Handler
    {
        public ContainsFiveHandler(IHandler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(int input, string currentValue = "") =>
            input.ContainsValue(5, currentValue, currentValue.AppendIfNotContains("Buzz"))
            .ManageHandler(nextHandler);
    }
}
