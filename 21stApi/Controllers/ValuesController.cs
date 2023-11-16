using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _21stApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        public List<string> vs = new List<string>()
            {
                "value0",
                "value1",
                "value2",
                "value3",
                "value4"
            };
        public IEnumerable<string> Get()
        {
            return vs;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return vs[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            vs.Add(value);
            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            vs[id]=value;

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            vs.RemoveAt(id);
        }
    }
}
