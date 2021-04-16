using FizzBuzz.ExtensionMethods;

namespace FizzBuzz
{
    public sealed class FinalHandler : IHandler

    {
        public string HandleNumber(int input) => HandleNumber(new NumberPipelineResult { Input = input });
        public string HandleNumber(NumberPipelineResult input) => input.GetNumberPipelineResult();
    }
}
