using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AjaxcontrolProgram
    {
        static IWebDriver driver;
        public static void openapp()
        {
            driver = new ChromeDriver(@"D:\Library\Drivers");
            driver.Navigate().GoToUrl("https://www.amazon.co.in/");
            driver.Manage().Window.Maximize();
        }
        static void handlingajax(string input, string expectedtext)
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(input);
            System.Threading.Thread.Sleep(3000);
            string resultstext = driver.FindElement(By.Id("nav-flyout-searchAjax")).Text;
            Console.WriteLine(resultstext);

            char[] sep = { '\n' };  // \n means new line.

            string[] results = resultstext.Split(sep);
            // split method input is char[].
            // split method return type is string[].

            Console.WriteLine("Total no. of results are "+results.Length);
            int i = 0;
            bool flag = false;
            foreach (string res in results)
            {
                if(res.Trim().Equals(expectedtext))
                {
                    flag = true;
                    driver.FindElement(By.Id("issDiv" + i))
                        .Click();
                    break;
                }
                i = i + 1;
            }
            if(flag==true)
            {
                Console.WriteLine(expectedtext+" is in the results in " + (i + 1) + " position");
                if(driver.Title.Contains(expectedtext))
                    Console.WriteLine(expectedtext +" page is loaded correctly");
                else
                    Console.WriteLine(expectedtext + " page is NOT loaded correctly");
            }
            else
            {
                Console.WriteLine(expectedtext+" is NOT in the results ");
            }

            //for(int i=0; i<results.Length;i++)
            //{
            //    if (results[i].Trim().Equals("echo spot"))
            //    {
            //        Console.WriteLine("echo spot is in the results in "+(i+1)+" position");
            //        break;
            //    }
            //    if(i== (results.Length-1))// 0==9// 1==9... //9==9
            //    {
            //        Console.WriteLine("echo spot is NOT in the results");
            //    }
            //}

            //if(resultstext.Contains("echo spot"))
            //    Console.WriteLine("Test passed");
            //else
            //    Console.WriteLine("Test failed");


        }
        //static void Main()
        //{
        //    openapp();
        //    Console.WriteLine("Enter input to search in amazon");
        //    string userinput = Console.ReadLine();

        //    Console.WriteLine("Enter expected text in the results window");
        //    string userexpected = Console.ReadLine();

        //    handlingajax(userinput, userexpected);
        //}








    }
}
