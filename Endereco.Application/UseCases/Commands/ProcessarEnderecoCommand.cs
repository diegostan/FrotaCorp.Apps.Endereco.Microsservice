namespace Endereco.Application.UseCases.Commands
{
    public class ProcessarEnderecoCommand : ICommand
    {
        public int NumeroLogradouro { get; set; }
        public string Cep { get; set; }
    }
}