namespace Adapter;

public class MercadoPagoAdapter : IPayPalPayment
{
	private IMercadoPago mercadoPago;

	public MercadoPagoAdapter(IMercadoPago mercadoPago)
	{
		this.mercadoPago = mercadoPago;
	}

	public Token authToken()
	{
		return this.mercadoPago.authToken();
	}

	public void PayPalPament()
	{
		this.mercadoPago.MercadoPagoPayment();
	}

	public void PayPalReceive()
	{
		this.mercadoPago.MercadoPagoReceive();
	}
}
