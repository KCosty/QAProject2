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
        public static Boolean Test3(IWebDriver driver)
        {
            return true;
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
    }
}
