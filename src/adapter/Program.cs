
using Adapter;

//IPayPalPayment payment = new PayonnerAdapter(new Payonner());
IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

payment.PayPalPament();
payment.PayPalReceive();

Console.ReadLine();