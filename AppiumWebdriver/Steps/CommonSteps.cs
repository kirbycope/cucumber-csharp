using TechTalk.SpecFlow;

namespace AppiumWebdriver.Steps
{
    [Binding]
    public class CommonSteps
    {
        [BeforeScenario]
        public void SetupTestUsers()
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
