using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class ContainsFiveHandler : Handler
    {
        public ContainsFiveHandler(IHandler nextHandler) : base(nextHandler) { }

        public override string HandleNumber(NumberPipelineResult input) =>
            input.ContainsValue(5, () => input.IfNotContainsAppendValue("Buzz"))
            .ManageHandler(NextHandler);
    }
}
