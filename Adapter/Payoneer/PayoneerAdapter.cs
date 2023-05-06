using Adapter.Interfaces;

namespace Adapter.Payoneer
{
    public class PayoneerAdapter : IPayPalPayment
    {
        private Payoneer _payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            _payoneer = payoneer;
            Console.WriteLine("Realizando adaptação de Payoneer para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return _payoneer.AuthToken();
        }

        public void PayPalPayment()
        {
            _payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            _payoneer.ReceivePayment();
        }
    }
}
