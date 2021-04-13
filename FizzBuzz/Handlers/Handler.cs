namespace FizzBuzz
{
    public abstract class Handler : IHandler

    {
        protected IHandler NextHandler;
        public Handler(IHandler nextHandler)
            => NextHandler = nextHandler;
        public string HandleNumber(int input) =>
            HandleNumber(new NumberPipelineResult { Input = input });
        public abstract string HandleNumber(NumberPipelineResult input);
    }
}
