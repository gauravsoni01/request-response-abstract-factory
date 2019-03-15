using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RequestResponseAbstract
{
    public abstract class BaseRequestAbstract<T> where T : BaseResponseModel
    {
        private string API_URL = "http://localhost:5000/api/";

        public string Method { get; set; }

        public string Params { get; set; } = "";

        /// <summary>
        /// This methode is created to make implementation in child request classes.
        /// Using this method you can call the base class non abstract GetClient method and get paths of your multiple requests.
        /// </summary>
        /// <returns>It returns the HttpClient object.</returns>
        public abstract HttpClient GetClient();

        /// <summary>
        /// This method gets executed in child request class and takes string parameter which is a string response received by API.
        /// Hence you can deserialze this response according to response code.
        /// </summary>
        /// <returns>The response.</returns>
        /// <param name="response">Response.</param>
        public abstract List<T> Response(string response);

        /// <summary>
        /// This method actually returns the whole client object with authentication and header.
        /// </summary>
        /// <returns>The client.</returns>
        /// <param name="path">Path.</param>
        public HttpClient GetClient(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri( API_URL + path);

            return client;
        }

        /// <summary>
        /// This method actually executes the rest api work. you will call your client, load your model here in this method.
        /// Then further you will proceed to API call and returns the response accordingly.
        /// </summary>
        /// <returns>The execute.</returns>
        public List<T> Execute()
        {
            try
            {
                var client = GetClient();
                HttpResponseMessage response = null;
                if (Method.Equals(MethodEnum.Get.ToString()))
                {
                    response = client.GetAsync(Params).Result;
                }
                var responsemessage = "";
                if (response != null)
                {
                    responsemessage = response.Content.ReadAsStringAsync().Result;
                    return Response(responsemessage);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex); 
            }
            return null;
        }
    }
}
