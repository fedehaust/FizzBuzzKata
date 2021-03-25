namespace FizzBuzz
{
    public abstract class Handler

    {
        protected Handler nextHandler;
        public Handler(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract string HandleNumber(int input, string currentValue = "");
    }
}
