namespace Adapter;

public class PayonnerAdapter : IPayPalPayment
{
	private Payonner payonner;

	public PayonnerAdapter(Payonner payonner)
	{
		this.payonner = payonner;
	}

	public Token authToken()
	{
		return this.payonner.authToken();
	}

	public void PayPalPament()
	{
		payonner.SendPayment();
	}

	public void PayPalReceive()
	{
		payonner.ReceivePayment();
	}
}
