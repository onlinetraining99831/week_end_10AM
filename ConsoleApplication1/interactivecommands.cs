using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class emp
    {
        private int _salary = 100;

        public int salary
        {
            //get
            //{
            //    return _salary;
            //}
            set
            {
                if (value > _salary)
                    _salary = value;
            }
        }

        //static void Main()
        //{
        //    emp e = new emp();


        //    Console.Read();
        //}





        class interactivecommands
        {
            static IWebDriver driver;
            //static void Main()
            //{
            //    emp e = new emp();
            //   // Console.WriteLine(e.salary);

            //    e.salary = 10000;
            //    Console.WriteLine(e.salary);

            //    Console.Read();
            //}




            //static void Main()
            //{
            //    //interactivecommands com = new interactivecommands();
            //    //com.openapp();
            //    //com.login();

            //    openapp();
            //    //login();
            //    selectvaluesfromdropdown();
            //}

            static void login()  // private.
            {
                IWebElement username = driver.FindElement(By.Id("email"));
                username.SendKeys("valid@gmail.com");

                driver.FindElement(By.Name("pass")).SendKeys("password");
                driver.FindElement(By.XPath("//input[@type='submit' and @value='Log In']"));
                //driver.FindElement(By.XPath("(//input[starts-with(@id,'u_0_')])[1]")).Click();
            }

            static void selectvaluesfromdropdown()
            {
                //IWebElement day_ddown = driver.FindElement(By.Name("birthday_day"));
                //SelectElement day = new SelectElement(day_ddown);
                //day.SelectByIndex(10);

                new SelectElement(driver.FindElement(By.Name("birthday_day"))).SelectByIndex(10);

                System.Threading.Thread.Sleep(3000);

                //IWebElement mon_ddown = driver.FindElement(By.Id("month"));
                //SelectElement mon = new SelectElement(mon_ddown);
                //mon.SelectByText("Sept");

                new SelectElement(driver.FindElement(By.Id("month"))).SelectByText("Sept");

                System.Threading.Thread.Sleep(3000);

                //IWebElement year_ddown = driver.FindElement(By.Id("year"));
                //SelectElement year = new SelectElement(year_ddown);
                //year.SelectByValue("2019");

                new SelectElement(driver.FindElement(By.Id("year"))).SelectByValue("2019");
            }


            public static void openapp()
            {
                driver = new ChromeDriver(@"D:\Library\Drivers");
                driver.Navigate().GoToUrl("http://facebook.com");
                driver.Manage().Window.Maximize();
            }


        }
    }
}
