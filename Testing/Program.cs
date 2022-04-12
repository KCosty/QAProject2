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

            //Test 1
            Console.WriteLine("Test1 - Bad log in credentials: ");
            Boolean blnTest01;
            blnTest01 = UnitTests.Test1BadLogIn(driver);
            TestResult(blnTest01);


            //Test 2
            Console.WriteLine("Test2 - log in: ");
            Boolean blnTest02;
            blnTest02 = UnitTests.Test2LogIn(driver);
            TestResult(blnTest02);

            //Test3
            Console.WriteLine("Test3 - Tweet: ");
            Boolean blnTest03;
            blnTest03 = UnitTests.Test3Tweet(driver);
            TestResult(blnTest03);


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
