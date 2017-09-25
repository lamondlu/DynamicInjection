using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Routing;

namespace ServiceA
{
    [RoutePrefix("api/ServiceA")]
    public class ServiceAController : ApiController
    {
        [Route("Values")]
        [HttpGet]
        public List<string> Values()
        {
            return new List<string> { "value1", "value2" };
        }

        [Route("Version")]
        [HttpGet]
        public string Version()
        {
            return "Service A, version 1.0.0";
        }
    }
}
