using System;
using System.Diagnostics;
using Altom.AltUnityDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AltUnityWebdriver.Steps
{
    [Binding]
    public class CommonSteps
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c npx appium -a 0.0.0.0 -p 4723";
            TestData.server = Process.Start(info);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestData.server.Kill();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            StartSession();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            TestData.driver.Quit();
            TestData.altUnityDriver.Stop();
            AltUnityPortForwarding.RemoveForwardAndroid();
        }

        /// <summary>
        /// Starts a session with the global webdriver.
        /// </summary>
        public static void StartSession()
        {
            DriverOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("appium:app", "C:\\Users\\kirby\\OneDrive\\Documents\\GitHub\\cucumber-csharp\\AltUnityWebdriver\\trashcat.apk");
            desiredCapabilities.AddAdditionalCapability("appium:udid", "R58M209SNTT");// "emulator-5554");
            desiredCapabilities.PlatformName = "Android";
            var command_executor = new Uri("http://localhost:4723/wd/hub");
            TestData.driver = new AndroidDriver<IWebElement>(command_executor, desiredCapabilities, TimeSpan.FromSeconds(30));
            AltUnityPortForwarding.ForwardAndroid();
            TestData.altUnityDriver = new AltUnityDriver();
        }

        // Given I open the '<name>' scene
        [Given(@"I open the '(.*)' scene")]
        public void GivenIOpenTheScene(string name)
        {
            TestData.altUnityDriver.LoadScene(name);
        }

    }
}
