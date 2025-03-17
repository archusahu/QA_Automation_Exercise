using AutomationExerciseTests.Model;

using FluentAssertions;

using Newtonsoft.Json;

using System.Net;

using TechTalk.SpecFlow;

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

        [Then(@"response should be '([^']*)'")]
        public void ThenResponseShouldBe(HttpStatusCode expectedResponseCode)
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
            actualResponseData.Should().BeEquivalentTo(expectedResData); hello
        }

    }
}
