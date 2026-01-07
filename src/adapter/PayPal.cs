namespace Adapter;

public class PayPal : IPayPalPayment
{

	public Token authToken()
	{
		return new Token();
	}

	public void PayPalPament()
	{
		Token token = authToken();
		Console.WriteLine("Enviando pagamento com PayPal");
	}

	public void PayPalReceive()
	{
		Console.WriteLine("Recebendo pagamento com PayPal");
	}
}
