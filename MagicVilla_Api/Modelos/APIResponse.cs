using System.Net;

namespace MagicVilla_Api.Modelos
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsExitoso { get; set; } = true;

        public List<string> ErrorMessages { get; set; }

        public Object Resultado { get; set; }
    }
}
