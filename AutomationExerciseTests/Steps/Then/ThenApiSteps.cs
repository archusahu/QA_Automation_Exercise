using AutomationExerciseTests.Model;

using FluentAssertions;

using Newtonsoft.Json;

using System.Net;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationExerciseTests.Steps.Then
{
    [Binding]
    public class ThenApiSteps
    {
        private Context _context;

        public ThenApiSteps(Context context)
        {
            _context = context;
        }

        [Then(@"response status code should be '([^']*)'")]
        public void ThenResponseStatusCodeShouldBe(HttpStatusCode expectedResponseCode)
        {
            var actualResponseCode = _context.ApiResponse.StatusCode;
            actualResponseCode.Should().Be(expectedResponseCode);
        }


        [Then(@"response should contain '([^']*)' data")]
        public void ThenResponseShouldContainData(string fileName)
        {
            var expectedResponse = File.ReadAllText($"Resource\\{fileName}.json").Replace("\r", "").Replace("\n", "");
            var expectedResData = JsonConvert.DeserializeObject<ProductsListResponse>(expectedResponse);
            var actualResponseData = JsonConvert.DeserializeObject<ProductsListResponse>(_context.ApiResponse.Content);
            Console.WriteLine($"response content - {_context.ApiResponse.Content}");
            actualResponseData.Should().BeEquivalentTo(expectedResData);
        }

        [Then(@"response should contain message '([^']*)'")]
        public void ThenResponseShouldContainMessage(string expectedMessage)
        {
            var actualResponseContent = _context.ApiResponse.Content;
            actualResponseContent.Should().Contain(expectedMessage);
        }

        [Then(@"response content contains '([^']*)' response code")]
        public void ThenResponseContentContainsResponseCode(string expectedResponseCode)
        {
            var actualResponseContent = _context.ApiResponse.Content;
            actualResponseContent.Should().Contain(expectedResponseCode);
        }

        [Then(@"response contians")]
        public void ThenResponseContians(Table table)
        {
            var expectedMessage = table.CreateInstance<ErrorResponseModel>();
            var actualResponseData = JsonConvert.DeserializeObject<ErrorResponseModel>(_context.ApiResponse.Content);
            actualResponseData.Should().BeEquivalentTo(expectedMessage);
        }

        [Then(@"response should contain all '([^']*)' data")]
        public void ThenResponseShouldContainAllData(string FileBrandList)
        {
            var expectedResponse = File.ReadAllText($"Resource\\{FileBrandList}.json").Replace("\r", "").Replace("\n", "");
            var expectedResData = JsonConvert.DeserializeObject<BrandsListResponse>(expectedResponse);
            var actualResponseData = JsonConvert.DeserializeObject<BrandsListResponse>(_context.ApiResponse.Content);
            Console.WriteLine($"response content - {_context.ApiResponse.Content}");
            actualResponseData.Should().BeEquivalentTo(expectedResData);
        }


    }
}
