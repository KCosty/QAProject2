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
        //Reset()
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
        {
            try
            {
                IWebElement clicky = driver.FindElement(By.Id("myTweet"));

                //String txtTweeted = "YOYOYOYO";

                Tweet(driver, "");

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
                follow(driver);
                IAlert alertError = driver.SwitchTo().Alert();
                String txtAlert = alertError.Text;
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
                replymsg(driver, "This message is very interesting");
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

        public static Boolean Test15(IWebDriver driver)
        {
            try
            {
                tweetSpecChar(driver, "%$@#%^&*!");
                IWebElement alertError = driver.FindElement(By.Id("myTweet"));
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

        public static Boolean Test16(IWebDriver driver)
        {
            try
            {
                editProfPic(driver);
                IWebElement alertError = driver.FindElement(By.ClassName("[href*='edit_photo.php']"));
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

        public static Boolean Test17(IWebDriver driver)
        {
            try
            {
                TrendingPeople(driver);
                IWebElement alertError = driver.FindElement(By.Name("Trending"));
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

        public static Boolean Test18(IWebDriver driver)
        {
            try
            {
                email(driver, "whatwhatwhat69@@ehehehe.c3");
                IWebElement alertError = driver.FindElement(By.Id("email"));
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

        public static Boolean Test19(IWebDriver driver)
        {
            try
            {
                blankTweet(driver, "");
                IWebElement alertError = driver.FindElement(By.CssSelector("myTweet"));
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

        public static Boolean Test20(IWebDriver driver)
        {
            try
            {
                signIn(driver,  "");
                IWebElement alertError = driver.FindElement(By.Id("login_form"));
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

        public static Boolean Test21(IWebDriver driver)
        {
            try
            {
                register(driver, "");
                IWebElement alertError = driver.FindElement(By.ClassName("btn btn-primary btn-lg btn-block login-button"));
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

        public static Boolean Test22(IWebDriver driver)
        {
            try
            {
                phoneNum(driver, "506543212344");
                IWebElement alertError = driver.FindElement(By.Id("phone"));
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

        public static Boolean Test23(IWebDriver driver)
        {
            try
            {
               blankSignUp(driver, "");
                IWebElement alertError = driver.FindElement(By.CssSelector("[href*='signup_proc.php']"));
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

        public static Boolean Test24(IWebDriver driver)
        {
            try
            {
                pwrdMatch(driver);
                IWebElement alertError = driver.FindElement(By.Id("confirm"));
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

        public static Boolean Test25(IWebDriver driver)
        {
            try
            {
                address(driver, "one happy str33t");
                IWebElement alertError = driver.FindElement(By.Id("address"));
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

        public static Boolean Test26(IWebDriver driver)
        {
            try
            {
                postalCode(driver, "3e1a5a");
                IWebElement alertError = driver.FindElement(By.Id("postalCode"));
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
        static void replymsg(IWebDriver driver, String strReply)
        {
            IWebElement txtreply = driver.FindElement(By.Id("replyText"));
            txtreply.SendKeys(strReply);

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
        static void signIn(IWebDriver driver, String strblnkSignIn)
        {
            IWebElement signInForm = driver.FindElement(By.Id("login_form"));
            signInForm.SendKeys(strblnkSignIn;
        }

        static void tweetSpecChar(IWebDriver driver, String strTweet)
        {
            IWebElement tweetChar = driver.FindElement(By.Id("myTweet"));
            tweetChar.SendKeys(strTweet);
        }
        static void blankTweet(IWebDriver driver, String strblktweet)
        {
            IWebElement blnkTweet = driver.FindElement(By.CssSelector("myTweet"));
            blnkTweet.SendKeys(strblktweet);
        }
        static void editProfPic(IWebDriver driver)
        {
            IWebElement profPic = driver.FindElement(By.CssSelector("[href*='edit_photo.php']"));
            profPic.Click();
        }
        static void TrendingPeople(IWebDriver driver)
        {
            IWebElement trending = driver.FindElement(By.Name("Trending"));
            trending.Click();
        }
        static void email(IWebDriver driver, String strEmail)
        {
            driver.Url = "http://47.55.247.242/site1/signup.php";

            IWebElement emailAd = driver.FindElement(By.Id("email"));
            emailAd.SendKeys(strEmail);
        }
        static void register(IWebDriver driver, String strReg)
        {
            IWebElement btnreg = driver.FindElement(By.ClassName("btn btn-primary btn-lg btn-block login-button"));
            btnreg.SendKeys(strReg);
        }
        static void phoneNum(IWebDriver driver, String strPhone)
        {
            IWebElement phoneNum = driver.FindElement(By.Id("phone"));
             phoneNum.SendKeys(strPhone);
        }
        static void blankSignUp(IWebDriver driver, String strblnkReg)
        {
            IWebElement signUp = driver.FindElement(By.CssSelector("[href*='signup_proc.php']"));
             signUp.SendKeys(strblnkReg);
        }
        static void pwrdMatch(IWebDriver driver)
        {
            IWebElement pwrd = driver.FindElement(By.Id("confirm"));
             pwrd.Click();
        }
        static void address(IWebDriver driver, String strAddress)
        {
            IWebElement addresstxt = driver.FindElement(By.Id("address"));
             addresstxt.SendKeys(strAddress);
        }
        static void postalCode(IWebDriver driver, String strPCode)
        {
            IWebElement pCode = driver.FindElement(By.Id("postalCode"));
             pCode.SendKeys(strPCode);
        }
    }
}
