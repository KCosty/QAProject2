using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project
{
    class Program
    {

        /*Username: site1
        Password: ASMfoo34b3CdZoss
        Database: bitter-site1
        default user/pass of nick/asdf */


        static void Main(string[] args)
        {
            //creating the WebDriver object
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            Console.WriteLine("Test1 - log in: ");
            Boolean blnTest01;
            blnTest01 = UnitTests.Test1Login(driver);
            TestResult(blnTest01);


        }
        static void TestResult(Boolean blnResult)
        {
            if (blnResult)
            {
                Console.WriteLine("Test has Passed!");
            }
            else
            {
                Console.WriteLine("Test has failed");
            }
        }
    }
}
