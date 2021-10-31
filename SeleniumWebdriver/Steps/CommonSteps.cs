using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static SeleniumWebdriver.TestData;

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
            driver.Quit();
        }

        /// <summary>
        /// Starts a session with the global webdriver.
        /// </summary>
        public void StartSession()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"--disable-extensions");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        // Then I should see a message saying '<message>'
        [Then(@"I should see a message saying '(.*)'")]
        public void ThenIShouldSeeAMessageSaying(string message)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[contains(text(),'" + message + "')]"));
            element.Displayed.Should().BeTrue();
        }
    }
}
