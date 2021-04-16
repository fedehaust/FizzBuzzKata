using System;

namespace FizzBuzz.ExtensionMethods
{
    public static class MethodExtensions
    {
        public static string ManageHandler(this NumberPipelineResult s, IHandler nextHandler)
            => nextHandler.HandleNumber(s);

        public static string GetNumberPipelineResult(this NumberPipelineResult s) =>
            string.IsNullOrEmpty(s.NumberOrTextResult)
                                ? s.Input.ToString()
                                : s.NumberOrTextResult;

        public static NumberPipelineResult VerifyIsDivisible(this NumberPipelineResult s, int divisor, Func<NumberPipelineResult> f)
        {
            return !s.Input.IsDivisible(divisor) ? s : f();
        }

        public static NumberPipelineResult ContainsValue(this NumberPipelineResult s, int value, Func<NumberPipelineResult> f)
        {
            return !s.Input.ContainsNumber(value) ? s : f();
        }

        public static NumberPipelineResult IfNotContainsPrependValue(this NumberPipelineResult currentValue, string possibleValueToAdd)
            => currentValue.NumberOrTextResult.Contains(possibleValueToAdd) ?
            currentValue :
            new NumberPipelineResult
            {
                Input = currentValue.Input,
                NumberOrTextResult = $"{possibleValueToAdd}{currentValue.NumberOrTextResult}"
            };

        public static NumberPipelineResult IfNotContainsAppendValue(this NumberPipelineResult currentValue, string possibleValueToAdd)
            => currentValue.NumberOrTextResult.Contains(possibleValueToAdd) ?
            currentValue :
            new NumberPipelineResult
            {
                Input = currentValue.Input,
                NumberOrTextResult = $"{currentValue.NumberOrTextResult}{possibleValueToAdd}"
            };

        public static bool ContainsNumber(this int i, int number)
            => i.ToString().Contains(number.ToString());

        public static bool IsDivisible(this int s, int divisor)
            => s % divisor == 0;
    }
}
