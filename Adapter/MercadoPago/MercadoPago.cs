using Adapter.Interfaces;

namespace Adapter.MercadoPago
{
    public class MercadoPago : IMercadoPagoPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void MakePayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamento com mercado pago");
        }

        public void MakeReceive()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamento com mercado pago");
        }
    }
}
