using FizzBuzz.Handlers;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Game
    {
        public static List<string> GetPlayAnswers(int firstElement, int range)
        {
            var pipeline = new ContainsThreeHandler(new ContainsFiveHandler(new DivisibleByThreeHandler(new DivisibleByFiveHandler(null))));
            var result = Enumerable.Range(firstElement, range).Select(x => pipeline.HandleNumber(x)).ToList();
            return result;
        }
    }
}
