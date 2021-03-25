using System;

namespace FizzBuzz.ExtensionMethods
{
    public static class MethodExtensions
    {
        public static string ManageHandler(this (int, string) s, Handler nextHandler)
            => nextHandler != null
                ? nextHandler.HandleNumber(s.Item1, s.Item2)
                : string.IsNullOrEmpty(s.Item2)
                    ? s.Item1.ToString()
                    : s.Item2;

        public static (int, string) ManageDivisor(this int s, int divisor, string currentValue, string newValue)
            => s.IsDivisible(divisor)
                ? (s, newValue)
                    : (s, currentValue);


        public static (int, string) ContainsValue(this int s, string divisor, string currentValue, string newValue)
            => s.ToString().Contains(divisor)
                ? (s,
                    newValue)
                : (s, currentValue);

        public static bool ContainsNumber(this int i, int number)
            => i.ToString().Contains(number.ToString());

        public static bool IsDivisible(this int s, int divisor)
            => s % divisor == 0;

        public static string PrependIfNotContains(this string currentValue, string valueToAdd)
            => currentValue.Contains(valueToAdd) ? currentValue : $"{valueToAdd}{currentValue}";

        public static string AppendIfNotContains(this string currentValue, string valueToAdd)
            => currentValue.Contains(valueToAdd) ? currentValue : $"{currentValue}{valueToAdd}";
    }
}
