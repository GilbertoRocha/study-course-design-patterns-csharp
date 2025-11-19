namespace lsp;

internal class DebitCard : NubankCard
{
	public override void Validate()
	{
		Console.WriteLine("Verificar o saldo");
		Console.WriteLine("Saldo Disponivel");
	}

}
