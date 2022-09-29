using Endereco.Application.DTOs;
using Endereco.Domain.Entities;

namespace Endereco.Application.UseCases.Tools
{
    public partial class EntityMapper
    {
        public static EnderecoEntity ParseEndereco(ViaCepDTO cepDTO, int numeroLogradouro)
        {
            return 
                new EnderecoEntity
                (
                    cep: cepDTO.Cep,
                    logradouro: cepDTO.Logradouro,
                    unidadeFederacao: cepDTO.Uf,
                    numeroLogradouro: numeroLogradouro,
                    bairro: cepDTO.Bairro                    
                );
        }
    }
}