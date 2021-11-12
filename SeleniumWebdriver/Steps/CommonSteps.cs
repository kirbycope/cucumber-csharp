using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumWebdriver.Steps
{
    [Binding]
    public class CommonSteps
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            StartSession();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestData.driver.Quit();
        }

        /// <summary>
        /// Starts a session with the global webdriver.
        /// </summary>
        public void StartSession()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"--disable-extensions");
            TestData.driver = new ChromeDriver(options);
            TestData.driver.Manage().Window.Maximize();
            TestData.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        // Then I should see a message saying '<message>'
        [Then(@"I should see a message saying '(.*)'")]
        public void ThenIShouldSeeAMessageSaying(string message)
        {
            IWebElement element = TestData.driver.FindElement(By.XPath("//*[contains(text(),'" + message + "')]"));
            element.Displayed.Should().BeTrue();
        }
    }
}
