namespace Dip;

public class PaymentProcess
{

	public void Pay(string id)
	{
		IDBProduct product = DbProductFactory.Create();

		string productData = product.GetProductByID(id);
		Console.WriteLine(productData);
	}

}
