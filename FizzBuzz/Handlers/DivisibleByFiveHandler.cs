using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class DivisibleByFiveHandler : Handler
    {
        public DivisibleByFiveHandler(IHandler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(NumberPipelineResult input) =>
            input.VerifyIsDivisible(5, () => input.IfNotContainsAppendValue("Buzz"))
            .ManageHandler(NextHandler);
    }
}
