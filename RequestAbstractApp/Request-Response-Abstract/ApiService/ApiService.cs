using System;
namespace RequestResponseAbstract
{
    public class ApiService
    {
        public ApiService()
        {
        }

        public void MyRequestResponse()
        {
            MyRequestAbstract myRequestAbstract = new MyRequestAbstract("C#");
             myRequestAbstract.Execute(); 
        }
    }
}
