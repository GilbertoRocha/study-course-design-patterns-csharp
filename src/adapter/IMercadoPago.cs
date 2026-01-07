namespace Adapter;

public interface IMercadoPago
{
	Token authToken();
	void MercadoPagoPayment();
	void MercadoPagoReceive();

}
