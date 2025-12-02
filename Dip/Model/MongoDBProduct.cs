namespace Dip;

public class MongoDBProduct : IDBProduct
{
	public string GetProductByID(string id)
	{
		return $"MongoDB: Exbindo dados do produto {id}";
	}

}
