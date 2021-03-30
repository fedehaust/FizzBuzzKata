using FizzBuzz.Handlers;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Game
    {
        private readonly IHandler _handler;

        public Game(IHandler handler)
        {
            _handler = handler;
        }
        public List<string> GetPlayAnswers(int firstElement, int range)
            => Enumerable.Range(firstElement, range)
                .Select(x => _handler.HandleNumber(x))
                .ToList();
    }
}
