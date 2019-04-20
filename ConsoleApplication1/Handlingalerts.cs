using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Handlingalerts
    {
        static IWebDriver driver;

        //static void Main()
        //{
        //    openapp();
        //        handlealert();
        //}
        
        public static void openapp()
        {
            driver = new ChromeDriver(@"D:\Library\Drivers");
            driver.Navigate().GoToUrl("https://www.spicejet.com/");
            driver.Manage().Window.Maximize();
        }

        public static void handlealert()
        {
            driver.FindElement(By.Id("divpaxinfo")).Click();
            System.Threading.Thread.Sleep(1000);

            for(int i=1; i<=9; i++)
            {
                driver.FindElement(By.Id("hrefIncAdt")).Click();
            }
                

            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();
            //driver.FindElement(By.Id("hrefIncAdt")).Click();

            System.Threading.Thread.Sleep(3000);
            string alerttext = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alerttext);
    
            driver.SwitchTo().Alert().Accept();

            if (alerttext.Contains("please call our reservation center."))
                Console.WriteLine("test case passed");
            else
                Console.WriteLine("test case failed");

        }
    }
}
