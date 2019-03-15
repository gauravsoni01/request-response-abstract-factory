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
      
        // GET api/myrequest/id
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var list = new List<MyRequestModel>();

            list.Add(new MyRequestModel { Name = "Peter", Company = "XYZ", Contact = "********", Email = "Peter@xyz.com", Location = "USA", Skill = id });
            list.Add(new MyRequestModel { Name = "Jhon", Company = "ABC", Contact = "********", Email = "Jhon@xyz.com", Location = "UK", Skill = id });
            list.Add(new MyRequestModel { Name = "Oz", Company = "EGF", Contact = "********", Email = "Oz@xyz.com", Location = "Brazil", Skill = id });

            var json = JsonConvert.SerializeObject(list);

            return json;
        }
    }
}
