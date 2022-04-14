using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project
{
    public static class UnitTests
    {        //http://47.55.247.242/site1/login.php -- Web page we are using
        public static Boolean Test1BadLogIn(IWebDriver driver)
        {
            try
            {
                logIn(driver, "1234", "1234");
                IAlert alertError = driver.SwitchTo().Alert();
                String txtAlert = alertError.Text;
                if (txtAlert.Contains(alertError.Text))
                {
                    alertError.Accept();
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
            
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://47.55.247.242/site1/login.php");
            try
            {
                logIn(driver, "nick", "asdf");
                IAlert alertError = driver.SwitchTo().Alert();
                String txtAlert = alertError.Text;
                if (txtAlert.Contains(alertError.Text))
                {
                    alertError.Accept();
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }
        public static Boolean Test3Tweet(IWebDriver driver)
        { //if t-text includes tweet text return true
            Thread.Sleep(3000);
            //IWebElement lblTweeted = driver.FindElement(By.ClassName("t-text"));

            try
            {
                IWebElement clicky = driver.FindElement(By.Id("button"));
                
                String txtTweeted = "YOYOYOYO";
              
                tweet(driver, txtTweeted);
                
                clicky.Click();
                //tweet(driver, txtTweeted);
                return true;
                
            }
            catch
            {
                Console.WriteLine("Test tweet failed");
                return false;
            }

            
        }
        public static Boolean Test4Follow(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(2000);
                follow(driver);
                IAlert alertError = driver.SwitchTo().Alert();
                
                if (alertError.Text.Contains("You are NOW FOLLOWING "))
                {
                    alertError.Accept();
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
                Thread.Sleep(2000);
                homeclick(driver);
                string currentURL = driver.Url;

                if (currentURL != "http://47.55.247.242/site1/index.php")
                {
                    return false;
                }
                else{return true;}
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
                Thread.Sleep(2000);
                momentsclick(driver);
                string currentURL = driver.Url;
                if(currentURL == "http://47.55.247.242/site1/moments.php")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
                notifications(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/notifications.php")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
                messages(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/DirectMessage.php")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
                contact(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/contactus")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
                contacttohome(driver);
                string currentURL = driver.Url;
                if (currentURL == "http://47.55.247.242/site1/index.php")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
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
                Thread.Sleep(2000);
                reply(driver);
                string currentURL = driver.Url;

                if (currentURL == "http://47.55.247.242/site1/reply.php")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
                replymsg(driver);
                string currentURL = driver.Url;

                if (currentURL == "http://47.55.247.242/site1/index.php")
                {
                    return true;
                }
                else { return false; }
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
                Thread.Sleep(2000);
                logout(driver);
                string currentURL = driver.Url;

                if (currentURL == "http://47.55.247.242/site1/login.php")
                {
                    return true;
                }
                else { return false; }
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
        static void tweet(IWebDriver driver, String strTweet)
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
