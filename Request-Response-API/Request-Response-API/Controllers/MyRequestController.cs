using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace Request_Response_API
{
    [Route("api/[controller]")]
    public class MyRequestController : ControllerBase
    {
        // GET api/myrequest
        [HttpGet]
        public string Get()
        {
            var list = new List<MyRequestModel>();

            list.Add(new MyRequestModel { Name = "Peter", Company = "XYZ", Contact = "********", Email = "Peter@xyz.com", Location = "USA", Skill = "C#" });
            list.Add(new MyRequestModel { Name = "Jhon", Company = "ABC", Contact = "********", Email = "Jhon@xyz.com", Location = "UK", Skill = "C#" });
            list.Add(new MyRequestModel { Name = "Oz", Company = "EGF", Contact = "********", Email = "Oz@xyz.com", Location = "Brazil", Skill = "C#" });

            var json = JsonConvert.SerializeObject(list);

            return json;
        }

        // GET api/myrequest/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/myrequest
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/myrequest/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/myrequest/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
