using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class DivisibleByThreeHandler : Handler

    {
        public DivisibleByThreeHandler(IHandler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(NumberPipelineResult input) =>
            input.VerifyIsDivisible(3, () => input.IfNotContainsPrependValue("Fizz"))
            .ManageHandler(NextHandler);
    }
}
