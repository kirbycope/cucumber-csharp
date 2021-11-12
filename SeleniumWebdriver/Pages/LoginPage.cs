using OpenQA.Selenium;

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
            return TestData.driver.FindElement(By.Id("username"));
        }

        /// <summary>
        /// The `input` for "Password".
        /// </summary>
        public static IWebElement inputPassword()
        {
            return TestData.driver.FindElement(By.Id("password"));
        }

        /// <summary>
        /// The `button` to submit a form.
        /// </summary>
        public static IWebElement btnSubmit()
        {
            return TestData.driver.FindElement(By.CssSelector("button[type='submit']"));
        }


        /// <summary>
        /// Opens `this` page.
        /// </summary>
        public static void Open()
        {
            TestData.driver.Url = TestData.baseUrl + "/login";
        }

        /// <summary>
        /// Log in using the given username and password.
        /// </summary>
        public static void Login(string username, string password)
        {
            if (username == "valid")
            {
                username = TestData.testUser;
            }
            if (password == "valid")
            {
                password = TestData.testPass;
            }
            inputUserName().SendKeys(username);
            inputPassword().SendKeys(password);
            btnSubmit().Click();
        }
    }
}
