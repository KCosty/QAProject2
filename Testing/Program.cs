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
            //ChromeOptions option = new ChromeOptions();
            //option.AddArgument("start-maximized");
            //COULDN'T GET THE WINDOW TO START MAXIMIZED, FOR THE TESTS TO WORK YOU HAVE TO HAVE THE WINDOW MAXIMIZED

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
            Console.WriteLine("Test3 - Tweet: ----Couldn't actually get this to work, but i think my logic is there");
            Boolean blnTest03;
            blnTest03 = UnitTests.Test3Tweet(driver);
            TestResult(blnTest03);

            //Test4 -- works when there's people to be followed
            Console.WriteLine("Test4 - Follow: ----Works when there's people to follow");
            Boolean blnTest04;
            blnTest04 = UnitTests.Test4Follow(driver);
            TestResult(blnTest04);

            //Test5
            Console.WriteLine("Test5 - HomePageClick: ");
            Boolean blnTest05;
            blnTest05 = UnitTests.Test5HomeClick(driver);
            TestResult(blnTest05);

            //Test6
            Console.WriteLine("Test6 - MomentsClick: ----Dead link");
            Boolean blnTest06;
            blnTest06 = UnitTests.Test6Moments(driver);
            TestResult(blnTest06);

            //Test7
            Console.WriteLine("Test7 - NotificationsClick: ");
            Boolean blnTest07;
            blnTest07 = UnitTests.Test7Notifications(driver);
            TestResult(blnTest07);

            //Test8
            Console.WriteLine("Test8 - MessagesClick: ");
            Boolean blnTest08;
            blnTest08 = UnitTests.Test8Messages(driver);
            TestResult(blnTest08);

            //Test9
            Console.WriteLine("Test9 - ContactUsClick: ");
            Boolean blnTest09;
            blnTest09 = UnitTests.Test9ContactUs(driver);
            TestResult(blnTest09);

            //Test10
            Console.WriteLine("Test10 - ContactUsToHomeClick: ");
            Boolean blnTest10;
            blnTest10 = UnitTests.Test10ContactToHome(driver);
            TestResult(blnTest10);

            //Test11
            Console.WriteLine("Test11 - RetweetClick: ");
            Boolean blnTest11;
            blnTest11 = UnitTests.Test11Retweet(driver);
            TestResult(blnTest11);

            //Test12
            Console.WriteLine("Test12 - ReplyClick");
            Boolean blnTest12;
            blnTest12 = UnitTests.Test12Reply(driver);
            TestResult(blnTest12);

            //Test13
            Console.WriteLine("Test13 - Reply Message");
            Boolean blnTest13;
            blnTest13 = UnitTests.Test13ReplyMsg(driver);
            TestResult(blnTest13);

            //Test14
            Console.WriteLine("Test14 - Logout");
            Boolean blnTest14;
            blnTest14 = UnitTests.Test14Logout(driver);
            TestResult(blnTest14);

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
