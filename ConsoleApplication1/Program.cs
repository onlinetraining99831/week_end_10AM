using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program  // 
    {
        static IWebDriver driver;   // int x;

        Program p = null;

        Program createdefaultservice(string path)
        {
            return p;
        }


        static void launchchrome()
        {
             driver = new ChromeDriver(@"D:\Library\Drivers");  // creating an object with input as "path of exe file"
                                                                // driver = new ChromeDriver("D:\\Library\\Drivers");  another way..
                                                                
            driver.Navigate().GoToUrl("http://www.google.co.in");

            System.Threading.Thread.Sleep(5000);

            driver.Quit();

        }
        static void launchfirefox()
        {
            //  classname         vname  =   classname.method(string);
            FirefoxDriverService ser = FirefoxDriverService.CreateDefaultService(@"D:\Library\Drivers");//gecodriver.exe
            ser.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //  int x = 10;

            driver = new FirefoxDriver(ser);  // creating an object with input as "Firefoxdriverserivce class"
            driver.Manage().Window.Maximize();
        }
        static void edgebrowser()
        {
            driver = new EdgeDriver(@"D:\Library\Drivers");
            driver.Manage().Window.Maximize();
        }

        //static void Main(string[] args)
        //{
        //   launchchrome();
        //   //launchfirefox();
        //  // edgebrowser();
        //}
    }
}
