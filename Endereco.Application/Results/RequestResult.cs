namespace Endereco.Application.Results
{
    public class RequestResult
    {
        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public object Data { get; private set; }

        public RequestResult Ok(object data)
        {
            this.StatusCode = 200;
            this.Message = "Requisição realizada com sucesso";
            this.Data = data;
            return this;
        }

        public RequestResult BadRequest(string detail, object data = null)
        {
            this.StatusCode = 400;
            this.Message = $"Falha ao realizar a requisição. Mais detalhes: {detail}";
            this.Data = data;
            return this;
        }
    }
}