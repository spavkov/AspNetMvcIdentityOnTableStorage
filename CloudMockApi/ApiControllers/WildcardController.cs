using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace CloudMockApi.ApiControllers
{
    public class WildcardController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.HttpGet]
        [System.Web.Http.AllowAnonymous]

        public Task<HttpResponseMessage> CatchAll()
        {
            var resp = new HttpResponseMessage()
            {
                Content = new StringContent("[{\"Name\":\"ABC\"},[{\"A\":\"1\"},{\"B\":\"2\"},{\"C\":\"3\"}]]")
            };

            return Task.FromResult(resp);
        }
    }
}