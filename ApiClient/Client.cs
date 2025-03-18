using ApiClient.Models;

using RestSharp;

using System;

namespace ApiClient
{
    public class Client
    {
        private readonly RestClient _restClient;
        public Client(string baseUrl)
        {
            Console.WriteLine(" I am in Client constructor");
            var restClientOption = new RestClientOptions(baseUrl);
            _restClient = new RestClient(restClientOption);
        }

        public RestResponse SendGetRequest(string url)
        {
            var request = new RestRequest(url) { Method = Method.Get };
            Console.WriteLine($"{url}");
            return _restClient.Execute(request);
        }

        public RestResponse SendPostRequest(string url, string body)
        {
            var request = new RestRequest(url) { Method = Method.Post };
            request.AddJsonBody(body);
            return _restClient.Execute(request);
        }

        public RestResponse SendPostLoginRequest(string url, string userId, string pwd)
        {
            var request = new RestRequest(url) { Method = Method.Post };
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("email", userId);
            request.AddParameter("password", pwd);            
            return _restClient.Execute(request);
        }

        public RestResponse PostSearchProductRequest(string url, string product)
        {
            var request = new RestRequest(url) { Method = Method.Post };
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("search_product", product);
            return _restClient.Execute(request);
        }

        public RestResponse PostWithParameters(string endpoint, IEnumerable<ApiRequestParameterModel> parameterList)
        {
            var request = new RestRequest(endpoint) { Method = Method.Post };
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            foreach(var parameter in parameterList)
            {
                request.AddParameter(parameter.ParameterName, parameter.ParameterValue);
            }
            return _restClient.Execute(request);
        }
    }
}
