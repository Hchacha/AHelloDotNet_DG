using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OWIN.WebApi.Controllers
{
   public  class ValuesController :ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {"value1","value2" };
        }

        [HttpGet]
        public IEnumerable<string> Get(string id)
        {
            return new string[] { "value1", "value2" };
        }
    }
}
