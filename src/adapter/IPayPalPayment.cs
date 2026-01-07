namespace Adapter;

public interface IPayPalPayment
{
	Token authToken();
	void PayPalPament();
	void PayPalReceive();

}
