namespace ChainOfResponsibility.Middlewares
{
    public abstract class Middleware
    {
        private Middleware _next;

        public Middleware LinkWith(Middleware next)
        {
            _next = next;
            return next;
        }

        public abstract bool Check(string email, string password);

        protected bool CheckNext(string email, string password)
        {
            if (_next is null)
                return true;

            return _next.Check(email, password);
        }
    }
}
