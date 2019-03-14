using System;
using System.Net.Http;

namespace RequestResponseAbstract
{
    public class MyRequestAbstract : BaseRequestAbstract<BaseResponseModel>
    {
        public MyRequestAbstract()
        {
        }

        public override HttpClient GetClient()
        {
            return base.GetClient("");
        }

        public override BaseRequestModel RequestModel()
        {
            return new BaseRequestModel();
        }

        public override BaseResponseModel Response(string response)
        {
            return new BaseResponseModel();
        }
    }
}
