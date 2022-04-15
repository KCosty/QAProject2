using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project
{
    class UnitTests
    {
        public static Boolean Test1BadLogIn(IWebDriver driver)
        {
            try
            {
                logIn(driver, "1234", "1234");
                IWebElement alertError = driver.FindElement(By.ClassName("/////////"));
                String txtAlert = alertError.Text;
                if (txtAlert.Contains(alertError.Text))
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        public static Boolean Test2LogIn(IWebDriver driver)
        {
            try
            {
                logIn(driver, "nick", "asdf");
                IWebElement alertError = driver.FindElement(By.ClassName("/////////"));
                String txtAlert = alertError.Text;
                if (txtAlert.Contains(alertError.Text))
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        public static Boolean Test3Tweet(IWebDriver driver,  String txtTweeted)
        {
            try
            {
                logIn(driver, "YOYOYOYO");
                    IWebElement alertError = driver.FindElement(By.ClassName("/////////"));
                    String txtAlert = alertError.Text;
                    if (txtAlert.Contains(alertError.Text))
                    {
                        return false;
                    }
                    return true;
                }
                catch
                {
                    return true;
                }
            }

        public static Boolean Test4Follow(IWebDriver driver)
        {
            try
            {
                follow(driver, );
                IWebElement alertError = driver.FindElement(By.ClassName("/////////"));
                String txtAlert = alertError.Text;
                if (alertError.Text.Contains("You are NOW FOLLOWING "))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test5HomeClick(IWebDriver driver)
        {
            try
            {
                homeclick(driver);
                string currentURL = driver.Url;
                if (currentURL != "http://47.55.247.242/site1/index.php")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return true;
            }
        }

        public static Boolean Test6Moments(IWebDriver driver)
        {
            try
            {
                momentsclick(driver);
                string currentURL = driver.Url;
                if(currentURL == "http://47.55.247.242/site1/moments.php")
                {
                    return true;
                }
                else
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test7Notifications(IWebDriver driver)
        {
            try
            {
                notifications(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/notifications.php")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test8Messages(IWebDriver driver)
        {
            try
            {
                messages(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/DirectMessage.php")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test9ContactUs(IWebDriver driver)
        {
            try
            {
                contact(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/contactus")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test10ContactToHome(IWebDriver driver)
        {
            try
            {
                contacttohome(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/index.php")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test11Retweet(IWebDriver driver)
        {
            try
            {
                //xpath =/html/body/div/div/div[2]/div[2]/div[1]/b    /html/body/div/div/div[2]/div[2]/div[1]/b
                retweet(driver);
                return true;  
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test12Reply(IWebDriver driver)
        {
            try
            {
                reply(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/reply.php")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test13ReplyMsg(IWebDriver driver)
        {
            try
            {
                replymsg(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/index.php")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean Test14Logout(IWebDriver driver)
        {
            try
            {
                logout(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/login.php")
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            catch
            {
                return false;
            }
        }







        static void logIn(IWebDriver driver, String strUserName, String strPass)
        {
            driver.Url = "http://47.55.247.242/site1/login.php";

            IWebElement txtUserName = driver.FindElement(By.Id("username"));
            txtUserName.SendKeys(strUserName);

            IWebElement txtPass = driver.FindElement(By.Id("password"));
            txtPass.SendKeys(strPass);

            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            btnLogin.Click();
        }




        static void Tweet(IWebDriver driver, String strTweet)
        {
            driver.Url = "http://47.55.247.242/site1/index.php?user=1025";
            
            IWebElement txtTweet = driver.FindElement(By.Id("myTweet"));
            txtTweet.SendKeys(strTweet);

            IWebElement btnTweet = driver.FindElement(By.Id("myTweet"));
            btnTweet.Click();

            IWebElement btnSend = driver.FindElement(By.TagName("btnTweet"));
            btnSend.Click();
        }



        static void follow(IWebDriver driver)
        {
            IWebElement btnfollow = driver.FindElement(By.Name("follow"));
            btnfollow.Click();
        }
        static void homeclick(IWebDriver driver)
        {
            IWebElement btnhome = driver.FindElement(By.CssSelector("[href*='index.php']"));
            btnhome.Click();
        }
        static void momentsclick(IWebDriver driver)
        {
            IWebElement btnmom = driver.FindElement(By.CssSelector("[href*='moments.php']"));
            btnmom.Click();
        }
        static void notifications(IWebDriver driver)
        {
            //IWebElement btnnotify = driver.FindElement(By.XPath("Notifications")); //*[@id="navbarsExampleDefault"]/ul/li[3]/a
            IWebElement btnnotify = driver.FindElement(By.CssSelector("[href*='notifications.php']"));
            btnnotify.Click();
        }
        static void messages(IWebDriver driver)
        {
            IWebElement btnmsg = driver.FindElement(By.CssSelector("[href*='DirectMessage']"));
            btnmsg.Click();
        }
        static void contact(IWebDriver driver)
        {
            IWebElement btncontact = driver.FindElement(By.CssSelector("[href*='contactus']"));
            btncontact.Click();
        }
        static void contacttohome(IWebDriver driver)
        {
            IWebElement btnconhome = driver.FindElement(By.CssSelector("[href*='index.php']"));
            btnconhome.Click();
        }
        static void retweet(IWebDriver driver)
        {
            IWebElement btnretweet = driver.FindElement(By.Name("retweetClick"));
            btnretweet.Click();
        }
        static void reply(IWebDriver driver)
        {
            IWebElement btnreply = driver.FindElement(By.Name("replyClick"));
            btnreply.Click();
        }
        static void replymsg(IWebDriver driver)
        {
            IWebElement txtreply = driver.FindElement(By.Id("replyText"));
            txtreply.SendKeys("This is my message to you and it's very interesting.");

            IWebElement btnreplymsg = driver.FindElement(By.Name("submit"));
            btnreplymsg.Click();
        }
        static void logout(IWebDriver driver)
        {
            IWebElement btndropdown = driver.FindElement(By.Id("dropdown01"));
            btndropdown.Click();

            IWebElement btnlogout = driver.FindElement(By.CssSelector("[href*='logout.php']"));
            btnlogout.Click();
        }


    }
}
