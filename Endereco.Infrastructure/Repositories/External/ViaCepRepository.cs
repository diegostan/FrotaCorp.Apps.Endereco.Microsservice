using System.Net;
using System.Text.Json;
using Endereco.Application.DTOs;
using Endereco.Application.Helpers;
using Endereco.Application.Repositories.External;
using Endereco.Application.Results;

namespace Endereco.Infrastructure.Repositories.External
{
    public class ViaCepRepository : IViaCepRepository
    {
        private readonly HttpClient _client;        
        public ViaCepRepository(HttpClient client)
        {
            _client = client;
        }
        public async Task<RequestResult> GetCep(string cep)
        {                        
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = UriHelper.GetViaCepUri(cep);
            try
            {
                using(_client)
                {
                    var response = await _client.SendAsync(request);
                    if(response.StatusCode != HttpStatusCode.OK)
                        return new RequestResult().BadRequest("Erro ao tentar recuperar os dados.");
                        
                    var cepText = await response.Content.ReadAsStringAsync();
                    var cepDto = JsonSerializer.Deserialize<ViaCepDTO>(cepText);


                    return new RequestResult().Ok(cepDto);
                }
            }
            catch(Exception ex)
            {
                return new RequestResult().BadRequest(ex.Message);
            }            
        }
    }
}