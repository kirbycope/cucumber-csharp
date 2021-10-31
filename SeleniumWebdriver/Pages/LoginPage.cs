using OpenQA.Selenium;
using static SeleniumWebdriver.TestData;

namespace SeleniumWebdriver.Pages
{
    /// <summary>
    /// URL looks like: {baseURL}/login
    /// </summary>
    public static class LoginPage
    {

        /// <summary>
        /// The `input` for "Username".
        /// </summary>
        public static IWebElement inputUserName()
        {
            return driver.FindElement(By.Id("username"));
        }

        /// <summary>
        /// The `input` for "Password".
        /// </summary>
        public static IWebElement inputPassword()
        {
            return driver.FindElement(By.Id("password"));
        }

        /// <summary>
        /// The `button` to submit a form.
        /// </summary>
        public static IWebElement btnSubmit()
        {
            return driver.FindElement(By.CssSelector("button[type='submit']"));
        }


        /// <summary>
        /// Opens `this` page.
        /// </summary>
        public static void Open()
        {
            driver.Url = baseUrl + "/login";
        }

        /// <summary>
        /// Log in using the given username and password.
        /// </summary>
        public static void Login(string username, string password)
        {
            if (username == "valid")
            {
                username = testUser;
            }
            if (password == "valid")
            {
                password = testPass;
            }
            inputUserName().SendKeys(username);
            inputPassword().SendKeys(password);
            btnSubmit().Click();
        }
    }
}
