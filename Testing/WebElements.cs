using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project
{
    class WebElements
    {
    public static IWebElement notifications(IWebDriver driver)
    {
        IWebElement btnnotify = driver.FindElement(By.CssSelector("[href*='notifications.php']"));
        btnnotify.Click();
    }
    public static IWebElement messages(IWebDriver driver)
    {
        IWebElement btnmsg = driver.FindElement(By.CssSelector("[href*='DirectMessage']"));
        btnmsg.Click();
    }
    public static IWebElement contact(IWebDriver driver)
    {
        IWebElement btncontact = driver.FindElement(By.CssSelector("[href*='contactus']"));
        btncontact.Click();
    }
    public static IWebElement contacttohome(IWebDriver driver)
    {
        IWebElement btnconhome = driver.FindElement(By.CssSelector("[href*='index.php']"));
        btnconhome.Click();
    }
    public static IWebElement retweet(IWebDriver driver)
    {
        IWebElement btnretweet = driver.FindElement(By.Name("retweetClick"));
        btnretweet.Click();
    }
    public static IWebElement reply(IWebDriver driver)
    {
        IWebElement btnreply = driver.FindElement(By.Name("replyClick"));
        btnreply.Click();
    }
    public static IWebElement replymsg(IWebDriver driver)
    {
        IWebElement txtreply = driver.FindElement(By.Id("replyText"));
        txtreply.SendKeys("This is my message to you and it's very interesting.");

        IWebElement btnreplymsg = driver.FindElement(By.Name("submit"));
        btnreplymsg.Click();
    }
    public static IWebElement logout(IWebDriver driver)
    {
        IWebElement btndropdown = driver.FindElement(By.Id("dropdown01"));
        btndropdown.Click();

        IWebElement btnlogout = driver.FindElement(By.CssSelector("[href*='logout.php']"));
        btnlogout.Click();
    }


}
}
