using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ServiceB
{
    public class ServiceBController : ApiController
    {
        [HttpGet]
        public List<string> Values()
        {
            return new List<string> { "value3", "value4" };
        }
    }
}
