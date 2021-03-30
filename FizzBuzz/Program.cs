using FizzBuzz.Handlers;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            new Game(new ContainsThreeHandler(new ContainsFiveHandler(new DivisibleByThreeHandler(new DivisibleByFiveHandler(null)))))
                .GetPlayAnswers(1, 100).ForEach(x => WriteLine(x));
            ReadKey();
        }

    }
}
