using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace RequestResponseAbstract
{
    public class MyRequestAbstract : BaseRequestAbstract<MyResponseModel>
    {
        string Skill;

        public MyRequestAbstract(string Skill)
        {
            this.Skill = Skill;
        }

        public override HttpClient GetClient()
        {
            Method = "Get";
            Params = Skill;
            return base.GetClient("myrequest/");
        }

        public override List<MyResponseModel> Response(string response)
        {
            if(!string.IsNullOrEmpty(response))
            {
                List<MyResponseModel> myResponseModel = JsonConvert.DeserializeObject<List<MyResponseModel>>(response);
                return myResponseModel;
            }
            else
            {
                return null; 
            }
        }
    }
}
