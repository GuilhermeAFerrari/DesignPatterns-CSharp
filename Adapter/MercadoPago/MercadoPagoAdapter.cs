using Adapter.Interfaces;

namespace Adapter.MercadoPago
{
    public class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago _mercadoPago;
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de MercadoPago para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            _mercadoPago.MakePayment();
        }

        public void PayPalReceive()
        {
            _mercadoPago.MakeReceive();
        }
    }
}
