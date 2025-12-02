using System.Runtime.Serialization;
using System.Security.Authentication.ExtendedProtection;
using Dip;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
	internal static IConfiguration _config;
	private static void Main(string[] args)
	{
		var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("Dip/appsettings.json", optional: false, reloadOnChange: true)
			.Build();

		_config = configuration;

		PaymentProcess payment = new();
		payment.Pay("ABC123");

		Console.ReadLine();
	}
}