using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kubel.WebApi.Controllers
{
    public class CdsController : ApiController
    {
        // GET api/cds
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/cds/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/cds
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cds/5
        public void Delete(int id)
        {
        }
    }
}
