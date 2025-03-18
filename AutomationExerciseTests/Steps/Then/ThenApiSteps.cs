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

        [Then(@"'([^']*)' should be in response '([^']*)'")]
        public void ThenShouldBeInResponse(string itemType, string fileName)
        {
            var expectedResponse = File.ReadAllText($"Resource\\{fileName}.json").Replace("\r", "").Replace("\n", "");


            switch (itemType.ToLower())
            {
                case "products":
                    {
                        var expectedResData = JsonConvert.DeserializeObject<ProductsListResponse>(expectedResponse);
                        var actualResponseData = JsonConvert.DeserializeObject<ProductsListResponse>(_context.ApiResponse.Content);
                        actualResponseData.Should().BeEquivalentTo(expectedResData);
                        break;
                    }

                case "brands":
                    {
                        var expectedResData = JsonConvert.DeserializeObject<BrandsListResponse>(expectedResponse);
                        var actualResponseData = JsonConvert.DeserializeObject<BrandsListResponse>(_context.ApiResponse.Content);
                        actualResponseData.Should().BeEquivalentTo(expectedResData);
                        break;
                    }
            }
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

    }
}
