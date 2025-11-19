namespace lsp;

internal class CreditCard : NubankCard
{
	public override void Validate()
	{
		Console.WriteLine("Validando Limite do credito");
		Console.WriteLine("Limite OK");
	}

}
