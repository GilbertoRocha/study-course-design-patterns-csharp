namespace Adapter;

public class MercadoPago : IMercadoPago
{
	public Token authToken()
	{
		return new Token();
	}

	public void MercadoPagoPayment()
	{
		Console.WriteLine("Enviando pagamento com MercadoPago");
	}

	public void MercadoPagoReceive()
	{
		Console.WriteLine("Recebendo pagamento com MercadoPago");
	}
}
