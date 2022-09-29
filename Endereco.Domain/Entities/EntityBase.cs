namespace Endereco.Domain.Entities
{
    public abstract class EntityBase
    {
        public DateTime DataCriacao => DateTime.Now;
    }
}