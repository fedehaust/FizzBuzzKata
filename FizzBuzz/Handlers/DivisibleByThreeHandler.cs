using FizzBuzz.ExtensionMethods;

namespace FizzBuzz.Handlers
{
    public class DivisibleByThreeHandler : Handler

    {
        public DivisibleByThreeHandler(Handler nextHandler) : base(nextHandler) { }
        public override string HandleNumber(int input, string currentValue = "") =>
            input.ManageDivisor(3, currentValue, currentValue.PrependIfNotContains("Fizz")).ManageHandler(nextHandler);


    }
}
