namespace FizzBuzz
{
    public abstract class Handler : IHandler

    {
        protected Handler nextHandler;
        public Handler(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract string HandleNumber(int input, string currentValue = "");
    }
}
