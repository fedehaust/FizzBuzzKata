using FizzBuzz.Handlers;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Game
    {
        public static List<string> GetPlayAnswers()
        {
            var pipeline = new ContainsThreeHandler(new ContainsFiveHandler(new DivisibleByThreeHandler(new DivisibleByFiveHandler(null))));
            var result = Enumerable.Range(1, 100).Select(x => pipeline.HandleNumber(x)).ToList();
            return result;
        }
    }
}
