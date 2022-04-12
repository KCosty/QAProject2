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
    public static class UnitTests
    {
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
            IWebElement lblTweeted = driver.FindElement(By.ClassName("t-text"));

            try
            {
                IWebElement clicky = driver.FindElement(By.Id("myTweet"));
                clicky.Click();
                String txtTweeted = "YOYOYOYO";
                txtTweeted = lblTweeted.Text;
                
                tweet(driver, txtTweeted);
                
                if (txtTweeted.Contains(lblTweeted.Text))
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
        public static Boolean Test4(IWebDriver driver)
        {
            return true;
        }
        public static Boolean Test5(IWebDriver driver)
        {
            return true;
        }
        public static Boolean Test6(IWebDriver driver)
        {
            return true;
        }
        public static Boolean Test7(IWebDriver driver)
        {
            return true;
        }
        public static Boolean Test8(IWebDriver driver)
        {
            return true;
        }
        public static Boolean Test9(IWebDriver driver)
        {
            return true;
        }
        public static Boolean Test10(IWebDriver driver)
        {
            return true;
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

            IWebElement btnSend = driver.FindElement(By.ClassName("btnTweet"));
            btnSend.Click();
        }
    }
}
