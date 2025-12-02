namespace Dip;

public class SQLServerProduct : IDBProduct
{

	public string GetProductByID(string id)
	{
		return $"SQLServer: Exbindo dados do produto {id}";
	}

}
