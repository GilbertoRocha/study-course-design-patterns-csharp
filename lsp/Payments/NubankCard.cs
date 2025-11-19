namespace lsp;

internal abstract class NubankCard : IPaymentInstrument
{
	public void CollectPayment()
	{
		Console.WriteLine("Pagamento realizado");
	}

	public virtual void Validate()
	{
		Console.WriteLine("Validação do cartao realizada");
	}
}
