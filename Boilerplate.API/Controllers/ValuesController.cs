using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Boilerplate.API.Controllers.Abstract;

namespace Boilerplate.API.Controllers
{
    public class ValuesController : AuthorizedController
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var claims = User;
            var context = HttpContext;
            return claims.Claims.Select(x => $"{x.Type}: {x.Value}").ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
