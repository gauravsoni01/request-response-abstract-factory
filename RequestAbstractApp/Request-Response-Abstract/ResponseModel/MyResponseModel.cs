using System;

namespace RequestResponseAbstract
{
    public class MyResponseModel : BaseResponseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Skill { get; set; }
    }
}
