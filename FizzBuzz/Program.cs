using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.GetPlayAnswers(1, 100).ForEach(x => WriteLine(x));
            ReadKey();
        }

    }
}
