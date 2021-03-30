namespace FizzBuzz
{
    public abstract class Handler : IHandler

    {
        protected IHandler nextHandler;
        public Handler(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract string HandleNumber(int input, string currentValue = "");
    }
}
