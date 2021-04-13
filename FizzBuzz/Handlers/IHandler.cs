namespace FizzBuzz
{
    public interface IHandler
    {
        string HandleNumber(int input);
        string HandleNumber(NumberPipelineResult input);
    }
}