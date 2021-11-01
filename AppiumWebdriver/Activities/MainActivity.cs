using System;
using System.Threading;
using OpenQA.Selenium;
using static AppiumWebdriver.TestData;

namespace AppiumWebdriver.Activities
{
    public class MainActivity
    {
        /// <summary>
        /// The `input` for "Username".
        /// </summary>
        public static IWebElement editTextEnterAMessage()
        {
            return driver.FindElement(By.Id("editTextTextPersonName"));
        }

        /// <summary>
        /// The 'SEND' `button`.
        /// </summary>
        public static IWebElement buttonSend()
        {
            return driver.FindElement(By.Id("button"));
        }

        /// <summary>
        /// Opens _this_ activity.
        /// </summary>
        public static void Open()
        {
            Console.WriteLine(); // being the default activity there is nothing to do here
        }

        /// <summary>
        /// Enters the given message and then clicks the 'SEND' button.
        /// </summary>
        public static void SendMessage(string message)
        {
            editTextEnterAMessage().SendKeys(message);
            buttonSend().Click();
            Thread.Sleep(250);
        }
    }
}
