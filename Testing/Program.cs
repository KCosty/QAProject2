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
            //COULDN'T GET THE WINDOW TO START MAXIMIZED FOR THE TESTS TO WORK. YOU HAVE TO HAVE THE WINDOW MAXIMIZED

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

            //Test3 - 
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

            //Test15
            Console.WriteLine("Test15 - Logout");
            Boolean blnTest15;
            blnTest15 = UnitTests.Test15Logout(driver);
            TestResult(blnTest15);

            //Test16
            Console.WriteLine("Test16 - Logout");
            Boolean blnTest16;
            blnTest16 = UnitTests.Test16Logout(driver);
            TestResult(blnTest16);

            //Test17
            Console.WriteLine("Test17 - Logout");
            Boolean blnTest17;
            blnTest17 = UnitTests.Test14Logout(driver);
            TestResult(blnTest17);

            //Test18
            Console.WriteLine("Test18 - Logout");
            Boolean blnTest18;
            blnTest18 = UnitTests.Test18Logout(driver);
            TestResult(blnTest18);

            //Test19
            Console.WriteLine("Test19 - Logout");
            Boolean blnTest19;
            blnTest19 = UnitTests.Test19Logout(driver);
            TestResult(blnTest19);

            //Test20
            Console.WriteLine("Test20 - Logout");
            Boolean blnTest20;
            blnTest20 = UnitTests.Test20Logout(driver);
            TestResult(blnTest20);

            //Test21
            Console.WriteLine("Test21 - Logout");
            Boolean blnTest21;
            blnTest21 = UnitTests.Test21Logout(driver);
            TestResult(blnTest21);

            //Test22
            Console.WriteLine("Test22 - Logout");
            Boolean blnTest22;
            blnTest22 = UnitTests.Test22Logout(driver);
            TestResult(blnTest22);

            //Test23
            Console.WriteLine("Test23 - Logout");
            Boolean blnTest23;
            blnTest23 = UnitTests.Test23Logout(driver);
            TestResult(blnTest23);

            //Test24
            Console.WriteLine("Test24 - Logout");
            Boolean blnTest24;
            blnTest24 = UnitTests.Test24Logout(driver);
            TestResult(blnTest24);

            //Test25
            Console.WriteLine("Test25 - Logout");
            Boolean blnTest25;
            blnTest25 = UnitTests.Test25Logout(driver);
            TestResult(blnTest25);

            //Test26
            Console.WriteLine("Test26 - Logout");
            Boolean blnTest26;
            blnTest26 = UnitTests.Test26Logout(driver);
            TestResult(blnTest26);

            //Test27
            Console.WriteLine("Test27 - Logout");
            Boolean blnTest27;
            blnTest14 = UnitTests.Test27Logout(driver);
            TestResult(blnTest27);

            //Test28
            Console.WriteLine("Test28 - Logout");
            Boolean blnTest28;
            blnTest28 = UnitTests.Test28Logout(driver);
            TestResult(blnTest28);
        }
        static void TestResult(Boolean blnResult)
        {
            if (blnResult)
            {
                Console.WriteLine("Test has Passed!");
            }
            else
            {
                Console.WriteLine("Test has FAILED!!!!");
            }
        }
    }
}
