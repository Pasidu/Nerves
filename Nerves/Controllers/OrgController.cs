using Nerves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Nerves.Controllers
{
    public class OrgController : ApiController
    {
        IRepository repo = null;

        public OrgController() {
            repo = new Repository();
        }
        
        [HttpGet]
        public IHttpActionResult GetOrganizationById(int id) {

            var org = repo.OrganizationGetById(id);
            if (org == null) {
                return NotFound();
            }

            return Ok(org);
        }


        [HttpGet]
        public IHttpActionResult GetOrganizations()
        {

            var org = repo.OrganizationGetAll();

            return Ok(org);
        }

        [HttpPost]
        public IHttpActionResult SaveOrganization(Organization org) {
            repo.OrganizationSave(org);
            return Ok();
        }
    }
}
