using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class ContainsThreeHandler : Handler
    {
        public ContainsThreeHandler(IHandler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(NumberPipelineResult input) =>
            input.ContainsValue(3, () => input.IfNotContainsPrependValue("Fizz"))
            .ManageHandler(NextHandler);
    }
}
