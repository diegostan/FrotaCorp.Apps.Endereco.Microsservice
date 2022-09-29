using System.Net;
using Endereco.Application.DTOs;
using Endereco.Application.Repositories.External;
using Endereco.Application.Results;
using Endereco.Application.UseCases.Commands;
using Endereco.Application.UseCases.Tools;

namespace Endereco.Application.UseCases.Handlers
{
    public class ProcessarEnderecoHandler : IHandler<ProcessarEnderecoCommand>
    {
        private readonly IViaCepRepository _repository;
        public ProcessarEnderecoHandler(IViaCepRepository repository)
        {
            _repository = repository;
        }
        public async Task<RequestResult> Handle(ProcessarEnderecoCommand command)
        {
            var cepResult = await _repository.GetCep(command.Cep);

            if(cepResult.StatusCode != (int)HttpStatusCode.OK)
                return cepResult;

            var cepDTO = cepResult.Data as ViaCepDTO;
            var endereco = EntityMapper.ParseEndereco(cepDTO, command.NumeroLogradouro);

            if(!endereco.IsValid)
                return new RequestResult().BadRequest("Verifique os campos e tente novamente", endereco);

            return new RequestResult().Ok(endereco);
        }
    }
}