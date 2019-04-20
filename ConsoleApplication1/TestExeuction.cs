using ConsoleApplication1;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class TestExeuction
    {
        IWebDriver driver;

        public enum browsertype
        {
            firefox=10,
            ie,
            safari=20,
            edge,
            chrome
        }

        public enum week
        {
            Sun,
            Mon
            
        }

        public enum Usertype
        {
            admin,
            manager,
            customer,
            support
        }


       public void launchapp(String browser)
        {
            switch (browser.Trim().ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver(@"D:\Library\Drivers");
                    break;
                case "firefox":
                    break;

                default:
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://secure.smartbearsoftware.com/samples/testcomplete12/WebOrders/Login.aspx");
        }


        public void launchapp(browsertype browser)
        {
            switch (browser)
            {
                case browsertype.chrome:
                    driver = new ChromeDriver(@"D:\Library\Drivers");
                    break;
                case browsertype.firefox:
                    break;
                case browsertype.ie:
                    break;
                case browsertype.safari:
                    break;
                case browsertype.edge:
                    break;
                default:
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://secure.smartbearsoftware.com/samples/testcomplete12/WebOrders/Login.aspx");
        }

        public enum browser
        {
            chromebrowser,
            firefoxbrowser
        }

        static void Main()
        {
            Console.WriteLine((int)browsertype.firefox);
            Console.WriteLine((int)browsertype.ie);
            
            Console.Read();

           

           // TestExeuction smartbear = new TestExeuction();
           // // smartbear.launchapp(browsertype.chrome);
           // smartbear.launchapp("CHROME");  // FAIL.
           // smartbear.launchapp("Chrome"); // fail..

           //// smartbear.launchapp();

           // smartbearprj sm = new smartbearprj(smartbear.driver);
           // sm.login();
           // sm.logout();
        }
    }

    struct sample
    {
        static int i = 10;

        void m1()
        {
            int[] x = new int[10];
        }
        sample(String s, int i)
        {

        }

        static void Main()
        {
            sample s = new sample();
            s.m1();
        }
    
    }
    
}
