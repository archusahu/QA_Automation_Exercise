using TechTalk.SpecFlow;

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


    }
}
