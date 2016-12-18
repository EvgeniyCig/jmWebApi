using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using jmWebApi.data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Belgrade.SqlClient;
using System.Threading.Tasks;

namespace jmWebApi.Controllers
{
    [Route("api/[controller]")]
    public class tController : Controller
    {

        private readonly IQueryPipe SqlPipe;

        public tController(IQueryPipe sqlPipe)
        {
            this.SqlPipe = sqlPipe;
        }

        // GET api/t
        [HttpGet]
        public async Task Get()
        {
            await SqlPipe.Stream("select * from equipment_vendors for json auto", Response.Body, "[]");
        }
    }


    [Route("api/[controller]")]
    public class testController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
