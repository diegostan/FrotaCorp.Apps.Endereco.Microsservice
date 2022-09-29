namespace Endereco.Application.Helpers
{
    public static class UriHelper
    {
        public static Uri GetViaCepUri(string cep)
        {
            return new Uri($"https://viacep.com.br/ws/{cep}/json/");
        }
    }
}