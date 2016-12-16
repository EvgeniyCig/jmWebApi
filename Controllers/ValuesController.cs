using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using jmWebApi.data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace jmWebApi.Controllers
{
    [Route("api/[controller]")]
    public class tController : Controller
    {
        public jContext _db;

        public tController(jContext context)
        {
            _db=context;
        }
        // GET api/t
        [HttpGet]
        public IEnumerable<jsonstring> Get()
        {
            var ttt = _db.jstring.AsNoTracking().FromSql("select * from vendors FOR JSON PATH").ToList();
            return ttt;
        }
    }


    [Route("api/[controller]")]
    public class ValuesController : Controller
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
