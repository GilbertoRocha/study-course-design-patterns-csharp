namespace Dip;

public class DbProductFactory
{
	public static IDBProduct Create()
	{
		return Program._config["DB"] switch
		{
			"SQLSERVER" => new SQLServerProduct(),
			"MONGODB" => new MongoDBProduct(),
			_ => throw new InvalidOperationException("Banco não existente")
		};
	}
}
