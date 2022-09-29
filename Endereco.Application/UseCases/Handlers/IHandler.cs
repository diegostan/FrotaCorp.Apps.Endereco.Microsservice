using Endereco.Application.Results;
using Endereco.Application.UseCases.Commands;

namespace Endereco.Application.UseCases.Handlers
{
    public interface IHandler<T> 
    where T : ICommand 
    {
         Task<RequestResult> Handle(T command);
    }
}