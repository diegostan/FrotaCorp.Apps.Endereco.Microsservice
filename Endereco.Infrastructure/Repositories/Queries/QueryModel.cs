namespace Endereco.Infrastructure.Repositories.Queries
{
    public class QueryModel
    {
        public QueryModel(string query, object parameters)
        {
            Query = query;
            Parameters = parameters;
        }

        public string Query { get; set; }
        public object Parameters { get; set; }
    }
}