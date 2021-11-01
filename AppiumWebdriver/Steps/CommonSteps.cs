﻿using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using static AppiumWebdriver.TestData;

namespace AppiumWebdriver.Steps
{
    [Binding]
    public class CommonSteps
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c npx appium -a 0.0.0.0 -p 4723";
            server = Process.Start(info);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            server.Kill();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            StartSession();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Quit();
        }

        /// <summary>
        /// Starts a session with the global webdriver.
        /// </summary>
        public static void StartSession()
        {
            DriverOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("appium:app", "C:\\Users\\kirby\\OneDrive\\Documents\\GitHub\\cucumber-python\\app-debug.apk");
            desiredCapabilities.AddAdditionalCapability("appium:udid", "emulator-5554");
            desiredCapabilities.PlatformName = "Android";
            var command_executor = new Uri("http://localhost:4723/wd/hub");
            driver = new AndroidDriver<IWebElement>(command_executor, desiredCapabilities, TimeSpan.FromSeconds(30));
        }

        // Then I should see a message saying '<message>'
        [Then(@"I should see a message saying '(.*)'")]
        public static void ThenIShouldSeeAMessageSaying(string message)
        {
            //
        }
    }
}
