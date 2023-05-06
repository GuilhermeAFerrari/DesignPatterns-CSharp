using Adapter.Interfaces;

namespace Adapter.Payoneer
{
    public class Payoneer : IPayoneerPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Payoneer");
        }

        public void SendPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamento com Payoneer");
        }
    }
}
