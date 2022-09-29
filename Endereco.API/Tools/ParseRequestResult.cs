using System.Net;
using Endereco.Application.Results;
using Microsoft.AspNetCore.Mvc;

namespace Endereco.API.Tools
{
    public class ParseRequestResult : Controller
    {
        public ActionResult ParseToActionResult(RequestResult request)
        {
            switch (request.StatusCode)
            {
                case (int)HttpStatusCode.OK:
                    return Ok(request);
                case (int)HttpStatusCode.BadRequest:
                    return BadRequest(request);
                default:
                    return BadRequest(request);
            }
        }
    }
}