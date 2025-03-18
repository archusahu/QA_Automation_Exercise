using ApiClient.Models;

using AutomationExerciseTests.Model;

using System.Net;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace AutomationExerciseTests.Steps.When
{
    [Binding]
    public class WhenApiSteps
    {
        private readonly Context _context;

        public WhenApiSteps(Context context)
        {
            _context = context;
        }

        [When(@"get all products list")]
        public void WhenGetAllProductsList()
        {
            _context.ApiResponse = _context.ApiClient.SendGetRequest("https://automationexercise.com/api/productsList");
        }

        [When(@"post all products list")]
        public void WhenPostAllProductsList()
        {
            _context.ApiResponse = _context.ApiClient.SendPostRequest("https://automationexercise.com/api/productsList", "");
        }

        [When(@"post search product")]
        public void WhenPostSearchProduct()
        {
            _context.ApiResponse = _context.ApiClient.SendPostRequest("https://automationexercise.com/api/searchProduct", "");
        }

        [When(@"get '([^']*)'")]
        public void WhenGet(string endpoint)
        {
            _context.ApiResponse = _context.ApiClient.SendGetRequest(endpoint);
        }

        [When(@"post '([^']*)'")]
        public void WhenPost(string endpoint)
        {
            _context.ApiResponse = _context.ApiClient.SendPostRequest(endpoint, "");
        }

        [When(@"post '([^']*)' with parameters")]
        public void WhenPostWithParameters(string endpoint, Table table)
        {
            var parameterList = table.CreateSet<ApiRequestParameterModel>();
            _context.ApiResponse = _context.ApiClient.PostWithParameters(endpoint, parameterList);
        }


        [When(@"post '([^']*)' with '([^']*)' and '([^']*)'")]
        public void WhenPostWithAnd(string endpoint, string userId, string password)
        {
            _context.ApiResponse = _context.ApiClient.SendPostLoginRequest(endpoint, userId, password);
        }       

        [When(@"post '([^']*)' with '([^']*)'")]
        public void WhenPostWith(string endpoint, string searchProduct)
        {
            _context.ApiResponse = _context.ApiClient.PostSearchProductRequest(endpoint, searchProduct);
        }

    }
}
