namespace Adapter.Interfaces
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void MakePayment();
        void MakeReceive();
    }
}
