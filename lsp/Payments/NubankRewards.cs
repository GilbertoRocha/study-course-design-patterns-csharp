namespace lsp;

internal class NubankRewards : IPaymentInstrument
{
	public void CollectPayment()
	{
		Console.WriteLine("Rewards payment");
	}

	public void Validate()
	{
		Console.WriteLine("Rewards Validate");
	}
}
