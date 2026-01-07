namespace Adapter;

public interface IPayonnerPayment
{
	Token authToken();
	void SendPayment();
	void ReceivePayment();

}
