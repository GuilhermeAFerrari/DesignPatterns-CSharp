namespace Adapter.Interfaces
{
    public interface IPayPalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
