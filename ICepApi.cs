using System.Threading.Tasks;
using Refit;
using System.Text.Json;

public interface ICepApi
{
	[Get("/ws/{cep}/json")]
	Task<CepResponse> GetAddressAsync(string cep);

}
