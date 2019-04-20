using OpenQA.Selenium;
using System;

namespace ConsoleApplication1
{
    public class smartbearprj : Object
    {
        IWebDriver driver;  // null
        // int x;

        public smartbearprj(IWebDriver _driver) : base()
        {
            this.driver = _driver;
        }


        public void login()
        {
            driver.FindElement(By.Id("ctl00_MainContent_username")).SendKeys("Tester");
            driver.FindElement(By.Name("ctl00$MainContent$password")).SendKeys("test");
            driver.FindElement(By.Id("ctl00_MainContent_login_button")).Click();
        }

        public void logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.Quit(); // browser + chromedriver.exe from task manager.
             // driver.close();  closes only browser.
        }

    }
}
