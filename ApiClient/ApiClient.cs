using RestSharp;

namespace ApiClient
{
    public class ApiClient
    {
        private readonly RestClient _restClient;
        public ApiClient(string baseUrl)
        {
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
    }
}
