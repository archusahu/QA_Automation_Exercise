using ApiClient;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using TechTalk.SpecFlow;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace AutomationExerciseTests
{
    [Binding]
    public class Hooks
    {
        private readonly Context _context; // Injected context
        private IWebDriver _driver; // Non-static WebDriver instance

        public Hooks(Context context)
        {
            Console.WriteLine(" I am in hoooks constructor");
            _context = context; // Store context for later use            
        }

        [BeforeScenario("Api", "api")]
        public void BeforeScenarioApi()
        {
            Console.WriteLine(" I am in BeforeScenarioApi Method");
            _context.ApiClient = new Client("https://automationexercise.com/api/");
        }

        [BeforeScenario("Web", "web")]
        public void BeforeScenario()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver(); // Create WebDriver instance
            _context.Driver = _driver; // Store in context so steps can access it
        }

        [AfterScenario("Web", "web")]
        public void AfterScenario()
        {
            if (_driver != null)
            {
                _driver.Quit(); // Ensure WebDriver is properly closed
                _driver.Dispose(); // Free up resources
            }
        }
    }
}
