namespace Adapter.Interfaces
{
    public interface IPayoneerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
