using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Routing;

namespace ServiceA
{
    public class ServiceAController : ApiController
    {
        [HttpGet]
        public List<string> Values()
        {
            return new List<string> { "value1", "value2" };
        }
    }
}
