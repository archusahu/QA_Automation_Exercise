using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace AutomationExerciseTests
{
    [Binding]
    public class Hooks
    {
        private static ChromeDriver _driver; //The actual WebDriver instance created (e.g., new ChromeDriver()).


        [BeforeScenario]

        public void BeforeScenario(Context context)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();// Create WebDriver instance
            context.Driver = _driver;// Store it in context for later use, so it can be accessed in different step definitions.
        }

        [AfterScenario]
        public void AfterScenario(Context context)
        {
            _driver.Close(); // Closes the browser
            _driver.Quit();
            _driver.Dispose();// Frees up resources

        }
    }
}
