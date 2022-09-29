using Endereco.Application.DTOs;
using Endereco.Application.Results;

namespace Endereco.Application.Repositories.External
{
    public interface IViaCepRepository
    {
        Task<RequestResult> GetCep(string cep);
    }
}