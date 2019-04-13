using System.Net;

namespace NetCoreApi.HttpContext
{
    public abstract class Response
    {
        public string ErrorMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
