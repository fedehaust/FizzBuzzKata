namespace FizzBuzz
{
    public interface IHandler
    {
        string HandleNumber(int input, string currentValue = "");
    }
}