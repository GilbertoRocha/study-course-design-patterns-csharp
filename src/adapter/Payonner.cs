namespace Adapter;

public class Payonner : IPayonnerPayment
{
	public Token authToken()
	{
		return new Token();
	}

	public void SendPayment()
	{
		Token token = authToken();
		Console.WriteLine("Enviando pagamento com Payonner");
	}

	public void ReceivePayment()
	{
		Console.WriteLine("Recebendo pagamento com Payonner");
	}

}
