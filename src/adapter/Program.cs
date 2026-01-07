
using Adapter;

IPayPalPayment payment = new PayonnerAdapter(new Payonner());

payment.PayPalPament();
payment.PayPalReceive();

Console.ReadLine();