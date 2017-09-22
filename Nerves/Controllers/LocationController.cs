using Nerves.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Nerves.Controllers
{
    [NotImplExceptionFilter]
    public class LocationController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetLocation() {
            throw new NotImplementedException();
        }
    }
}
