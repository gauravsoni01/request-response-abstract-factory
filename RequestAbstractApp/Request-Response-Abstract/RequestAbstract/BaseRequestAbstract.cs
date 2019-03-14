using System;
using System.Net.Http;

namespace RequestResponseAbstract
{
    public abstract class BaseRequestAbstract<T> where T : BaseResponseModel
    {
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
        public abstract T Response(string response);

        /// <summary>
        /// This method creates the request model object to put in API execute method.
        /// </summary>
        /// <returns>The model.</returns>
        public abstract BaseRequestModel RequestModel();

        /// <summary>
        /// This method actually returns the whole client object with authentication and header.
        /// </summary>
        /// <returns>The client.</returns>
        /// <param name="path">Path.</param>
        public HttpClient GetClient(string path)
        {
            return new HttpClient(); 
        }

        /// <summary>
        /// This method actually executes the rest api work. you will call your client, load your model here in this method.
        /// Then further you will proceed to API call and returns the response accordingly.
        /// </summary>
        /// <returns>The execute.</returns>
        public T Execute()
        {
            return Response("");
        }
    }
}
