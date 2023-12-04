using System;
using System.Text.Json;
using Refit;
using System.Text.Json.Serialization;
using System.Linq;
using System.Collections.Generic;

class Program
{
	static async Task Main()
	{
	try
	{
		var CustomerZipCode = RestService.For<ICepApi>("https://viacep.com.br");
		Console.WriteLine("Inform your postal code: ");

		string ZipCodeInformation = Console.ReadLine().ToString();
		Console.WriteLine("Querying Informed Zip Code ... " + ZipCodeInformation);

		var address = await CustomerZipCode.GetAddressAsync(ZipCodeInformation);
		Console.WriteLine($"\nPublic Place: {address.Logradouro}\nComplement: {address.Complemento}\nNeighborhood: {address.Bairro}\nCity: {address.Localidade}\nFederation Unity: {address.Uf}\nIBGE: {address.Ibge}\nICMS Information and Calculation Guide: {address.Gia}\nDDD: {address.Ddd}\nIntegrated Financial Administration System: {address.Siafi}");
		Console.ReadKey();
		
	} catch(Exception e)
	{
		Console.WriteLine("Error in CEP query: " + e.Message);
	}

	}
}
