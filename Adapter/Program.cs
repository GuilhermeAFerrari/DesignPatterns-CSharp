using Adapter.Interfaces;
using Adapter.MercadoPago;
using Adapter.Payoneer;
using Adapter.PayPal;

//IPayPalPayment payment = new PayPal();
//IPayPalPayment payment = new PayoneerAdapter(new Payoneer());
IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

payment.PayPalPayment();
payment.PayPalReceive();

Console.ReadLine();