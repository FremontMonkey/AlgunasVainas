using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace Subdirect.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class EchoController : Controller
    {
        private readonly ILogger<EchoController> logger;

        public EchoController(
             ILogger<EchoController> logger
            )
        {
            this.logger = logger;
        }

        // GET api/echo?value=somestring
        [HttpGet]
        public string Get(string value)
        {
            logger.LogInformation("Entering {Method:l} value: {@value}", MethodBase.GetCurrentMethod().Name, value);
            return $"ECHO: {value}";
        }
    }
}